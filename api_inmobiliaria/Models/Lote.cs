namespace api_immobiliaria.Models
{
    public class Lote
    {
        public int Id { get; set; }
        public string NumeroLote { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; } = true;
    }
}