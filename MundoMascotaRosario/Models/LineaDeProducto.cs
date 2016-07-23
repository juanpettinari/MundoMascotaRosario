using System;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class LineaDeProducto
    {
        public LineaDeProducto()
        {
            LineaDeProductoId = Guid.NewGuid().ToString();
        }
        [Key]
        public string LineaDeProductoId { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public string ProductoId { get; set; }
        [DataType(DataType.Currency)]
        public decimal? SubtotalDecimal { get; set; }

        public string CarritoDeCompraId { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual CarritoDeCompra CarritoDeCompra { get; set; }
    }
}