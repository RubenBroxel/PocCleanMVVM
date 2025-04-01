// IWarehouseRepository.cs (Domain Layer)
using Domain.Entities;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el repositorio de elementos del almacén.
    /// Define las operaciones relacionadas con los elementos del almacén.
    /// </summary>
    public interface IWarehouseRepository
    {
        /// <summary>
        /// Obtiene todos los elementos del almacén almacenados de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de elementos del almacén.</returns>
        Task<IEnumerable<WarehouseItem>> GetAllAsync();

        /// <summary>
        /// Agrega un nuevo elemento al almacén de forma asíncrona.
        /// </summary>
        /// <param name="item">El elemento del almacén a agregar.</param>
        Task AddAsync(WarehouseItem item);
    }
}