using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Service
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(LoginDTO loginDto);
        Task<User> GetUserByUsernameAsync(string username);
        string GenerateToken(User user);
        Task<User> RegisterAsync(RegisterDTO registerDto); // Dodana metoda
    }
}
