namespace Transport_X.Entities
{
    public class Weight
    {
        public int Id { get; set; }
        public string WeightName { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
