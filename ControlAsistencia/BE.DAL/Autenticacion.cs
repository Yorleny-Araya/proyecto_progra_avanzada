using BE.DAL.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;
using BE.DAL.Repository;
using BE.DAL.EF;

namespace BE.DAL
{
    public class Autenticacion : ICRUD<data.Autenticacion>
    {
        private Repository<data.Autenticacion> repo;
        public Autenticacion(NDbContext dbContext)
        {
            repo = new Repository<data.Autenticacion>(dbContext);
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
            throw new NotImplementedException();
        }

        public data.Autenticacion GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Autenticacion> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
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
