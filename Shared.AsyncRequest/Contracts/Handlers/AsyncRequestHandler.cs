using Green.CT.Asyncify.Contracts.Requests;

namespace Green.CT.Asyncify.Contracts.Handlers;

internal sealed class AsyncRequestHandler : IAsyncRequestHandler
{
    private readonly IAsyncRequest _request;

    public AsyncRequestHandler(IAsyncRequest asyncRequest)
    {
        _request = asyncRequest;
    }

    public void Handle(CancellationToken cancellationToken)
    {
        Task.Run(() =>
        {
            _request.Invoke(cancellationToken);
        }, cancellationToken);
    }

    public AsyncRequestStatus GetStatus() => _request.GetStatus();
    public object? GetResult() => _request.GetResult();
    public Guid Id => _request.Id;
}