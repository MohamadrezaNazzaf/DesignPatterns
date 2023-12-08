using AbstractFactoryApp.AbstractFactories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryApp.AbstractFactories.AbstractFactory abstractFactory1 = new ConcreteFactory2();
            var productA = abstractFactory1.CreateProductA();
            var productB = abstractFactory1.CreateProductB();
            productA.Execute();
            productB.Execute();
            Console.WriteLine("Hello World!");
        }
    }
}