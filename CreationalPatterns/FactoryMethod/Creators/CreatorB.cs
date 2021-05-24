using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class CreatorB : ICreator
    {
        public override IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}
