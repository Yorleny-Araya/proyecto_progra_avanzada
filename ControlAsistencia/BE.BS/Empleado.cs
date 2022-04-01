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
    public class Empleado : ICRUD<data.Empleado>
    {
        private dal.Empleado _dal;
        public Empleado(NDbContext dbContext)
        {
            _dal = new dal.Empleado(dbContext);
        }
        public void Delete(data.Empleado t)
        {
            _dal.Delete(t);
        }

        public IEnumerable<data.Empleado> GetAll()
        {
            return _dal.GetAll();
        }

        public Task<IEnumerable<data.Empleado>> GetAllAsync()
        {
            return _dal.GetAllAsync();
        }

        public data.Empleado GetOneById(int id)
        {
            return _dal.GetOneById(id);
        }

        public Task<data.Empleado> GetOneByIdAsync(int id)
        {
            return _dal.GetOneByIdAsync(id);
        }

        public void Insert(data.Empleado t)
        {
            _dal.Insert(t);
        }

        public void Update(data.Empleado t)
        {
            _dal.Update(t);
        }
    }
}
