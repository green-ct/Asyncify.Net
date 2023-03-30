using Microsoft.AspNetCore.Http;

namespace Green.CT.Asyncify.AsyncRequests.Descriptors;

internal sealed class PutRequestArgumentDescriptor : BodyBasedRequestArgumentDescriptor
{
    public PutRequestArgumentDescriptor(HttpRequest httpRequest)
        : base(httpRequest)
    {
    }
   
}