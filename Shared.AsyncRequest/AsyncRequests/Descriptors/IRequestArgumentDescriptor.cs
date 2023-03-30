namespace Green.CT.Asyncify.AsyncRequests.Descriptors;

public interface IRequestArgumentDescriptor
{
    object?[] GetArgument();
}