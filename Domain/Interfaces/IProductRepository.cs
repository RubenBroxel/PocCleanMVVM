using Domain.Entities;
// Domain Layer (Interfaces)
namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el repositorio de productos.
    /// Define las operaciones relacionadas con los productos.
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Obtiene la lista de productos disponibles de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de productos.</returns>
        Task<IEnumerable<Product>> GetProductsAsync();
    }

    /// <summary>
    /// Interfaz para el repositorio de ventas.
    /// Define las operaciones relacionadas con las ventas.
    /// </summary>
    public interface ISaleRepository
    {
        /// <summary>
        /// Guarda una venta en el sistema de forma asíncrona.
        /// </summary>
        /// <param name="sale">La venta a guardar.</param>
        /// <returns>Un valor booleano indicando si la operación fue exitosa.</returns>
        Task<bool> SaveSaleAsync(Sale sale);
    }
}