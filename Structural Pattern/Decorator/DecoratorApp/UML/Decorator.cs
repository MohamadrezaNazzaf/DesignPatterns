namespace DecoratorApp.UML;

public abstract class Decorator : Component
{
    private readonly Component _component;

    protected Decorator(Component component)
    {
        _component = component;
    }

    public override void operation()
    {
        _component.operation();
    }
}

public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }

    public override void operation()
    {
        base.operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("This is write at NewFeature()");
    }
}