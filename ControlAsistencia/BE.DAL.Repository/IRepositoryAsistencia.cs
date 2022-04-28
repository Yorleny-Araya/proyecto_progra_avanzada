using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryAsistencia : IRepository<data.Asistencia>
    {
        Task<IEnumerable<data.Asistencia>> GetAllAsync();
        Task<data.Asistencia> GetOneByIdAsync(int id);
    }
}
