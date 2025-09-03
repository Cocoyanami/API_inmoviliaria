using Microsoft.AspNetCore.Mvc;
using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> GetClientes()
        {
            try
            {
                var clientes = await _clienteService.GetAllClientes();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> CrearCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (string.IsNullOrEmpty(cliente.Nombre))
                    return BadRequest("El nombre es requerido");

                if (string.IsNullOrEmpty(cliente.Email))
                    return BadRequest("El email es requerido");

                var nuevoCliente = await _clienteService.CreateCliente(cliente);
                return CreatedAtAction(nameof(GetClientes), new { id = nuevoCliente.Id }, nuevoCliente);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}