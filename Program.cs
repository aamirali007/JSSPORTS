using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SportsOrderApp.Core;
using SportsOrderApp.Data;
using SportsOrderApp.Models;
using SportsOrderApp.Repositories;
using SportsOrderApp.Services;
using System.Text;
using static SportsOrderApp.Repositories.IRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register JSDBContext with dependency injection
builder.Services.AddDbContext<JSDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
           .UseLazyLoadingProxies());  // Enable lazy loading proxies


builder.Services.AddControllers();
// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();

builder.Services.AddSingleton(jwtSettings);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret)),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});

// REPOSITORIES LIST
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddRepositoryServices();
// Services List
//builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddServiceLayer();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();
// Use CORS
app.UseCors("AllowAngularApp");
app.UseAuthorization();

app.MapControllers();

app.Run();
