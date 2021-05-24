using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class CreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
}
