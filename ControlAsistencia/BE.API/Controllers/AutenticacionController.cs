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
    public class AutenticacionController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public AutenticacionController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Autenticacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Autenticacion>>> GetAutenticacion()
        {
            var res = await new BE.BS.Autenticacion(_context).GetAllAsync();
            List<models.Autenticacion> mapaAux = _mapper.Map<IEnumerable<data.Autenticacion>, IEnumerable<models.Autenticacion>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Autenticacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Autenticacion>> GetAutenticacion(int id)
        {
            var Autenticacion = await new BE.BS.Autenticacion(_context).GetOneByIdAsync(id);

            if (Autenticacion == null)
            {
                return NotFound();
            }
            models.Autenticacion mapaAux = _mapper.Map<data.Autenticacion, models.Autenticacion>(Autenticacion);

            return mapaAux;
        }

        // PUT: api/Autenticacion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutenticacion(int id, models.Autenticacion Autenticacion)
        {
            if (id != Autenticacion.IdAutenticacion)
            {
                return BadRequest();
            }

            try
            {
                data.Autenticacion mapaAux = _mapper.Map<models.Autenticacion, data.Autenticacion>(Autenticacion);

                new BE.BS.Autenticacion(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!AutenticacionExists(id))
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

        // POST: api/Autenticacion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Autenticacion>> PostAutenticacion(models.Autenticacion Autenticacion)
        {
            try
            {
                data.Autenticacion mapaAux = _mapper.Map<models.Autenticacion, data.Autenticacion>(Autenticacion);
                new BE.BS.Autenticacion(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetAutenticacion", new { id = Autenticacion.IdAutenticacion }, Autenticacion);
        }

        // DELETE: api/Autenticacion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Autenticacion>> DeleteAutenticacion(int id)
        {
            var Autenticacion = await new BE.BS.Autenticacion(_context).GetOneByIdAsync(id);
            if (Autenticacion == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Autenticacion(_context).Delete(Autenticacion);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Autenticacion mapaAux = _mapper.Map<data.Autenticacion, models.Autenticacion>(Autenticacion);

            return mapaAux;
        }

        private bool AutenticacionExists(int id)
        {
            return (new BE.BS.Autenticacion(_context).GetOneById(id) != null);
        }
    }
}
