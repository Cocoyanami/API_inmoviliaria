namespace api_immobiliaria.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> Authenticate(string username, string password);
    }
}