using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
