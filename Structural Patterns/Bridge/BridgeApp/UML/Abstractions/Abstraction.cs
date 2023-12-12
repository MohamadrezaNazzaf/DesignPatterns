using BridgeApp.UML.Implementors;

namespace BridgeApp.UML.Abstractions;

public abstract class Abstraction
{
    private readonly Implementor _implementor;

    protected Abstraction()
    {
        _implementor = new ConcreateImplementor();
    }

    public virtual void Function()
    {
        _implementor.Implementaion();
    }
}

public class RefinedAbstraction : Abstraction
{
}