namespace ZapateriaApp.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }

        public int VentaId { get; set; }

        public Venta? Venta { get; set; }

        // ESTE es el Id que viene de la API
        public int ProductoApiId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}