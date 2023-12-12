using System.ComponentModel;

namespace CompositeApp.UML;

public class Composite : Component
{
    private List<Component> _components = new List<Component>();
    public Composite(string name) : base(name)
    {
    }

    public Composite(string name, Component[] components) : base(name)
    {
        foreach (var component in components)
        {
            Add(component);
        }

        // second way for loop:
        // components.ToList().ForEach(item => Add(item));
    }

    public override void Add(Component component)
    {
        _components.Add(component);
    }

    public override void Remove(Component component)
    {
        _components.Remove(component);
    }

    public override void Display(int depth = 1)
    {
        Console.WriteLine(new string('-', depth) + name);

        foreach (var component in _components)
        {
            component.Display(depth + 2);
        }
    }
}