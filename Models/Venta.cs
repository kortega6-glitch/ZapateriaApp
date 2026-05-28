namespace ZapateriaApp.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public decimal Total { get; set; }

        public string Estado { get; set; } = "Completada";

        public List<DetalleVenta>? Detalles { get; set; }
    }
}