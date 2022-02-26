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
    public class AutenticacionsController : ControllerBase
    {
        private readonly control_AsistenciaContext _context;

        public AutenticacionsController(control_AsistenciaContext context)
        {
            _context = context;
        }

        // GET: api/Autenticacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autenticacion>>> GetAutenticacion()
        {
            return await _context.Autenticacion.ToListAsync();
        }

        // GET: api/Autenticacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autenticacion>> GetAutenticacion(int id)
        {
            var autenticacion = await _context.Autenticacion.FindAsync(id);

            if (autenticacion == null)
            {
                return NotFound();
            }

            return autenticacion;
        }

        // PUT: api/Autenticacions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAutenticacion(int id, Autenticacion autenticacion)
        {
            if (id != autenticacion.IdAutenticacion)
            {
                return BadRequest();
            }

            _context.Entry(autenticacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
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

        // POST: api/Autenticacions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Autenticacion>> PostAutenticacion(Autenticacion autenticacion)
        {
            _context.Autenticacion.Add(autenticacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAutenticacion", new { id = autenticacion.IdAutenticacion }, autenticacion);
        }

        // DELETE: api/Autenticacions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Autenticacion>> DeleteAutenticacion(int id)
        {
            var autenticacion = await _context.Autenticacion.FindAsync(id);
            if (autenticacion == null)
            {
                return NotFound();
            }

            _context.Autenticacion.Remove(autenticacion);
            await _context.SaveChangesAsync();

            return autenticacion;
        }

        private bool AutenticacionExists(int id)
        {
            return _context.Autenticacion.Any(e => e.IdAutenticacion == id);
        }
    }
}
