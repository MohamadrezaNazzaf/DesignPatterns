namespace DecoratorApp.UML;

public abstract class Component
{
    public abstract void operation();
}

public class ConcreteComponent : Component
{
    public override void operation()
    {
        Console.WriteLine("ConcreteComponent.operation() ---> run");
    }
}