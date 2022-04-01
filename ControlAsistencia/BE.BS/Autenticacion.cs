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

        public IEnumerable<data.Autenticacion> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Autenticacion>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Autenticacion GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Autenticacion> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
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
