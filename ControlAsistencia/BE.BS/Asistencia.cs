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
    public class Asistencia : ICRUD<data.Asistencia>
    {
        private dal.Asistencia _dal;
        public Asistencia(NDbContext dbContext)
        {
            _dal = new dal.Asistencia(dbContext);
        }
        public void Delete(data.Asistencia t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Asistencia> getAll()
        {
            return _dal.getAll();
        }

        public Task<IEnumerable<data.Asistencia>> getAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<data.Asistencia> getAllBy(int id)
        {
            throw new NotImplementedException();
        }

        public data.Asistencia getOneById(int id)
        {
            return _dal.getOneById(id);
        }

        public Task<data.Asistencia> getOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Asistencia t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Asistencia t)
        {
            _dal.Update(t);
        }
    }
}
