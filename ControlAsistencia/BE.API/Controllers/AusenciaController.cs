using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AusenciaController : Controller
    {
        private readonly NDbContext _context;

        public AusenciaController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Ausencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ausencia>>> GetAusencia()
        {
            return new BS.Ausencia(_context).GetAll().ToList();
        }



        // GET: api/Ausencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ausencia>> GetAusencia(int id)
        {
            var autenticacion = new BE.BS.Ausencia(_context).GetOneById(id);

            if (autenticacion == null)
            {
                return NotFound();
            }

            return autenticacion;
        }

        // PUT: api/Ausencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAusencia(int id, Ausencia Ausencia)
        {
            if (id != Ausencia.IdAusencia)
            {
                return BadRequest();
            }

            try
            {
                new BE.BS.Ausencia(_context).Update(Ausencia);
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
        public async Task<ActionResult<Ausencia>> PostAusencia(Ausencia Ausencia)
        {
            try
            {
                new BE.BS.Ausencia(_context).Insert(Ausencia);
            }
            catch (Exception)
            {
                BadRequest();
            }
            
            return CreatedAtAction("GetAusencia", new { id = Ausencia.IdAusencia }, Ausencia);
        }

        // DELETE: api/Ausencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ausencia>> DeleteAusencia(int id)
        {
            var Ausencia = new BE.BS.Ausencia(_context).GetOneById(id);
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

            return Ausencia;
        }

        private bool AusenciaExists(int id)
        {
            return (new BE.BS.Ausencia(_context).GetOneById(id) != null);
        }
    }
}
