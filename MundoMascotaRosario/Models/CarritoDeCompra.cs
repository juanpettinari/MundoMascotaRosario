using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class CarritoDeCompra
    {
        public CarritoDeCompra()
        {
            CarritoDeCompraId = Guid.NewGuid().ToString();
        }
        [Key]
        public string CarritoDeCompraId { get; set; }

        public virtual ICollection<LineaDeProducto> LineasDeProducto { get; set; }
        
    }
}