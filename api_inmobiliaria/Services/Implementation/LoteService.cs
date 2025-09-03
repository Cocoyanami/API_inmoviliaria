using api_immobiliaria.Models;
using api_immobiliaria.Services.Interfaces;

namespace api_immobiliaria.Services.Implementations
{
    public class LoteService : ILoteService
    {
        private readonly List<Lote> _lotes = new();
        private int _nextId = 1;

        public async Task<List<Lote>> GetAllLotes()
        {
            return await Task.FromResult(_lotes);
        }

        public async Task AsignarLote(AsignacionLoteRequest asignacion)
        {
            var lote = _lotes.FirstOrDefault(l => l.Id == asignacion.LoteId);
            if (lote != null)
            {
                lote.Disponible = false;
            }

            await Task.CompletedTask;
        }

        public async Task<Lote> CreateLote(Lote lote)
        {
            lote.Id = _nextId++;
            _lotes.Add(lote);
            return await Task.FromResult(lote);
        }
    }
}