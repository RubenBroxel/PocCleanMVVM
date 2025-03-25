namespace Domain.Entities
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * Product.Price;
        public Product Product { get; set; } = new();
    }
}