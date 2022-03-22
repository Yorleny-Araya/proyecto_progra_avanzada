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
    public class BitacotaSesion : ICRUD<data.BitacotaSesion>
    {
        private dal.BitacotaSesion _dal;
        public BitacotaSesion(NDbContext dbContext)
        {
            _dal = new dal.BitacotaSesion(dbContext);
        }
        public void Delete(data.BitacotaSesion t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.BitacotaSesion> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.BitacotaSesion>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }
    
        public data.BitacotaSesion GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.BitacotaSesion> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.BitacotaSesion t)
        {
            _dal.Insert(t);
        }

        public void Update(data.BitacotaSesion t)
        {
            _dal.Update(t);
        }
    }
}