using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    public class ArtDecoFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
