using api_immobiliaria.Models;

namespace api_immobiliaria.Services.Interfaces
{
    public interface ILoteService
    {
        Task<List<Lote>> GetAllLotes();
        Task AsignarLote(AsignacionLoteRequest asignacion);
        Task<Lote> CreateLote(Lote lote);
    }
}