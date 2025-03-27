namespace Domain.Entities
{
    /// <summary>
    /// Representa una venta en el dominio de la aplicación.
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// Identificador único de la venta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha en la que se realizó la venta.
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Lista de detalles asociados a la venta.
        /// </summary>
        public List<SaleDetail> Details { get; set; } = new();
    }
}