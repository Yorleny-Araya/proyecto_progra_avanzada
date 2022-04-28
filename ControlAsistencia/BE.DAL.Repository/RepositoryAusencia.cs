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
    public class RepositoryAusencia : Repository<data.Ausencia>, IRepositoryAusencia
    {
        public RepositoryAusencia(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<Ausencia>> GetAllAsync()
        {
            return await _db.Ausencia.Include(n => n.IdTipoAusenciaNavigation).Include(n => n.IdEmpleadoNavigation).ToListAsync();
        }

        public async Task<Ausencia> GetOneByIdAsync(int id)
        {
            return await _db.Ausencia.Include(n => n.IdTipoAusenciaNavigation).Include(n => n.IdEmpleadoNavigation).SingleOrDefaultAsync(n => n.IdAusencia == id);
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
