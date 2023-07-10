namespace Transport_X.Entities
{
    public class Ward
    {
        public int WardCode { get; set; }
        public string? WardName { get; set;}

        public int DistrictId { get; set; }

        public District District { get; set; }
        public List<PostOffice> PostOffices { get; set; }
        public List<Order> Orders { get; set; }

    }
}
