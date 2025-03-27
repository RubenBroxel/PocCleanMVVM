using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Purchase
{
    /// <summary>
    /// Caso de uso para agregar una nueva orden de compra.
    /// </summary>
    public class AddPurchaseOrderUseCase
    {
        private readonly IPurchaseRepository _repository;

        /// <summary>
        /// Constructor de la clase AddPurchaseOrderUseCase.
        /// </summary>
        /// <param name="repository">Repositorio de órdenes de compra.</param>
        public AddPurchaseOrderUseCase(IPurchaseRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Ejecuta el caso de uso para agregar una nueva orden de compra.
        /// </summary>
        /// <param name="order">La orden de compra a agregar.</param>
        /// <returns>Una tarea que representa la operación asíncrona.</returns>
        public async Task Execute(PurchaseOrder order) => await _repository.AddAsync(order);
    }
}