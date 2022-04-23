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
    public class RepositoryAutenticacion : Repository<data.Autenticacion>, IRepositoryAutenticacion
    {
        public RepositoryAutenticacion(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Autenticacion>> GetAllAsync()
        {
            return await _db.Autenticacion.Include(n => n.IdEmpleadoNavigation).Include(m => m.IdRolNavigation).ToListAsync();
        }

        public async Task<Autenticacion> GetOneByIdAsync(int id)
        {
            return await _db.Autenticacion.Include(n => n.IdEmpleadoNavigation).Include(m => m.IdRolNavigation).SingleOrDefaultAsync(n => n.IdAutenticacion == id);
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
