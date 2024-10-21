using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;
using WebApiPaulovnija.Service;

namespace WebApiPaulovnija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorizacijaController : ControllerBase
    {
        private readonly IUserService _userService;

        public AutorizacijaController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO registerDto)
        {
            if (registerDto == null || string.IsNullOrWhiteSpace(registerDto.KorisnickoIme) || string.IsNullOrWhiteSpace(registerDto.Lozinka))
            {
                return BadRequest("Korisničko ime i lozinka su obavezni.");
            }

            var user = await _userService.RegisterAsync(registerDto);
            if (user == null)
            {
                return BadRequest("Korisničko ime već postoji.");
            }

            return Ok(new { user.KorisnickoIme });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDto)
        {
            if (loginDto == null || string.IsNullOrWhiteSpace(loginDto.KorisnickoIme) || string.IsNullOrWhiteSpace(loginDto.Lozinka))
            {
                return BadRequest("Korisničko ime i lozinka su obavezni.");
            }

            var user = await _userService.AuthenticateAsync(loginDto);
            if (user == null)
            {
                return Unauthorized("Neispravno korisničko ime ili lozinka.");
            }

            var token = _userService.GenerateToken(user);
            return Ok(new { token });
        }

        
        [HttpGet("user")]
        [Authorize]
        public async Task<IActionResult> GetUser()
        {
            var username = User.Identity.Name;
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                return NotFound("Korisnik nije pronađen.");
            }

            return Ok(new { user.KorisnickoIme });
        }
    }
}
