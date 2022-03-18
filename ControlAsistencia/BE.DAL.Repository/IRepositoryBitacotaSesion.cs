using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryBitacotaSesion : IRepository<data.BitacotaSesion>
    {
        Task<IEnumerable<data.BitacotaSesion>> GetAllAsync();
        Task<data.BitacotaSesion> GetOneByIdAsync(int id);
    }
}
