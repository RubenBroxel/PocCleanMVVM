// AddWarehouseItemUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Warehouse
{
    /// <summary>
    /// Caso de uso para agregar un nuevo elemento al almacén.
    /// </summary>
    public class AddWarehouseItemUseCase
    {
        private readonly IWarehouseRepository _repository;

        /// <summary>
        /// Constructor de la clase AddWarehouseItemUseCase.
        /// </summary>
        /// <param name="repository">Repositorio de elementos del almacén.</param>
        public AddWarehouseItemUseCase(IWarehouseRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para agregar un nuevo elemento al almacén.
        /// </summary>
        /// <param name="item">El elemento del almacén a agregar.</param>
        /// <returns>Una tarea que representa la operación asíncrona.</returns>
        public async Task Execute(WarehouseItem item) => await _repository.AddAsync(item);
    }
}