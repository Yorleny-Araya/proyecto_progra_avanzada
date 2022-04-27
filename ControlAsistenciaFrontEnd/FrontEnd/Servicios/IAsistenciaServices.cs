using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Servicios
{
   public interface IAsistenciaServices
    {
        void Insert( Asistencia t);
        void Update(Asistencia t);
        void Delete(Asistencia t);
        IEnumerable<Asistencia> GetAll();
        Asistencia GetOneById(int id);
        Task<IEnumerable<Asistencia>> GetAllAsync();
        Task<Asistencia> GetOneByIdAsync(int id);
    }
}
