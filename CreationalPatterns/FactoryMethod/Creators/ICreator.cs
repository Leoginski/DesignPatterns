using FactoryMethod.Products;

namespace FactoryMethod
{
    abstract public class ICreator
    {
        public abstract IProduct CreateProduct();
    }
}
