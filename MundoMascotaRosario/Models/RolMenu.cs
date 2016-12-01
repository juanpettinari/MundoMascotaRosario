using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MundoMascotaRosario.Models
{
    public class RolMenu
    {
        [Key,Column(Order = 0)]
        [Required]
        public int RolId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int MenuId { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Menu Menu { get; set; }

    }
}