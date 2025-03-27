// PurchaseOrder.cs (Domain Layer)
namespace Domain.Entities
{
    /// <summary>
    /// Representa una orden de compra en el dominio de la aplicación.
    /// </summary>
    public class PurchaseOrder
    {
        /// <summary>
        /// Identificador único de la orden de compra.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Proveedor asociado a la orden de compra.
        /// </summary>
        public string? Supplier { get; set; }

        /// <summary>
        /// Monto total de la orden de compra.
        /// </summary>
        public decimal TotalAmount { get; set; }
    }
}