using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.API.DataModels
{
    public partial class Empleado
    {
        public Empleado()
        {
            Asistencia = new HashSet<Asistencia>();
            Ausencia = new HashSet<Ausencia>();
            Autenticacion = new HashSet<Autenticacion>();
            BitacotaAccion = new HashSet<BitacotaAccion>();
            BitacotaSesion = new HashSet<BitacotaSesion>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int CantVacaciones { get; set; }
        public byte[] Huella { get; set; }
        public int IdSede { get; set; }

        public virtual Sede IdSedeNavigation { get; set; }
        public virtual ICollection<Asistencia> Asistencia { get; set; }
        public virtual ICollection<Ausencia> Ausencia { get; set; }
        public virtual ICollection<Autenticacion> Autenticacion { get; set; }
        public virtual ICollection<BitacotaAccion> BitacotaAccion { get; set; }
        public virtual ICollection<BitacotaSesion> BitacotaSesion { get; set; }
    }
}
