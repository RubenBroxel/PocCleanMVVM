namespace Domain.Entities
{
    /// <summary>
    /// Representa un detalle de una venta en el dominio de la aplicación.
    /// </summary>
    public class SaleDetail
    {
        /// <summary>
        /// Identificador único del detalle de la venta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identificador del producto asociado al detalle de la venta.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Cantidad del producto vendida.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Precio total del detalle de la venta (Cantidad * Precio del Producto).
        /// </summary>
        public decimal TotalPrice => Quantity * Product.Price;

        /// <summary>
        /// Producto asociado al detalle de la venta.
        /// </summary>
        public Product Product { get; set; } = new();
    }
}