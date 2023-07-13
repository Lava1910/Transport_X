using Microsoft.AspNetCore.Identity;

namespace Transport_X.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string? Description { get; set; }
    }
}
