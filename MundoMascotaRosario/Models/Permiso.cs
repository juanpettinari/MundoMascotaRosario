using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Permiso
    {
        [Key]
        public int PermisoId { get; set; }
        [DisplayName("Permiso")]
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int PaginaId { get; set; }

        public virtual Pagina Pagina { get; set; }


        public virtual ICollection<Perfil> Perfiles { get; set; }
    }
}