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
    public class BitacotaSesion : ICRUD<data.BitacotaSesion>
    {
        private RepositoryBitacotaSesion repo;
        public BitacotaSesion(NDbContext dbContext)
        {
            repo = new RepositoryBitacotaSesion(dbContext);
        }
        public void Delete(data.BitacotaSesion t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.BitacotaSesion> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.BitacotaSesion>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }


        public data.BitacotaSesion GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.BitacotaSesion> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.BitacotaSesion t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.BitacotaSesion t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}