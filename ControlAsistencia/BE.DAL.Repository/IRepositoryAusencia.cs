using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryAusencia : IRepository<data.Ausencia>
    {
        Task<IEnumerable<data.Ausencia>> GetAllAsync();
        Task<data.Ausencia> GetOneByIdAsync(int id);
    }
}
