using FactoryMethod.Creators;
using FactoryMethod.Products;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator creator;

            string platform = "Windows";

            switch (platform)
            {
                case "Windows":
                    {
                        creator = new CreatorA();
                        break;
                    }
                case "Web":
                    {

                        creator = new CreatorB();
                        break;
                    }
                default:
                    throw new ApplicationException("Invalid Platorm");
            }

            //Generic application
            IProduct product = creator.CreateProduct();
            product.DoStuff();
        }
    }
}
