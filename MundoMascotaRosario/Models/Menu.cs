using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MundoMascotaRosario.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        public string Url { get; set; }
        [Required]
        public string TextoMenu { get; set; }

        public int? PadreId { get; set; }

        public virtual ICollection<RolMenu> RolesMenus { get; set; }
    }
}