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
    public class Autenticacion : ICRUD<data.Autenticacion>
    {
        private RepositoryAutenticacion repo;
        public Autenticacion(NDbContext dbContext)
        {
            repo = new RepositoryAutenticacion(dbContext);
        }
        public void Delete(data.Autenticacion t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Autenticacion> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Autenticacion>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.Autenticacion GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Autenticacion> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.Autenticacion t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Autenticacion t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
