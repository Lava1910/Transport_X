namespace Transport_X.Entities
{
    public class PostOffice
    {
        public int? PostOfficeId { get; set; }
        public string? PostOfficeAddress { get; set; }
        public int? WardId { get; set; }
        public Ward? Ward { get; set; }
    }
}
