namespace Transport_X.Entities
{
    public class Region
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public List<Province>? Provinces { get; set; }
    }
}
