using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }
        [DisplayName("Rol")]
        [Required]
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

        public virtual ICollection<Perfil> Perfiles { get; set; }

        public virtual ICollection<RolMenu> RolesMenus { get; set; }
    }
}