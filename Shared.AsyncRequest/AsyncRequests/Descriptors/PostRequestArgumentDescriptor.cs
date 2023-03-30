using Microsoft.AspNetCore.Http;

namespace Green.CT.Asyncify.AsyncRequests.Descriptors;

internal class PostRequestArgumentDescriptor : BodyBasedRequestArgumentDescriptor
{
    public PostRequestArgumentDescriptor(HttpRequest httpRequest)
        : base(httpRequest)
    {
    }

}