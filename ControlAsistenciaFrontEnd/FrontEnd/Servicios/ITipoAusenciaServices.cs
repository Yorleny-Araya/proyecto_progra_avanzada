using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
    public interface ITipoAusenciaServices
    {
        void Insert(TipoAusencia t);
        void Update(TipoAusencia t);
        void Delete(TipoAusencia t);
        IEnumerable<TipoAusencia> GetAll();
        TipoAusencia GetOneById(int id);
        Task<IEnumerable<TipoAusencia>> GetAllAsync();
        Task<TipoAusencia> GetOneByIdAsync(int id);
    }
}
