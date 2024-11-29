using JwtApi.Models;
using JwtApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace JwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly AuthService _authService;

        public AuthController(IConfiguration configuration, AuthService authService)
        {
            _configuration = configuration;
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthRequest authRequest)
        {
            // Para fins de exemplo, vamos usar um usuário fixo
            var user = new User { Username = "user1", PasswordHash = "password123", Role = "Admin" };

            if (authRequest.Username == user.Username && authRequest.Password == user.PasswordHash)
            {
                var token = _authService.Authenticate(user);
                return Ok(new { Token = token });
            }

            return Unauthorized("Credenciais inválidas");
        }
    }
}
