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
    public class TipoAsistencia : ICRUD<data.TipoAsistencia>
    {
        private dal.TipoAsistencia _dal;
        public TipoAsistencia(NDbContext dbContext)
        {
            _dal = new dal.TipoAsistencia(dbContext);
        }
        public void Delete(data.TipoAsistencia t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.TipoAsistencia> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.TipoAsistencia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.TipoAsistencia GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.TipoAsistencia> GetOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.TipoAsistencia t)
        {
            _dal.Insert(t);
        }

        public void Update(data.TipoAsistencia t)
        {
            _dal.Update(t);
        }
    }
}
