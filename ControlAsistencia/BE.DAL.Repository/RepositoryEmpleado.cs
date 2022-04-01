using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;

namespace BE.DAL.Repository
{
    public class RepositoryEmpleado : Repository<data.Empleado>, IRepositoryEmpleado
    {
        public RepositoryEmpleado(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            return await _db.Empleado.Include(n => n.IdSede).ToListAsync();
        }

        public async Task<Empleado> GetOneByIdAsync(int id)
        {
            return await _db.Empleado.Include(n => n.IdSede).SingleOrDefaultAsync(n => n.IdEmpleado == id);
        }

        private NDbContext _db
        {
            get
            {
                return dbContext as NDbContext;
            }
        }
    }
}
