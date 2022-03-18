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

        public IEnumerable<data.BitacotaSesion> getAll()
        {
            return _dal.getAll();
        }

        public Task<IEnumerable<data.BitacotaSesion>> getAllAsync()
        {
            return _dal.getAllAsync();
        }
        public IEnumerable<data.BitacotaSesion> getAllBy(int id)
        {
            throw new NotImplementedException();
        }
        public data.BitacotaSesion getOneById(int id)
        {
            return _dal.getOneById(id);
        }

        public Task<data.BitacotaSesion> getOneByIdAsync(int id)
        {
            return _dal.getOneByIdAsync(id);
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
