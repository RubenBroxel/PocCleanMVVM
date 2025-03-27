// GetWarehouseItemsUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCore.Warehouse
{
    /// <summary>
    /// Caso de uso para obtener todos los elementos del almacén.
    /// </summary>
    public class GetWarehouseItemsUseCase
    {
        private readonly IWarehouseRepository _repository;

        /// <summary>
        /// Constructor de la clase GetWarehouseItemsUseCase.
        /// </summary>
        /// <param name="repository">Repositorio de elementos del almacén.</param>
        public GetWarehouseItemsUseCase(IWarehouseRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para obtener todos los elementos del almacén.
        /// </summary>
        /// <returns>Una colección enumerable de elementos del almacén.</returns>
        public async Task<IEnumerable<WarehouseItem>> Execute() => await _repository.GetAllAsync();
    }
}