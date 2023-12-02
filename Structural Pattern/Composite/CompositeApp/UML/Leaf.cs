namespace CompositeApp.UML;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Display(int Depth)
    {
        Console.WriteLine(new string('-', Depth) + name);
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}