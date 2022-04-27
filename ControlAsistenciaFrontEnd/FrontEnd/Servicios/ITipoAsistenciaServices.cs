using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
    public interface ITipoAsistenciaServices
    {
        void Insert(TipoAsistencia t);
        void Update(TipoAsistencia t);
        void Delete(TipoAsistencia t);
        IEnumerable<TipoAsistencia> GetAll();
        TipoAsistencia GetOneById(int id);
        Task<IEnumerable<TipoAsistencia>> GetAllAsync();
        Task<TipoAsistencia> GetOneByIdAsync(int id);
    }
}
