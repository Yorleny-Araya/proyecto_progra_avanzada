using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FrontEnd.Models
{
    public partial class Ausencia
    {
        public int IdAusencia { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int CantDias { get; set; }
        public string Motivo { get; set; }
        public int IdTipoAusencia { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual TipoAusencia IdTipoAusenciaNavigation { get; set; }
    }
}
