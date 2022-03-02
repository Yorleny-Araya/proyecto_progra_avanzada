using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AusenciaController : ControllerBase
    {
        private readonly control_AsistenciaContext _context;

        public AusenciaController(control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: api/Ausencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ausencia>>> GetAusencia()
        {
            return await _context.Ausencia.ToListAsync();
        }

        // GET: api/Ausencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ausencia>> GetAusencia(int id)
        {
            var ausencia = await _context.Ausencia.FindAsync(id);

            if (ausencia == null)
            {
                return NotFound();
            }

            return ausencia;
        }

        // PUT: api/Ausencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAusencia(int id, Ausencia ausencia)
        {
            if (id != ausencia.IdAusencia)
            {
                return BadRequest();
            }

            _context.Entry(ausencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
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
        public async Task<ActionResult<Ausencia>> PostAusencia(Ausencia ausencia)
        {
            _context.Ausencia.Add(ausencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAusencia", new { id = ausencia.IdAusencia }, ausencia);
        }

        // DELETE: api/Ausencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ausencia>> DeleteAusencia(int id)
        {
            var ausencia = await _context.Ausencia.FindAsync(id);
            if (ausencia == null)
            {
                return NotFound();
            }

            _context.Ausencia.Remove(ausencia);
            await _context.SaveChangesAsync();

            return ausencia;
        }

        private bool AusenciaExists(int id)
        {
            return _context.Ausencia.Any(e => e.IdAusencia == id);
        }
    }
}
