using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MundoMascotaRosario.Models.ViewModels
{
    public class MenuVM
    {
        public ICollection<PadreVM> PadresVm { get; set; }
    }
}