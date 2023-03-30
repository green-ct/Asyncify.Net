using Green.CT.Asyncify.Contracts.Handlers;
using Green.CT.Asyncify.Contracts.Requests;

namespace Green.CT.Asyncify.Extensions;

internal static class AsyncRequestExtensions
{
    public static AsyncRequestDto ToDto(this IAsyncRequestHandler asyncRequest)
    {
        return new AsyncRequestDto(trackId: asyncRequest.Id,
            status: asyncRequest.GetStatus(),
            result: asyncRequest.GetResult());
    }
}