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

        public IEnumerable<data.Autenticacion> getAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.Autenticacion>> getAllAsync()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<data.BitacotaSesion> getAllBy(int id)
        {
            throw new NotImplementedException();
        }
        public data.Autenticacion getOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.Autenticacion> getOneByIdAsync(int id)
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

        IEnumerable<data.Autenticacion> ICRUD<data.Autenticacion>.getAllBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
