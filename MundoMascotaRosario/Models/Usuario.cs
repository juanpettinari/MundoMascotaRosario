using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Usuario
    {
        public Usuario()
        {
            UsuarioId = Guid.NewGuid().ToString();
        }
        [Key]
        public string UsuarioId { get; set; }
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
        public string Telefono { get; set; }
        [Required]
        public TipoDeDocumento TipoDeDocumento { get; set; }
        [Required]
        public string NroDocumento { get; set; }
        [Required]
        public bool Estado { get; set; }

        public virtual ICollection<OrdenDeCompra> OrdenesDeCompra { get; set; }

    }

    public enum TipoDeDocumento
    {
       Dni = 1,
       Le = 2,
       Lc = 3,
       Ce = 4
    }
}