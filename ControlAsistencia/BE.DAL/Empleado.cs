using System;
using System.Collections.Generic;
using System.Text;
using data = BE.DAL.DO.Objetos;
using BE.DAL.EF;
using BE.DAL.Repository;
using BE.DAL.DO.Interfaces;
using System.Threading.Tasks;

namespace BE.DAL
{
    public class Empleado : ICRUD<data.Empleado>
    {
        private RepositoryEmpleado repo;
        public Empleado(NDbContext dbContext)
        {
            repo = new RepositoryEmpleado(dbContext);
        }
        public void Delete(data.Empleado t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Empleado> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Empleado>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Empleado GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Empleado> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Empleado t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Empleado t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
