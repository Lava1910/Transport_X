using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Transport_X.Entities;
using Transport_X.Interfaces;
using Transport_X.Services;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            //policy.WithOrigins("https://24h.com.vn");
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
