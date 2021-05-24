using System;

namespace FactoryMethod.Products
{
    public class ProductA : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("ProductA");
        }
    }
}
