using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypeAndBrand : BaseSpecification<Product>
    {
        public ProductsWithTypeAndBrand()
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
            
        }

        public ProductsWithTypeAndBrand(int id) : base(x => x.Id ==id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}