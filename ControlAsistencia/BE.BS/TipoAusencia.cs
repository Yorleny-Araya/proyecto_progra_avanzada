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
    public class TipoAusencia : ICRUD<data.TipoAusencia>
    {
        private dal.TipoAusencia _dal;
        public TipoAusencia(NDbContext dbContext)
        {
            _dal = new dal.TipoAusencia(dbContext);
        }
        public void Delete(data.TipoAusencia t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.TipoAusencia> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.TipoAusencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.TipoAusencia GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.TipoAusencia> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.TipoAusencia t)
        {
            _dal.Insert(t);
        }

        public void Update(data.TipoAusencia t)
        {
            _dal.Update(t);
        }
    }
}
