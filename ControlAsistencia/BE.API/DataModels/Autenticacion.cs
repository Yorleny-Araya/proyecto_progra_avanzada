using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.API.DataModels
{
    public partial class Autenticacion
    {
        public int IdAutenticacion { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int Estado { get; set; }
        public int IdEmpleado { get; set; }
        public int IdRol { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Rol IdRolNavigation { get; set; }
    }
}
