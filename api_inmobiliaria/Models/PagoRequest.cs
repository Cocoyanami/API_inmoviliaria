namespace api_immobiliaria.Models
{
    public class PagoRequest
    {
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; } = DateTime.Now;
        public string MetodoPago { get; set; }
        public string Referencia { get; set; }
    }
}