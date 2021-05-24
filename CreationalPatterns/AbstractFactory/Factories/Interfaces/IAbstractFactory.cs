using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ISofa CreateSofa();
    }
}