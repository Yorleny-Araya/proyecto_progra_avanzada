using System;
using System.Collections.Generic;
using System.Text;
using data = BE.DAL.DO.Objetos;
using BE.DAL.DO.Interfaces;
using System.Threading.Tasks;
using BE.DAL.Repository;
using BE.DAL.EF;

namespace BE.DAL
{
    public class BitacotaAccion : ICRUD<data.BitacotaAccion>
    {
        private RepositoryBitacotaAccion repo;
        public BitacotaAccion(NDbContext dbContext)
        {
            repo = new RepositoryBitacotaAccion(dbContext);
        }
        public void Delete(data.BitacotaAccion t)
        {
            repo.Delete(t);
            repo.Commit();
        }

        public IEnumerable<data.BitacotaAccion> GetAll()
        {
            return repo.GetAll();
        }

        public Task<IEnumerable<data.BitacotaAccion>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public data.BitacotaAccion GetOneById(int id)
        {
            return repo.GetOnebyID(id);
        }

        public Task<data.BitacotaAccion> GetOneByIdAsync(int id)
        {
            return repo.GetOneByIdAsync(id);
        }

        public void Insert(data.BitacotaAccion t)
        {
            repo.Insert(t);
            repo.Commit();
        }

        public void Update(data.BitacotaAccion t)
        {
            repo.Update(t);
            repo.Commit();
        }
    }
}