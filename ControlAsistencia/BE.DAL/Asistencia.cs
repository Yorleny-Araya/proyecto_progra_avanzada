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
    public class Asistencia : ICRUD<data.Asistencia>
    {

        private Repository<data.Asistencia> repo;
        public Asistencia(NDbContext dbContext)
        {
            repo = new Repository<data.Asistencia>(dbContext);
        }
        public void Delete(data.Asistencia t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.Asistencia> getAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Asistencia>> getAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Asistencia getOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Asistencia> getOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Asistencia t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.Asistencia t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}
