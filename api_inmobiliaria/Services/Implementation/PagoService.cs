using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Services.Implementations
{
    public class PagoService : IPagoService
    {
        private readonly List<PagoResponse> _pagos = new();
        private int _nextId = 1;

        public async Task<PagoResponse> RegistrarPago(PagoRequest pago)
        {
            var pagoResponse = new PagoResponse
            {
                Id = _nextId++,
                ClienteId = pago.ClienteId,
                Monto = pago.Monto,
                FechaPago = pago.FechaPago,
                MetodoPago = pago.MetodoPago,
                Referencia = pago.Referencia
            };

            _pagos.Add(pagoResponse);
            return await Task.FromResult(pagoResponse);
        }

        public async Task<List<PagoResponse>> GetPagosByClienteId(int clienteId)
        {
            return await Task.FromResult(_pagos.Where(p => p.ClienteId == clienteId).ToList());
        }
    }
}