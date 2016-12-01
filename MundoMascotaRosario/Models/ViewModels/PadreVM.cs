using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoMascotaRosario.Models.ViewModels
{
    public class PadreVM
    {
        public int PadreId { get; set; }

        public string TextoMenu { get; set; }

        public virtual ICollection<HijoVM> HijosVm { get; set; }
    }
}