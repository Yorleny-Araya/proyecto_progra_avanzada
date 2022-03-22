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
    public class AsistenciaController : Controller
    {
        private readonly NDbContext _context;

        public AsistenciaController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Asistencia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistencia>>> GetAsistencia()
        {
            return new BS.Asistencia(_context).GetAll().ToList();
        }

        // GET: api/Asistencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asistencia>> GetAsistencia(int id)
        {
            var autenticacion = new BE.BS.Asistencia(_context).GetOneById(id);

            if (autenticacion == null)
            {
                return NotFound();
            }

            return autenticacion;
        }

        // PUT: api/Asistencia/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencia(int id, Asistencia Asistencia)
        {
            if (id != Asistencia.IdAsistencia)
            {
                return BadRequest();
            }

            try
            {
                new BE.BS.Asistencia(_context).Update(Asistencia);
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
        public async Task<ActionResult<Asistencia>> PostAsistencia(Asistencia Asistencia)
        {
            try
            {
                new BE.BS.Asistencia(_context).Insert(Asistencia);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetAsistencia", new { id = Asistencia.IdAsistencia }, Asistencia);
        }

        // DELETE: api/Asistencia/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Asistencia>> DeleteAsistencia(int id)
        {
            var Asistencia = new BE.BS.Asistencia(_context).GetOneById(id);
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

            return Asistencia;
        }

        private bool AsistenciaExists(int id)
        {
            return (new BE.BS.Asistencia(_context).GetOneById(id) != null);
        }
    }
}
