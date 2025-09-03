using api_immobiliaria.Models;

namespace api_immobiliaria.Services.Interfaces
{
    public interface IClienteService
    {
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente> CreateCliente(Cliente cliente);
        Task<Cliente> GetClienteById(int id);
    }
}