
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
    public class RepositoryBitacotaSesion : Repository<data.BitacotaSesion>, IRepositoryBitacotaSesion
    {
        public RepositoryBitacotaSesion(NDbContext _dbContext) : base(_dbContext)
        {

        }
        public async Task<IEnumerable<BitacotaSesion>> GetAllAsync()
        {
            return await _db.BitacotaSesion.Include(n => n.IdEmpleadoNavigation).ToListAsync();
        }

        public async Task<BitacotaSesion> GetOneByIdAsync(int id)
        {
            return await _db.BitacotaSesion.Include(n => n.IdEmpleadoNavigation).SingleOrDefaultAsync(n => n.IdBitacotaSesion == id);
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