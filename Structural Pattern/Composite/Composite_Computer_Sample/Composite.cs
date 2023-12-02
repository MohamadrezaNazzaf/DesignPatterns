using System.Runtime.Intrinsics.X86;

namespace Composite_Computer_Sample;

public class Composite : IComponent
{
    public string Name { get; set; }
    public int Price { get; set; }
    List<IComponent> Components = new List<IComponent>();


    public Composite(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public int DisplayPrice()
    {
        int sumPrice = Price;

        foreach (var item in Components)
        {
            sumPrice += item.DisplayPrice();
        }
        Console.WriteLine($"{Name}: {sumPrice}");
        return sumPrice;
    }

    public void AddComponent(IComponent component)
    {
        Components.Add(component);
    }

    public void RemoveComponent(IComponent component)
    {
        Components.Remove(component);
    }
}