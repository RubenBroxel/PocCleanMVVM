// WarehouseRepository.cs (Infrastructure Layer)
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Persistence
{
    /// <summary>
    /// Repositorio para gestionar las operaciones relacionadas con los elementos del almacén.
    /// Implementa la interfaz IWarehouseRepository.
    /// </summary>
    public class WarehouseRepository : IWarehouseRepository
    {
        /// <summary>
        /// Lista en memoria para almacenar los elementos del almacén.
        /// </summary>
        private readonly List<WarehouseItem> _items = new();

        /// <summary>
        /// Obtiene todos los elementos del almacén almacenados de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de elementos del almacén.</returns>
        public async Task<IEnumerable<WarehouseItem>> GetAllAsync() => await Task.FromResult(_items);

        /// <summary>
        /// Agrega un nuevo elemento al almacén de forma asíncrona.
        /// </summary>
        /// <param name="item">El elemento del almacén a agregar.</param>
        public async Task AddAsync(WarehouseItem item)
        {
            _items.Add(item);
            await Task.CompletedTask;
        }
    }
}