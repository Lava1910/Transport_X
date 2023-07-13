namespace Transport_X.Entities
{
    public class District
    {
        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }

        public int ProvinceId { get; set; }

        public List<Ward>? Wards { get; set; }
        public Province? Province { get; set; }
    }
}
