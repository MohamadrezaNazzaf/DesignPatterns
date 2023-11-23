namespace BridgeApp.UML.Implementors;

public abstract class Implementor
{
    public abstract void Implementaion();
}

public class ConcreateImplementor : Implementor
{
    public override void Implementaion()
    {
        Console.WriteLine("Run   ConcreateImplementor.Implementaion()....");
    }
}