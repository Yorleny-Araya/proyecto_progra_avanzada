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
    public class Ausencia : ICRUD<data.Ausencia>
    {

        private dal.Ausencia _dal;
        public Ausencia(NDbContext dbContext)
        {
            _dal = new dal.Ausencia(dbContext);
        }
        public void Delete(data.Ausencia t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Ausencia> getAll()
        {
            return _dal.getAll();
        }

        public IEnumerable<data.Ausencia> getAllBy(int id)
        {
            return _dal.getAllBy(id);
        }


        public Task<IEnumerable<data.Ausencia>> getAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Ausencia getOneById(int id)
        {
            return _dal.getOneById(id);
        }

        public Task<data.Ausencia> getOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Ausencia t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Ausencia t)
        {
            _dal.Update(t);
        }
    }
}
