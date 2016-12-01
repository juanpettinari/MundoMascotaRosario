using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class LineaDeProducto
    {
        [Key]
        public int LineaDeProductoId { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int ProductoId { get; set; }
        [DataType(DataType.Currency)]
        public decimal? SubtotalDecimal { get; set; }

        public int CarritoDeCompraId { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual CarritoDeCompra CarritoDeCompra { get; set; }
    }
}