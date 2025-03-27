// GetPurchaseOrdersUseCase.cs (AppCore Layer)
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCore.Purchase
{
    /// <summary>
    /// Caso de uso para obtener todas las órdenes de compra.
    /// </summary>
    public class GetPurchaseOrdersUseCase
    {
        private readonly IPurchaseRepository _repository;

        /// <summary>
        /// Constructor de la clase GetPurchaseOrdersUseCase.
        /// </summary>
        /// <param name="repository">Repositorio de órdenes de compra.</param>
        public GetPurchaseOrdersUseCase(IPurchaseRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para obtener todas las órdenes de compra.
        /// </summary>
        /// <returns>Una colección enumerable de órdenes de compra.</returns>
        public async Task<IEnumerable<PurchaseOrder>> Execute() => await _repository.GetAllAsync();
    }
}