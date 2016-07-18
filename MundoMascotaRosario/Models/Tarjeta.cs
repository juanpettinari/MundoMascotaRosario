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
        public MesExpiracion MesExpiracion { get; set; }
        public AnoExpiracion AnoExpiracion { get; set; }
        public string Titular { get; set; }
        public string CodigoSeguridad { get; set; }
        public EstadoTarjeta Estado { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }
    }

    public enum EstadoTarjeta
    {
        Habilitada,
        Rechazada
    }

    public enum AnoExpiracion : int
    {
        AnoActual = 2016,
        AnoProx1 = 2017,
        AnoProx2 = 2018,
        AnoProx3 = 2019,
        AnoProx4 = 2020,
        AnoProx5 = 2021
    }

    public enum MesExpiracion
    {
        Enero = 1,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Septiembre,
        Octubre,
        Diciembre
            
    }
}