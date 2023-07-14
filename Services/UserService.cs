//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.IdentityModel.Tokens;
//using MimeKit;
//using MailKit.Net.Smtp;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using Transport_X.EF;
//using Transport_X.Entities;

//using Transport_X.Requests;
//using Transport_X.Requests.User;
//using Transport_X.ViewModel;

//namespace Transport_X.Services
//{
//    public class UserService 
//    {
//        private readonly UserManager<AppUser> _userManager;
//        private readonly SignInManager<AppUser> _signInManager;
//        private readonly RoleManager<AppRole> _roleManager;
//        private readonly IConfiguration _config;
//        private readonly TransportXDbContext _context;
//        private readonly EmailConfiguration _emailConfiguration;
//        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
//            RoleManager<AppRole> roleManager, IConfiguration config, TransportXDbContext context, EmailConfiguration emailConfiguration)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _roleManager = roleManager;
//            _config = config;
//            _context = context;
//            _emailConfiguration = emailConfiguration;
//        }
//        public async Task<string> Authenticate(LoginRequest request)
//        {
//            var user = await _userManager.FindByNameAsync(request.Username);
//            if (user == null)
//            {
//                return null;
//            }
//            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
//            if (!result.Succeeded)
//            {
//                return null;
//            }
//            var role = await _userManager.GetRolesAsync(user);
//            var claims = new[]
//            {
//                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
//                new Claim(ClaimTypes.Name,user.UserName),
//                new Claim(ClaimTypes.Email,user.Email),
//                new Claim(ClaimTypes.Role,role[0])
//            };
//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
//            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
//            var token = new JwtSecurityToken(
//                _config["Tokens:Issuer"],
//                _config["JWT:Audience"],
//                claims,
//                expires: DateTime.Now.AddMinutes(180),
//                signingCredentials: creds
//                );
//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }

//        public async Task<UserViewModel> GetUserById(Guid userId)
//        {
//            var user = await _context.Users
//                .Select(ele => new UserViewModel()
//                {
//                    Id = ele.Id,
//                    FirstName = ele.FirstName,
//                    LastName = ele.LastName,
//                    DoB = ele.Dob,
//                    Email = ele.Email,
//                    Phone = ele.Phone,
//                    Gender = ele.Gender
//                })
//                .FirstOrDefaultAsync(x => x.Id == userId);

//            return user;
//        }

//        public async Task<bool> Register(RegisterRequest request)
//        {
//            var testUserExist = _context.Users.FirstOrDefault(u => u.Email == request.Email);
//            if (testUserExist == null)
//            {
//                var user = new AppUser()
//                {
//                    Email = request.Email,
//                    UserName = request.UserName
//                };
//                var result = await _userManager.CreateAsync(user, request.Password);
//                if (result.Succeeded)
//                {
//                    var userRole = _context.Roles.FirstOrDefault(x => x.Name == "User");
//                    await _userManager.AddToRoleAsync(user, userRole.Name);
//                    return true;
//                }
//            }
//            return false;
//        }

//        public async Task<Guid> Update(UserUpdateRequest request)
//        {
//            var updateUser = await _context.Users.FirstOrDefaultAsync(p => p.Id == request.Id);
//            if (updateUser == null)
//            {
//                return Guid.Empty;
//            }
//            else
//            {
//                updateUser.FirstName = request.FirstName;
//                updateUser.LastName = request.LastName;
//                updateUser.Gender = request.Gender;
//                updateUser.Phone = request.Phone;
//                updateUser.Dob = request.DoB;
//                _context.Entry(updateUser).State = EntityState.Modified;
//                await _context.SaveChangesAsync();
//                return updateUser.Id;
//            }
//        }

//        public async Task<bool> ForgotPassword(ForgotPasswordRequest request)
//        {
//            var user = await _context.Users.Where(u => u.Email == request.Email).FirstOrDefaultAsync();
//            if (user != null)
//            {
//                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
//                var passwordResetLink = string.Format("https://localhost:3000/ResetPassword?token={0}&email={1}", token, request.Email);
//                var emailMessage = new MimeMessage();
//                emailMessage.From.Add(new MailboxAddress(_emailConfiguration.From, string.Empty));
//                //var to = new List<MailboxAddress>();

//                emailMessage.To.Add(new MailboxAddress(request.Email, string.Empty));
//                emailMessage.Subject = "RESET PASSWORD";


//                emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
//                {
//                    Text = string.Format("<a href='https://localhost:3000/ResetPassword?token={0}&email={1}'>Nhấp vào link này để Reset Password</a>",
//                        token, request.Email)
//                };
//                return await Send(emailMessage);
//            }
//            return false;
//        }

//        private async Task<bool> Send(MimeMessage mailMessage)
//        {
//            using (var client = new SmtpClient())
//            {
//                try
//                {
//                    client.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.Port, true);
//                    await client.AuthenticateAsync(_emailConfiguration.Username, _emailConfiguration.Password);
//                    client.AuthenticationMechanisms.Remove("XOAUTH2");
//                    await client.SendAsync(mailMessage);
//                    return true;
//                }
//                catch (Exception ex)
//                {
//                    return false;
//                }
//                finally
//                {
//                    await client.DisconnectAsync(true);
//                    client.Dispose();
//                }

//            }
//        }
//    }
//}
