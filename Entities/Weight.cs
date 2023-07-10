namespace Transport_X.Entities
{
    public class Weight
    {
        public string WeightName { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
