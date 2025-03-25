namespace Domain.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public List<SaleDetail> Details { get; set; } = new();
    }
}