using System;

namespace FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        var creator = new ConcreteCreator();
        Product p;
        p = creator.FactoryMethod("ConcreteProduct1");
        p.Excute();
        p = creator.FactoryMethod("ConcreteProduct2");
        p.Excute();
        p = creator.FactoryMethod("DefultProduct");
        p.Excute();
    }
}

public abstract class Product
{
    public abstract void Excute();
}

public class ConcreteProduct1 : Product
{
    public override void Excute()
    {
        Console.WriteLine("ConcreateProduct1.Excute...");
    }
}

public class ConcreteProduct2 : Product
{
    public override void Excute()
    {
        Console.WriteLine("ConcreteProduct2.Excute...");

    }
}
public class DefultProduct : Product
{
    public override void Excute()
    {
        Console.WriteLine("DefultProduct.Excute...");
    }
}



public abstract class Creator
{
    public abstract Product FactoryMethod(string implementorName);
}

public class ConcreteCreator : Creator
{
    public override Product FactoryMethod(string implementorName)
    {
        return implementorName switch
        {
            "ConcreteProduct1" => new ConcreteProduct1(),
            "ConcreteProduct2" => new ConcreteProduct2(),
            "DefultProduct" => new DefultProduct(),
        };
    }
}