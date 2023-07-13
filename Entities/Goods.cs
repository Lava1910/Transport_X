namespace Transport_X.Entities
{
    public class Goods
    {

        public int Id { get; set; }
        public string? GoodsName { get; set; }
        public decimal Price { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
