using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public interface IRepositoryEmpleado : IRepository<data.Empleado>
    {
        Task<IEnumerable<data.Empleado>> GetAllAsync();
        Task<data.Empleado> GetOneByIdAsync(int id);
    }
}
