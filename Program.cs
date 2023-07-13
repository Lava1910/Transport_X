using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Transport_X.Entities;
using Transport_X.Interfaces;
using Transport_X.Services;
using System.IO;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);
// add Cors
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyMethod();
            policy.AllowAnyHeader();
        }
        );
}
);


// Add services to the container.
builder.Services.AddDbContext<Transport_X.EF.TransportXDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("TransportX"))
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Add Transient - Declaire DI
//builder.Services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
//builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
//builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<IOrderService, OrderService>();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

