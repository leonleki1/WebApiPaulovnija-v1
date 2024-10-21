using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;
using WebApiPaulovnija.Service;
using Microsoft.Extensions.Configuration; // Dodano za IConfiguration

namespace WebApiPaulovnija.Service
{
    public class UserService : IUserService
    {
        private readonly PaulovnijaContext _context;
        private readonly string _secretKey;

        public UserService(PaulovnijaContext context, IConfiguration configuration) // Promijenjen konstruktor
        {
            _context = context;
            _secretKey = configuration["Jwt:SecretKey"]; // Učitavanje tajnog ključa iz konfiguracije
        }

        public async Task<User> AuthenticateAsync(LoginDTO loginDto)
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.KorisnickoIme == loginDto.KorisnickoIme);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Lozinka, user.LozinkaHash))
            {
                return null;
            }

            return user;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _context.Users
                .SingleOrDefaultAsync(u => u.KorisnickoIme == username);
        }

        public async Task<User> RegisterAsync(RegisterDTO registerDto) // Implementacija
        {
            // Provjerite postoji li već korisnik s tim korisničkim imenom
            var existingUser = await GetUserByUsernameAsync(registerDto.KorisnickoIme);
            if (existingUser != null)
            {
                return null; // Korisnik već postoji
            }

            // Kreirajte novog korisnika
            var user = new User
            {
                KorisnickoIme = registerDto.KorisnickoIme,
                LozinkaHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Lozinka) // Hasiranje lozinke
            };

            // Dodajte korisnika u bazu
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user; // Vratite novog korisnika
        }

        public string GenerateToken(User user)
        {
            var claims = new[]
            {
        new Claim(ClaimTypes.Name, user.KorisnickoIme),
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));  // Koristi tajni ključ
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
