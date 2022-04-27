using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Servicios
{
    public interface IEmpleadoServices
    {
        void Insert(Empleado t);
        void Update(Empleado t);
        void Delete(Empleado t);
        IEnumerable<Empleado> GetAll();
        Empleado GetOneById(int id);
        Task<IEnumerable<Empleado>> GetAllAsync();
        Task<Empleado> GetOneByIdAsync(int id);
    }
}
