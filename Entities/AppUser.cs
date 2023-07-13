using Microsoft.AspNetCore.Identity;

namespace Transport_X.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
