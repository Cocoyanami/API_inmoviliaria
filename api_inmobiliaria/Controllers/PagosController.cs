using Microsoft.AspNetCore.Mvc;
using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PagosController : ControllerBase
    {
        private readonly IPagoService _pagoService;

        public PagosController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }

        [HttpPost]
        public async Task<ActionResult<PagoResponse>> RegistrarPago([FromBody] PagoRequest pago)
        {
            try
            {
                if (pago.Monto <= 0)
                    return BadRequest("El monto debe ser mayor a cero");

                var pagoRegistrado = await _pagoService.RegistrarPago(pago);
                return Ok(pagoRegistrado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("cliente/{clienteId}")]
        public async Task<ActionResult<List<PagoResponse>>> ObtenerPagosPorCliente(int clienteId)
        {
            try
            {
                var pagos = await _pagoService.GetPagosByClienteId(clienteId);
                return Ok(pagos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}