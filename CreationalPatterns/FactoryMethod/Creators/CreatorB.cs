using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class CreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
}
