using AbstractFactoryApp.Services.ProductA;
using AbstractFactoryApp.Services.ProductB;


namespace AbstractFactoryApp.AbstractFactories
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
