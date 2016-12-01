using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MundoMascotaRosario.Models
{
    public class Perfil
    {
        [Key, Column(Order = 0)]
        [Required]
        public int RolId { get; set; }
        [Key, Column(Order = 1)]
        [Required]
        public int PermisoId { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Permiso  Permiso{ get; set; }
    }
}