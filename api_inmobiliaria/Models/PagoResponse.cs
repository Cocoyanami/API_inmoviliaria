namespace api_immobiliaria.Models
{
    public class PagoResponse
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
        public string Referencia { get; set; }
        public string Estado { get; set; } = "Completado";
    }
}