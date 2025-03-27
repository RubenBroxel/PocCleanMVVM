using Domain.Entities;
using Domain.Interfaces;

// Application Layer (Use Cases)
namespace AppCore.Sales
{
    /// <summary>
    /// Caso de uso para obtener la lista de productos disponibles.
    /// </summary>
    public class GetProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Constructor de la clase GetProductsUseCase.
        /// </summary>
        /// <param name="productRepository">Repositorio de productos.</param>
        public GetProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para obtener la lista de productos.
        /// </summary>
        /// <returns>Una colección enumerable de productos.</returns>
        public async Task<IEnumerable<Product>> ExecuteAsync()
        {
            return await _productRepository.GetProductsAsync();
        }
    }
}
