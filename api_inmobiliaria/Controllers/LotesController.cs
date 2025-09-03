using Microsoft.AspNetCore.Mvc;
using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LotesController : ControllerBase
    {
        private readonly ILoteService _loteService;

        public LotesController(ILoteService loteService)
        {
            _loteService = loteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Lote>>> GetLotes()
        {
            try
            {
                var lotes = await _loteService.GetAllLotes();
                return Ok(lotes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("asignar")]
        public async Task<IActionResult> AsignarLote([FromBody] AsignacionLoteRequest asignacion)
        {
            try
            {
                await _loteService.AsignarLote(asignacion);
                return Ok(new { message = "Lote asignado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}