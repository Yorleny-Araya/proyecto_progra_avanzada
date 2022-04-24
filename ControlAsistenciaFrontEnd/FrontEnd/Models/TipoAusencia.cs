using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FE.Wizzard.Models
{
    public partial class TipoAusencia
    {
        public TipoAusencia()
        {
            Ausencia = new HashSet<Ausencia>();
        }

        public int IdTipoAusencia { get; set; }
        public string TipoAusencia1 { get; set; }

        public virtual ICollection<Ausencia> Ausencia { get; set; }
    }
}
