using Domain.Entities;
using Domain.Interfaces;
// Application Layer (Use Cases)
namespace AppCore.Sales
{
    public class GetProductsUseCase
    {
        private readonly IProductRepository _productRepository;
        
        public GetProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<IEnumerable<Product>> ExecuteAsync()
        {
            return await _productRepository.GetProductsAsync();
        }
    }
}
