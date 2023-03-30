namespace Green.CT.Asyncify.Contracts;

public class AsyncRequestAttribute : Attribute
{
    private readonly string _method;
    public AsyncRequestAttribute(string methodName)
    {
        _method = methodName;
    }

    public string GetMethodName() => _method;
}