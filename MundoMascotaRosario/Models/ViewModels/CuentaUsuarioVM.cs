using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models.ViewModels
{
    public class CuentaUsuarioVM
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}