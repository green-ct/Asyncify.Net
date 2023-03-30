using Microsoft.AspNetCore.Http;

namespace Green.CT.Asyncify.AsyncRequests.Descriptors;

internal sealed class DeleteRequestArgumentDescriptor : RequestArgumentDescriptor
{
    public DeleteRequestArgumentDescriptor(HttpRequest httpRequest)
        : base(httpRequest)
    {
    }
    
}