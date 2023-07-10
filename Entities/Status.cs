namespace Transport_X.Entities
{
    public class Status
    {
        public string StatusName { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; }
    }
}
