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
    public class Sede : ICRUD<data.Sede>
    {
        private dal.Sede _dal;
        public Sede(NDbContext dbContext)
        {
            _dal = new dal.Sede(dbContext);
        }
        public void Delete(data.Sede t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Sede> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Sede>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Sede GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Sede> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Sede t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Sede t)
        {
            _dal.Update(t);
        }
    }
}
