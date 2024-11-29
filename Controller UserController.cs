using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Este endpoint só pode ser acessado por usuários autenticados
        [Authorize]
        [HttpGet("profile")]
        public IActionResult GetUserProfile()
        {
            var username = User.Identity.Name;
            return Ok(new { Message = $"Olá {username}, bem-vindo ao seu perfil!" });
        }
    }
}
