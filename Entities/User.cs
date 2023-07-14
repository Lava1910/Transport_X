using System.ComponentModel.DataAnnotations;

namespace Transport_X.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        public string Role { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
