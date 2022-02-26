using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int IdSede { get; set; }
        public string Sede1 { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
