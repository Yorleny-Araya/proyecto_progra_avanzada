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
    public class TipoAsistencia : ICRUD<data.TipoAsistencia>
    {
        private Repository<data.TipoAsistencia> repo;
        public TipoAsistencia(NDbContext dbContext)
        {
            repo = new Repository<data.TipoAsistencia>(dbContext);
        }
        public void Delete(data.TipoAsistencia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.TipoAsistencia> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.TipoAsistencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.TipoAsistencia GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.TipoAsistencia> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.TipoAsistencia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.TipoAsistencia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
