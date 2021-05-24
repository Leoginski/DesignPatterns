using System;

namespace FactoryMethod.Products
{
    public class ProductB : IProduct
    {
        public void DoStuff()
        {
            Console.WriteLine("ProductB");
        }
    }
}
