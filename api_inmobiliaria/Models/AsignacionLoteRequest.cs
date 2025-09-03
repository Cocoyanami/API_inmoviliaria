namespace api_immobiliaria.Models
{
    public class AsignacionLoteRequest
    {
        public int ClienteId { get; set; }
        public int LoteId { get; set; }
        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
    }
}