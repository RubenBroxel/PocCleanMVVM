// Infrastructure Layer (Repositories)
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    /// <summary>
    /// Repositorio para gestionar las operaciones relacionadas con productos.
    /// Implementa la interfaz IProductRepository.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Obtiene la lista de productos disponibles de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de productos.</returns>
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.FromResult(new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200 },
                new Product { Id = 2, Name = "Mouse", Price = 20 }
            });
        }
    }

    /// <summary>
    /// Repositorio para gestionar las operaciones relacionadas con ventas.
    /// Implementa la interfaz ISaleRepository.
    /// </summary>
    public class SaleRepository : ISaleRepository
    {
        /// <summary>
        /// Guarda una venta en el sistema de forma asíncrona.
        /// </summary>
        /// <param name="sale">La venta a guardar.</param>
        /// <returns>Un valor booleano indicando si la operación fue exitosa.</returns>
        public async Task<bool> SaveSaleAsync(Sale sale)
        {
            return await Task.FromResult(true);
        }
    }
}