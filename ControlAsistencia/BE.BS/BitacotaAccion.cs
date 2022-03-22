using System;
using System.Collections.Generic;
using System.Text;
using data = BE.DAL.DO.Objetos;
using dal = BE.DAL;
using BE.DAL.DO.Interfaces;
using System.Threading.Tasks;
using BE.DAL.EF;

namespace BE.BS
{
    public class BitacotaAccion : ICRUD<data.BitacotaAccion>
    {
        private dal.BitacotaAccion _dal;
        public BitacotaAccion(NDbContext dbContext)
        {
            _dal = new dal.BitacotaAccion(dbContext);
        }
        public void Delete(data.BitacotaAccion t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.BitacotaAccion> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.BitacotaAccion>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.BitacotaAccion GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.BitacotaAccion> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.BitacotaAccion t)
        {
            _dal.Insert(t);
        }

        public void Update(data.BitacotaAccion t)
        {
            _dal.Update(t);
        }
    }
}