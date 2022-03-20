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
    public class Autenticacion : ICRUD<data.Autenticacion>
    {
        private dal.Autenticacion _dal;
        public Autenticacion(NDbContext dbContext)
        {
            _dal = new dal.Autenticacion(dbContext);
        }
        public void Delete(data.Autenticacion t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Autenticacion> getAll()
        {
            return _dal.getAll();
        }

        public Task<IEnumerable<data.Autenticacion>> getAllAsync()
        {
            throw new NotImplementedException();
        }

        public data.Autenticacion getOneById(int id)
        {
            return _dal.getOneById(id);
        }

        public Task<data.Autenticacion> getOneByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(data.Autenticacion t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Autenticacion t)
        {
            _dal.Update(t);
        }
    }
}
