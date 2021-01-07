using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypeAndBrand : BaseSpecification<Product>
    {
        
        public ProductsWithTypeAndBrand(ProductSpecParam prodParam) :
        base( x => 
            (string.IsNullOrEmpty(prodParam.Search) || x.Name.ToLower().Contains(prodParam.Search)) &&
            (!prodParam.BrandId.HasValue || x.ProductBrandId == prodParam.BrandId) &&
            (!prodParam.TypeId.HasValue || x.ProductTypeId == prodParam.TypeId)
        )
        {
           
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(prodParam.PageSize, prodParam.PageSize * (prodParam.PageIndex -1));

            if(!string.IsNullOrEmpty(prodParam.Sort)){

                switch(prodParam.Sort){
                     case "priceAsc":
                        AddOrderBy(p =>p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;

                }
                   


            }
            
        }

        public ProductsWithTypeAndBrand(int id) : base(x => x.Id ==id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}