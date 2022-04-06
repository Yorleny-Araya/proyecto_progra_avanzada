using AutoMapper;
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
    public class AusenciaController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public AusenciaController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Ausencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Ausencia>>> GetAusencia()
        {

            var res = await new BE.BS.Ausencia(_context).GetAllAsync();
            List<models.Ausencia> mapaAux = _mapper.Map<IEnumerable<data.Ausencia>, IEnumerable<models.Ausencia>>(res).ToList();
            return mapaAux;
        }



        // GET: api/Ausencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Ausencia>> GetAusencia(int id)
        {
            var Ausencia = await new BE.BS.Ausencia(_context).GetOneByIdAsync(id);

            if (Ausencia == null)
            {
                return NotFound();
            }
            models.Ausencia mapaAux = _mapper.Map<data.Ausencia, models.Ausencia>(Ausencia);

            return mapaAux;
        }

        // PUT: api/Ausencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAusencia(int id, models.Ausencia Ausencia)
        {
            if (id != Ausencia.IdAusencia)
            {
                return BadRequest();
            }

            try
            {
                data.Ausencia mapaAux = _mapper.Map<models.Ausencia, data.Ausencia>(Ausencia);

                new BE.BS.Ausencia(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!AusenciaExists(id))
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
        public async Task<ActionResult<models.Ausencia>> PostAusencia(models.Ausencia Ausencia)
        {
            try
            {
                data.Ausencia mapaAux = _mapper.Map<models.Ausencia, data.Ausencia>(Ausencia);
                new BE.BS.Ausencia(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetAusencia", new { id = Ausencia.IdAusencia }, Ausencia);
        }

        // DELETE: api/Ausencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Ausencia>> DeleteAusencia(int id)
        {
            var Ausencia = await new BE.BS.Ausencia(_context).GetOneByIdAsync(id);
            if (Ausencia == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Ausencia(_context).Delete(Ausencia);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Ausencia mapaAux = _mapper.Map<data.Ausencia, models.Ausencia>(Ausencia);

            return mapaAux;
        }

        private bool AusenciaExists(int id)
        {
            return (new BE.BS.Ausencia(_context).GetOneById(id) != null);
        }
    }
}
