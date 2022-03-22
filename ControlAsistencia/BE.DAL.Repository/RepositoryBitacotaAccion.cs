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
    public class RepositoryBitacotaAccion : Repository<data.BitacotaAccion>, IRepositoryBitacotaAccion
    {
        public RepositoryBitacotaAccion(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<BitacotaAccion>> GetAllAsync()
        {
            return await _db.BitacotaAccion.Include(n => n.IdEmpleado).ToListAsync();
        }

        public async Task<BitacotaAccion> GetOneByIdAsync(int id)
        {
            return await _db.BitacotaAccion.Include(n => n.IdEmpleado).SingleOrDefaultAsync(n => n.IdBitacotaAccion == id);
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