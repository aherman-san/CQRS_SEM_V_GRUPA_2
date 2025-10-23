using ExampleCQRS.Database;
using ExampleCQRS.DTOS;
using ExampleCQRS.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ExampleCQRS.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _dbContext;

        public ProductService(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SimpleProductDto[]> GetPromotedProducts()
        {
            return await _dbContext.Products
                .Where(p => p.Stock > 0)
                .OrderBy(x => Guid.NewGuid().ToString())
                .Select(x => x.ToSimpleProductDto())
                .ToArrayAsync();
        }
    }
}
