using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class OrdenDeCompra
    {
        public OrdenDeCompra()
        {
            OrdenId = Guid.NewGuid().ToString();
        }

        [Key]
        public string OrdenId { get; set; }

        public string UsuarioId { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaCompra { get; set; }

        public string DireccionDeEnvioId { get; set; }

        public FormaDePago FormaDePago { get; set; }

        public EstadoPago Estado { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalDecimal { get; set; }

        public virtual Direccion Direccion { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Tarjeta Tarjeta { get; set; }

        public virtual ICollection<LineaDeProducto>  LineasDeProducto{ get; set; }
        
    }


    public enum EstadoPago
    {
        Impago = 0,
        Pago = 1
    }

    public enum FormaDePago
    {
        Tarjeta = 1,
        Efectivo
    }

}