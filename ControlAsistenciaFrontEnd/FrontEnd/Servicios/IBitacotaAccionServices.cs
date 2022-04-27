using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
    public  interface IBitacotaAccionServices
    {
        void Insert(BitacotaAccion t);
        void Update(BitacotaAccion t);
        void Delete(BitacotaAccion t);
        IEnumerable<BitacotaAccion> GetAll();
        BitacotaAccion GetOneById(int id);
        Task<IEnumerable<BitacotaAccion>> GetAllAsync();
        Task<BitacotaAccion> GetOneByIdAsync(int id);
    }
}
