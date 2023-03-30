using Green.CT.Asyncify.Contracts.Requests;

namespace Green.CT.Asyncify.Contracts.Handlers;

public interface IAsyncRequestHandler
{
    void Handle(CancellationToken cancellationToken);
    AsyncRequestStatus GetStatus();
    object? GetResult();
    Guid Id { get; }
}