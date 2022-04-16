using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class AsistenciaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public AsistenciaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Asistencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Asistencia>>> GetAsistencia()
        {
            var res = await new BE.BS.Asistencia(_context).GetAllAsync();
            List<models.Asistencia> mapaAux = _mapper.Map<IEnumerable<data.Asistencia>, IEnumerable<models.Asistencia>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Asistencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Asistencia>> GetAsistencia(int id)
        {
            var Asistencia = await new BE.BS.Asistencia(_context).GetOneByIdAsync(id);

            if (Asistencia == null)
            {
                return NotFound();
            }
            models.Asistencia mapaAux = _mapper.Map<data.Asistencia, models.Asistencia>(Asistencia);

            return mapaAux;
        }

        // PUT: api/Asistencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencia(int id, models.Asistencia Asistencia)
        {
            if (id != Asistencia.IdAsistencia)
            {
                return BadRequest();
            }

            try
            {
                data.Asistencia mapaAux = _mapper.Map<models.Asistencia, data.Asistencia>(Asistencia);

                new BE.BS.Asistencia(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!AsistenciaExists(id))
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

        // POST: api/Ausencia
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Asistencia>> PostAsistencia(models.Asistencia Asistencia)
        {
            try
            {
                data.Asistencia mapaAux = _mapper.Map<models.Asistencia, data.Asistencia>(Asistencia);
                new BE.BS.Asistencia(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetAusencia", new { id = Ausencia.IdAusencia }, Ausencia);
        }

        // DELETE: api/Asistencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Asistencia>> DeleteAsistencia(int id)
        {
            var Asistencia = await new BE.BS.Asistencia(_context).GetOneByIdAsync(id);
            if (Asistencia == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Asistencia(_context).Delete(Asistencia);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Asistencia mapaAux = _mapper.Map<data.Asistencia, models.Asistencia>(Asistencia);

            return mapaAux;
        }

        private bool AsistenciaExists(int id)
        {
            return (new BE.BS.Asistencia(_context).GetOneById(id) != null);
        }
    }
}
