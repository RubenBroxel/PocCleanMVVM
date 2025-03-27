// Domain Layer (Entities)
namespace Domain.Entities
{
    /// <summary>
    /// Representa un producto en el dominio de la aplicación.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Identificador único del producto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del producto.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Precio del producto.
        /// </summary>
        public decimal Price { get; set; }
    }
}