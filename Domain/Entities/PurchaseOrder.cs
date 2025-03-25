// PurchaseOrder.cs (Domain Layer)
namespace Domain.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string? Supplier { get; set; }
        public decimal TotalAmount { get; set; }
    }
}