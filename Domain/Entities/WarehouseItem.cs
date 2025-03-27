// WarehouseItem.cs (Domain Layer)
namespace Domain.Entities
{
    /// <summary>
    /// Representa un elemento del almacén en el dominio de la aplicación.
    /// </summary>
    public class WarehouseItem
    {
        /// <summary>
        /// Identificador único del elemento del almacén.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del elemento del almacén.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Cantidad disponible del elemento en el almacén.
        /// </summary>
        public int Quantity { get; set; }
    }
}