using System.Reflection;

namespace Green.CT.Asyncify.Contracts.Requests;

internal class AsyncRequest : IAsyncRequest
{
    private readonly MethodInfo _method;
    private readonly object _constructor;
    private readonly object[] _arguments;

    public Guid Id { get; init; }
    public DateTime CreationDate { get; init; }
    public AsyncRequestStatus Status { get; private set; } = AsyncRequestStatus.Pending;
    private object? Result { get; set; }

    //TODO:  throw exception when task not completed? 
    public object? GetResult()
    {
        return Status != AsyncRequestStatus.Complete 
            ? null 
            : Result;
    }

    public AsyncRequestStatus GetStatus() => Status;

    public AsyncRequest(MethodInfo method,
        object constructor,
        object[] arguments)
    {
        _method = method;
        _constructor = constructor;
        _arguments = arguments;

        Id = Guid.NewGuid();
        CreationDate = DateTime.UtcNow;
    }

    public void Invoke(CancellationToken cancellationToken)
    {
        try
        {
            Result = _method.Invoke(_constructor, _arguments);
        }
        catch (TimeoutException)
        {
            Status = AsyncRequestStatus.Timeout;
        }
        catch (Exception)
        {
            Status = AsyncRequestStatus.Failed;
        }

        Status = AsyncRequestStatus.Complete;
    }



}