using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
    public interface IBitacotaSesionServices
    {
        void Insert(BitacotaSesion t);
        void Update(BitacotaSesion t);
        void Delete(BitacotaSesion t);
        IEnumerable<BitacotaSesion> GetAll();
        BitacotaSesion GetOneById(int id);
        Task<IEnumerable<BitacotaSesion>> GetAllAsync();
        Task<BitacotaSesion> GetOneByIdAsync(int id);
    }
}
