namespace Transport_X.Entities
{
    public class Insurance
    {
        public int Id { get; set; }
        public string? InsuranceName { get; set; }
        public decimal Price { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
