using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        
        public int CiudadId { get; set; }

        public string Calle { get; set; }

        public int Nro { get; set; }

        public string CodigoPostal { get; set; }

        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }
    }

    public class Ciudad
    {
        [Key]
        public int CiudadId { get; set; }

        public string Descripcion { get; set; }

        public int ProvinciaId { get; set; }

        public virtual Provincia Provincia{ get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }

    }

    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Ciudad> Ciudades { get; set; }
        
    }




}



