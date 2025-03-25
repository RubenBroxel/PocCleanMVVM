// Infrastructure Layer (Repositories)
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    public class ProductRepository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.FromResult(new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200 },
                new Product { Id = 2, Name = "Mouse", Price = 20 }
            });
        }
    }
    
    public class SaleRepository : ISaleRepository
    {
        public async Task<bool> SaveSaleAsync(Sale sale)
        {
            return await Task.FromResult(true);
        }
    }
}