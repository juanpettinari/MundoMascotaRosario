using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Direccion
    {
        public Direccion()
        {
            DireccionId = Guid.NewGuid().ToString();
        }
        [Key]
        public string DireccionId { get; set; }
        
        public string CiudadId { get; set; }

        public string Calle { get; set; }

        public int Nro { get; set; }

        public string CodigoPostal { get; set; }

        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }
    }

    public class Ciudad
    {
        public Ciudad()
        {
            CiudadId = Guid.NewGuid().ToString();
        }

        public string CiudadId { get; set; }

        public string Descripcion { get; set; }

        public string ProvinciaId { get; set; }

        public virtual Provincia Provincia{ get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }

    }

    public class Provincia
    {

        public Provincia()
        {
            ProvinciaId = Guid.NewGuid().ToString();
        }

        public string ProvinciaId { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Ciudad> Ciudades { get; set; }
        
    }




}



