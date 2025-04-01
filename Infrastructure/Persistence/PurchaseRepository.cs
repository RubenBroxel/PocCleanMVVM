// PurchaseRepository.cs (Infrastructure Layer)
using Domain.Entities;
using Domain.Interfaces;


namespace Infrastructure.Persistence
{
    /// <summary>
    /// Repositorio para gestionar las operaciones relacionadas con órdenes de compra.
    /// Implementa la interfaz IPurchaseRepository.
    /// </summary>
    public class PurchaseRepository : IPurchaseRepository
    {
        /// <summary>
        /// Lista en memoria para almacenar las órdenes de compra.
        /// </summary>
        private readonly List<PurchaseOrder> _orders = new();

        /// <summary>
        /// Obtiene todas las órdenes de compra almacenadas de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de órdenes de compra.</returns>
        public async Task<IEnumerable<PurchaseOrder>> GetAllAsync() => await Task.FromResult(_orders);

        /// <summary>
        /// Agrega una nueva orden de compra al repositorio de forma asíncrona.
        /// </summary>
        /// <param name="order">La orden de compra a agregar.</param>
        public async Task AddAsync(PurchaseOrder order)
        {
            _orders.Add(order);
            await Task.CompletedTask;
        }
    }
}