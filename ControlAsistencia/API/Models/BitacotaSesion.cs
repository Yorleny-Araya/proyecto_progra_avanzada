using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class BitacotaSesion
    {
        public int IdBitacotaSesion { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
