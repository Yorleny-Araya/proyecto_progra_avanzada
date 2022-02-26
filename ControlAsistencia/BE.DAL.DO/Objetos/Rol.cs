using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.DAL.DO.Objetos
{
    public partial class Rol
    {
        public Rol()
        {
            Autenticacion = new HashSet<Autenticacion>();
        }

        public int IdRol { get; set; }
        public string Rol1 { get; set; }

        public virtual ICollection<Autenticacion> Autenticacion { get; set; }
    }
}
