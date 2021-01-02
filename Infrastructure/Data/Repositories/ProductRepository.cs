using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;

        }

        public Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<ProductBrand>> GetProductBTypesAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                                .Include(p => p.ProductBrand)
                                .Include(p => p.ProductType)
                                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                                 .Include(p => p.ProductBrand)
                                 .Include(p => p.ProductType)
                                 .ToListAsync();
        }
    }
}