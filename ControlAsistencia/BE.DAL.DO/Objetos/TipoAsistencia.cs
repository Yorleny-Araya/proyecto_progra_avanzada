using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.DAL.DO.Objetos
{
    public partial class TipoAsistencia
    {
        public TipoAsistencia()
        {
            Asistencia = new HashSet<Asistencia>();
        }

        public int IdTipoAsistencia { get; set; }
        public string TipoAsistencia1 { get; set; }

        public virtual ICollection<Asistencia> Asistencia { get; set; }
    }
}
