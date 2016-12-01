using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models.ViewModels
{
    public class RegistrationVM
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
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.Vuelva a escribirlas")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        public int RolId { get; set; }
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
    }
}