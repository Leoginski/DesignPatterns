using FactoryMethod.Products;

namespace FactoryMethod
{
    abstract public class Creator
    {
        public abstract Product CreateProduct();
    }
}
