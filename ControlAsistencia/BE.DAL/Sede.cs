using BE.DAL.DO.Interfaces;
using BE.DAL.EF;
using BE.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;


namespace BE.DAL
{
    public class Sede : ICRUD<data.Sede>
    {
        private Repository<data.Sede> repo;
        public Sede(NDbContext dbContext)
        {
            repo = new Repository<data.Sede>(dbContext);
        }
        public void Delete(data.Sede t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Sede> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Sede>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Sede GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Sede> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Sede t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Sede t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
