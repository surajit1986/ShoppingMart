using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFilterForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFilterForCountSpecification(ProductSpecParam prodParam):
        base( x => 
             (string.IsNullOrEmpty(prodParam.Search) || x.Name.ToLower().Contains(prodParam.Search)) &&
            (!prodParam.BrandId.HasValue || x.ProductBrandId == prodParam.BrandId) &&
            (!prodParam.TypeId.HasValue || x.ProductTypeId == prodParam.TypeId)
        )
        {
        }
    }
}