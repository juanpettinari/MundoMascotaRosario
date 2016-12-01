using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Pagina
    {
        [Key]
        public int PaginaId { get; set; }
        [DisplayName("Página")]
        [Required]
        public string Descripcion { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}