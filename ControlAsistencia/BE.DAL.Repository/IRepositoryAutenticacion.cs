using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryAutenticacion : IRepository<data.Autenticacion>
    {
        Task<IEnumerable<data.Autenticacion>> GetAllAsync();
        Task<data.Autenticacion> GetOneByIdAsync(int id);
    }
}
