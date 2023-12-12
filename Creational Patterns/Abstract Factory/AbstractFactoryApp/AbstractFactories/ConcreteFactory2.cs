using AbstractFactoryApp.Services.ProductA;
using AbstractFactoryApp.Services.ProductB;


namespace AbstractFactoryApp.AbstractFactories
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
