using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryBitacotaAccion : IRepository<data.BitacotaAccion>
    {
        Task<IEnumerable<data.BitacotaAccion>> GetAllAsync();
        Task<data.BitacotaAccion> GetOneByIdAsync(int id);
    }
}