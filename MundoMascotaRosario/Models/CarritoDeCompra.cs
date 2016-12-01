using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class CarritoDeCompra
    {
        [Key]
        public int CarritoDeCompraId { get; set; }

        public virtual ICollection<LineaDeProducto> LineasDeProducto { get; set; }
        
    }
}