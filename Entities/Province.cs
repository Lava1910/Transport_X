

namespace Transport_X.Entities
{
    public class Province
    {
        public int? ProvinceId { get; set; }
        public string? ProvinceName { get; set; }
        public int? RegionId { get; set; }
        public Region? Region { get; set; }
        public List<District>? Districts { get; set; }
    }
}
