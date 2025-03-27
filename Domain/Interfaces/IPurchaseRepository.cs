// IPurchaseRepository.cs (Domain Layer)
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz para el repositorio de órdenes de compra.
    /// Define las operaciones relacionadas con las órdenes de compra.
    /// </summary>
    public interface IPurchaseRepository
    {
        /// <summary>
        /// Obtiene todas las órdenes de compra almacenadas de forma asíncrona.
        /// </summary>
        /// <returns>Una colección enumerable de órdenes de compra.</returns>
        Task<IEnumerable<PurchaseOrder>> GetAllAsync();

        /// <summary>
        /// Agrega una nueva orden de compra al repositorio de forma asíncrona.
        /// </summary>
        /// <param name="order">La orden de compra a agregar.</param>
        Task AddAsync(PurchaseOrder order);
    }
}