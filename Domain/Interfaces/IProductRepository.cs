using Domain.Entities;
// Domain Layer (Interfaces)
namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
    
    public interface ISaleRepository
    {
        Task<bool> SaveSaleAsync(Sale sale);
    }
}