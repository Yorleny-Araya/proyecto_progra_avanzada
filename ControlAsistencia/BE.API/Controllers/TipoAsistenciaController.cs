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
    public class TipoAsistenciaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public TipoAsistenciaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/TipoAsistencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.TipoAsistencia>>> GetTipoAsistencia()
        {
            // return null;
            // return new BE.BS.TipoAsistencia(_context).GetAll().ToList();
            var res = new BE.BS.TipoAsistencia(_context).GetAll();
            List<models.TipoAsistencia> mapaAux = _mapper.Map<IEnumerable<data.TipoAsistencia>, IEnumerable<models.TipoAsistencia>>(res).ToList();
            return mapaAux;
        }

        // GET: api/TipoAsistencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.TipoAsistencia>> GetTipoAsistencia(int id)
        {
            var TipoAsistencia = new BE.BS.TipoAsistencia(_context).GetOneById(id);

            if (TipoAsistencia == null)
            {
                return NotFound();
            }

            models.TipoAsistencia mapaAux = _mapper.Map<data.TipoAsistencia, models.TipoAsistencia>(TipoAsistencia);

            return mapaAux;
        }

        // PUT: api/TipoAsistencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoAsistencia(int id, models.TipoAsistencia TipoAsistencia)
        {
            if (id != TipoAsistencia.IdTipoAsistencia)
            {
                return BadRequest();
            }

            try
            {
                data.TipoAsistencia mapaAux = _mapper.Map<models.TipoAsistencia, data.TipoAsistencia>(TipoAsistencia);
                new BE.BS.TipoAsistencia(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!TipoAsistenciaExists(id))
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

        // POST: api/TipoAsistencia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.TipoAsistencia>> PostTipoAsistencia(models.TipoAsistencia TipoAsistencia)
        {
            try
            {
                data.TipoAsistencia mapaAux = _mapper.Map<models.TipoAsistencia, data.TipoAsistencia>(TipoAsistencia);
                new BE.BS.TipoAsistencia(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetTipoAsistencia", new { id = TipoAsistencia.IdTipoAsistencia }, TipoAsistencia);
        }

        // DELETE: api/TipoAsistencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.TipoAsistencia>> DeleteTipoAsistencia(int id)
        {
            var TipoAsistencia = new BE.BS.TipoAsistencia(_context).GetOneById(id);
            if (TipoAsistencia == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.TipoAsistencia(_context).Delete(TipoAsistencia);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.TipoAsistencia mapaAux = _mapper.Map<data.TipoAsistencia, models.TipoAsistencia>(TipoAsistencia);

            return mapaAux;
        }

        private bool TipoAsistenciaExists(int id)
        {
            return (new BE.BS.TipoAsistencia(_context).GetOneById(id) != null);
        }
    }
}
