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
    public class TipoAusencia : ICRUD<data.TipoAusencia>
    {
        private Repository<data.TipoAusencia> repo;
        public TipoAusencia(NDbContext dbContext)
        {
            repo = new Repository<data.TipoAusencia>(dbContext);
        }
        public void Delete(data.TipoAusencia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.TipoAusencia> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.TipoAusencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.TipoAusencia GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.TipoAusencia> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.TipoAusencia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.TipoAusencia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
