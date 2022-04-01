using AutoMapper;
using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = BE.DAL.DO.Objetos;
using models = BE.API.DataModels;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public RolController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Rol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Rol>>> GetRol()
        {
            // return null;
            // return new BE.BS.Rol(_context).GetAll().ToList();
            var res = new BE.BS.Rol(_context).GetAll();
            List<models.Rol> mapaAux = _mapper.Map<IEnumerable<data.Rol>, IEnumerable<models.Rol>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Rol/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Rol>> GetRol(int id)
        {
            var Rol = new BE.BS.Rol(_context).GetOneById(id);

            if (Rol == null)
            {
                return NotFound();
            }

            models.Rol mapaAux = _mapper.Map<data.Rol, models.Rol>(Rol);

            return mapaAux;
        }

        // PUT: api/Rol/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol(int id, models.Rol Rol)
        {
            if (id != Rol.IdRol)
            {
                return BadRequest();
            }

            try
            {
                data.Rol mapaAux = _mapper.Map<models.Rol, data.Rol>(Rol);
                new BE.BS.Rol(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!RolExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rol
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Rol>> PostRol(models.Rol Rol)
        {
            try
            {
                data.Rol mapaAux = _mapper.Map<models.Rol, data.Rol>(Rol);
                new BE.BS.Rol(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetRol", new { id = Rol.IdRol }, Rol);
        }

        // DELETE: api/Rol/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Rol>> DeleteRol(int id)
        {
            var Rol = new BE.BS.Rol(_context).GetOneById(id);
            if (Rol == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Rol(_context).Delete(Rol);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.Rol mapaAux = _mapper.Map<data.Rol, models.Rol>(Rol);

            return mapaAux;
        }

        private bool RolExists(int id)
        {
            return (new BE.BS.Rol(_context).GetOneById(id) != null);
        }
    }
}
