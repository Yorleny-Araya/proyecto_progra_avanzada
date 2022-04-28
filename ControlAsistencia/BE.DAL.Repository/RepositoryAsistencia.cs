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
    public class RepositoryAsistencia : Repository<data.Asistencia>, IRepositoryAsistencia
    {
        public RepositoryAsistencia(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Asistencia>> GetAllAsync()
        {
            return await _db.Asistencia.Include(n => n.IdTipoAsistenciaNavigation).Include(n => n.IdEmpleadoNavigation).ToListAsync();
        }

        public async Task<Asistencia> GetOneByIdAsync(int id)
        {
            return await _db.Asistencia.Include(n => n.IdTipoAsistenciaNavigation).Include(n => n.IdEmpleadoNavigation).SingleOrDefaultAsync(n => n.IdAsistencia == id);
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
