using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        [Required]
        public string NroDocumento { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public int RolId { get; set; }

        public Rol Rol { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }

    }
}