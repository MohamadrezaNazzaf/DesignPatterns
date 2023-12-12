using AbstractFactoryApp.Services.ProductA;
using AbstractFactoryApp.Services.ProductB;

namespace AbstractFactoryApp.AbstractFactories
{
    public interface AbstractFactory
    {
        AbstractProductA CreateProductA();
        AbstractProductB CreateProductB();
    }
}