using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Transport_X.EF;
using Transport_X.Entities;
using Transport_X.Helper.User;
using Transport_X.Requests.User;

namespace Transport_X.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly TransportXDbContext _context;
        private readonly IConfiguration _config;
        public UserController(TransportXDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public IActionResult Register(RegisterRequest request)
        {
            var testUserExist = _context.Users.FirstOrDefault(u => u.Email == request.Email);
            if(testUserExist == null)
            {
                var hashed = BCrypt.Net.BCrypt.HashPassword(request.Password);
                var u = new Entities.User {UserName = request.UserName, Email = request.Email, Password = hashed, Phone = request.Phone, Role = "User" };
                _context.Users.Add(u);
                _context.SaveChanges();
                return Ok(new UserData { UserName = request.UserName, Email = request.Email, Token = GenerateJWT(u), Role = "User" });
            }
            else
            {
                return BadRequest("UserName đã tồn tại");
            }
            
        }

        private string GenerateJWT(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var signatureKey = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role,user.Role)
            };
            var token = new JwtSecurityToken(
                _config["JWT:Issuer"],
                _config["JWT:Audience"],
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: signatureKey
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Login(LoginRequest userLogin)
        {
            var user = _context.Users.Where(u => u.Email.Equals(userLogin.Email))
                .First();
            if (user == null)
                return Unauthorized();
            bool verified = BCrypt.Net.BCrypt.Verify(userLogin.Password, user.Password);
            if (!verified)
                return Unauthorized();

            return Ok(new UserData { UserId = user.UserId, UserName = user.UserName, Email = user.Email, Token = GenerateJWT(user), Role = user.Role });
        }

    }
}
