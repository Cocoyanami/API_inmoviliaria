using Microsoft.AspNetCore.Mvc;
using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest credentials)
        {
            try
            {
                var token = await _authService.Authenticate(credentials.Username, credentials.Password);

                if (token == null)
                    return Unauthorized("Credenciales inválidas");

                return Ok(new LoginResponse
                {
                    Token = token,
                    Expiration = DateTime.Now.AddHours(8),
                    UserId = "admin"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}