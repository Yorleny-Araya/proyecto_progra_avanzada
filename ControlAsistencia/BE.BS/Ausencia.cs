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

        public IEnumerable<data.Ausencia> GetAll()
        {
            return _dal.GetAll();
        }


        public Task<IEnumerable<data.Ausencia>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Ausencia GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Ausencia> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
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
