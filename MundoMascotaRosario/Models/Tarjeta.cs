using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Tarjeta
    {
        public Tarjeta()
        {
            TarjetaId = Guid.NewGuid().ToString();
        }

        [Key]
        public string TarjetaId { get; set; }

        public string TipoDeTarjeta { get; set; }
        public int NumeroTarjeta { get; set; }
        public int MesExpiracion { get; set; }
        public int AnoExpiracion { get; set; }
        public string Titular { get; set; }
        public string CodigoSeguridad { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }
    }
}