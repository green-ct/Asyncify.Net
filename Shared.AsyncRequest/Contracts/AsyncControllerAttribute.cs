namespace Green.CT.Asyncify.Contracts;

[AttributeUsage(AttributeTargets.Class)]
public class AsyncControllerAttribute : Attribute
{
    private readonly Type? _controllerType;
    public AsyncControllerAttribute(Type? type)
    {
        _controllerType = type;
    }

    public new Type? GetType() => _controllerType;
}