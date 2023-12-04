namespace FlyweightApp.UML;

public abstract class Flyweight
{
    public abstract void Operation(string extrisicState);
}

class ConcreteFlyweight : Flyweight
{
    private string _intrisicState;
    public ConcreteFlyweight(string intrisicState)
    {
        _intrisicState = intrisicState;
    }

    public override void Operation(string extrisicState)
    {
        Console.WriteLine($"ConcreteFlyweight.Operation({_intrisicState}) : \" {extrisicState} \" ");
    }
}

class FlyweightFactory
{
    private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

    public Flyweight GetFlyweight(string key)
    {
        Flyweight flyweight = null;
        if (flyweights.TryGetValue(key, out flyweight)) { }
        else
        {
            flyweights.Add(key, new ConcreteFlyweight(key));
        }

        return flyweights[key];
    }
}


class UnSharedConcreteFlyweight : Flyweight
{
    private IEnumerable<Flyweight> _flyweights;
    public UnSharedConcreteFlyweight(IEnumerable<Flyweight> flyweights)
    {
        _flyweights = flyweights;
    }
    public override void Operation(string extrisicState)
    {
        Console.WriteLine("* UnSharedConcreteFlyweight *");
        foreach (var item in _flyweights)
        {
            item.Operation(extrisicState);
        }
    }
}