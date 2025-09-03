using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Services.Implementations
{
    public class AuthService : IAuthService
    {
        public async Task<string> Authenticate(string username, string password)
        {
            // Simulación simple - en producción usarías una base de datos
            if (username == "admin" && password == "password")
            {
                return await Task.FromResult("fake-jwt-token-" + Guid.NewGuid());
            }

            return null;
        }
    }
}