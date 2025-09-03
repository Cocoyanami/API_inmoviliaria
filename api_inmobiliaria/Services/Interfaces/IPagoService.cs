using api_immobiliaria.Models;

namespace api_immobiliaria.Services.Interfaces
{
    public interface IPagoService
    {
        Task<PagoResponse> RegistrarPago(PagoRequest pago);
        Task<List<PagoResponse>> GetPagosByClienteId(int clienteId);
    }
}