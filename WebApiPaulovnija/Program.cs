using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using WebApiPaulovnija.Extensions;
using WebApiPaulovnija.Mapping;
using WebApiPaulovnija.Service;
using WebApiPaulovnija.Services;

var builder = WebApplication.CreateBuilder(args);

// Dodavanje kontrolera za API
builder.Services.AddControllers();

// Konfiguracija Swagger-a
builder.Services.AddPaulovnijaSwaggerGen();

// Konfiguracija konteksta baze podataka s SQL Serverom
builder.Services.AddDbContext<PaulovnijaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaulovnijaContext"));
});

// Učitavanje tajnog ključa iz appsettings.json
var secretKey = builder.Configuration["Jwt:SecretKey"]; // Učitavanje tajnog ključa

// Dodavanje servisa
builder.Services.AddScoped<IUserService, UserService>(); // Registracija UserService
builder.Services.AddScoped<IRadnikService, RadnikService>();
builder.Services.AddScoped<IRasadnikService, RasadnikService>();
builder.Services.AddScoped<IStrojService, StrojService>();
builder.Services.AddScoped<ISadnicaService, SadnicaService>();
builder.Services.AddScoped<IZadatakService, ZadatakService>();

// Konfiguracija CORS-a
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Dodavanje AutoMapper-a za mapiranje između modela i DTO-a
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Konfiguracija sigurnosti (JWT autentifikacija)
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)), // Korištenje tajnog ključa
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

var app = builder.Build();

// Konfiguracija Swagger UI
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
    options.EnableTryItOutByDefault();
});

// Postavljanje HTTPS preusmjeravanja
app.UseHttpsRedirection();

// Omogućavanje CORS politike
app.UseCors("AllowAllOrigins");

// Omogućavanje autentifikacije i autorizacije
app.UseAuthentication(); // Mora ići prije app.UseAuthorization
app.UseAuthorization();

// Mapa kontrolera
app.MapControllers();

// Omogućavanje statičkih datoteka
app.UseStaticFiles();
app.UseDefaultFiles();

// Postavljanje fallback datoteke za SPA
app.MapFallbackToFile("index.html");

// Pokretanje aplikacije
app.Run();
