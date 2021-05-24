using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class CreatorA : ICreator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
