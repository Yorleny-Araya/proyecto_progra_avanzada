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
    public class TipoAusenciaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public TipoAusenciaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/TipoAusencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.TipoAusencia>>> GetTipoAusencia()
        {
            // return null;
            // return new BE.BS.TipoAusencia(_context).GetAll().ToList();
            var res = new BE.BS.TipoAusencia(_context).GetAll();
            List<models.TipoAusencia> mapaAux = _mapper.Map<IEnumerable<data.TipoAusencia>, IEnumerable<models.TipoAusencia>>(res).ToList();
            return mapaAux;
        }

        // GET: api/TipoAusencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.TipoAusencia>> GetTipoAusencia(int id)
        {
            var TipoAusencia = new BE.BS.TipoAusencia(_context).GetOneById(id);

            if (TipoAusencia == null)
            {
                return NotFound();
            }

            models.TipoAusencia mapaAux = _mapper.Map<data.TipoAusencia, models.TipoAusencia>(TipoAusencia);

            return mapaAux;
        }

        // PUT: api/TipoAusencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoAusencia(int id, models.TipoAusencia TipoAusencia)
        {
            if (id != TipoAusencia.IdTipoAusencia)
            {
                return BadRequest();
            }

            try
            {
                data.TipoAusencia mapaAux = _mapper.Map<models.TipoAusencia, data.TipoAusencia>(TipoAusencia);
                new BE.BS.TipoAusencia(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!TipoAusenciaExists(id))
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

        // POST: api/TipoAusencia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.TipoAusencia>> PostTipoAusencia(models.TipoAusencia TipoAusencia)
        {
            try
            {
                data.TipoAusencia mapaAux = _mapper.Map<models.TipoAusencia, data.TipoAusencia>(TipoAusencia);
                new BE.BS.TipoAusencia(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetTipoAusencia", new { id = TipoAusencia.IdTipoAusencia }, TipoAusencia);
        }

        // DELETE: api/TipoAusencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.TipoAusencia>> DeleteTipoAusencia(int id)
        {
            var TipoAusencia = new BE.BS.TipoAusencia(_context).GetOneById(id);
            if (TipoAusencia == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.TipoAusencia(_context).Delete(TipoAusencia);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.TipoAusencia mapaAux = _mapper.Map<data.TipoAusencia, models.TipoAusencia>(TipoAusencia);

            return mapaAux;
        }

        private bool TipoAusenciaExists(int id)
        {
            return (new BE.BS.TipoAusencia(_context).GetOneById(id) != null);
        }
    }
}
