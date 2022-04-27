using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
   public interface IAusenciaServices
    {
        void Insert(Ausencia t);
        void Update(Ausencia t);
        void Delete(Ausencia t);
        IEnumerable<Ausencia> GetAll();
        Ausencia GetOneById(int id);
        Task<IEnumerable<Ausencia>> GetAllAsync();
        Task<Ausencia> GetOneByIdAsync(int id);
    }
}
