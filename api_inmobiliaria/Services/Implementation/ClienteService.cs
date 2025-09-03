using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly List<Cliente> _clientes = new();
        private int _nextId = 1;

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await Task.FromResult(_clientes);
        }

        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            cliente.Id = _nextId++;
            _clientes.Add(cliente);
            return await Task.FromResult(cliente);
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await Task.FromResult(_clientes.FirstOrDefault(c => c.Id == id));
        }
    }
}