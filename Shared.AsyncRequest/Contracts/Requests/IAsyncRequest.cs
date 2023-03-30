namespace Green.CT.Asyncify.Contracts.Requests;

public interface IAsyncRequest
{
    void Invoke(CancellationToken cancellationToken);
    object? GetResult();
    AsyncRequestStatus GetStatus();
    Guid Id { get; }
}