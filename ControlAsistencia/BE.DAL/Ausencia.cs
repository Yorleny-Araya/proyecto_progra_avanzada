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
    public class Ausencia : ICRUD<data.Ausencia>
    {

        private Repository<data.Ausencia> repo;
        public Ausencia(NDbContext dbContext)
        {
            repo = new Repository<data.Ausencia>(dbContext);
        }
        public void Delete(data.Ausencia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Ausencia> GetAll()
        {
            return repo.GetAll();
        }


        public Task<IEnumerable<data.Ausencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Ausencia GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Ausencia> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Ausencia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Ausencia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
