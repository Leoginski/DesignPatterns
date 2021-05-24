using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products.Interfaces;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory;
            string decotarionStyle = "Modern";

            switch (decotarionStyle)
            {
                case "ArtDeco":
                    factory = new ArtDecoFactory();
                    break;
                case "Modern":
                    factory = new ModernFactory();
                    break;
                case "Victorian":
                    factory = new VictorianFactory();
                    break;
                default:
                    throw new Exception("Error! Unknown decoration style.");
            }

            ISofa sofa = factory.CreateSofa();
            IChair chair = factory.CreateChair();
            ICoffeeTable coffeeTable = factory.CreateCoffeeTable();

            Console.WriteLine($"Style: {decotarionStyle}");
            Console.WriteLine($"Sofa: {sofa.GetType().Name}");
            Console.WriteLine($"Chair: {chair.GetType().Name}");
            Console.WriteLine($"CoffeeTable: {coffeeTable.GetType().Name}");
        }
    }
}