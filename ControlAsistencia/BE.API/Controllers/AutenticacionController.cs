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
    public class AutenticacionController : Controller
    {
        private readonly NDbContext _context;

        public AutenticacionController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/Autenticacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autenticacion>>> GetAutenticacion()
        {
            return new BE.BS.Autenticacion(_context).getAll().ToList();
        }

        // GET: api/Autenticacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Autenticacion>> GetAutenticacion(int id)
        {
            var autenticacion = new BE.BS.Autenticacion(_context).getOneById(id);

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

            try
            {
                new BE.BS.Autenticacion(_context).Update(autenticacion);
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

        // POST: api/Autenticacions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Autenticacion>> PostAutenticacion(Autenticacion autenticacion)
        {
            try
            {
                new BE.BS.Autenticacion(_context).Insert(autenticacion);
            }
            catch (Exception)
            {
                BadRequest();
            }
            
            return CreatedAtAction("GetAutenticacion", new { id = autenticacion.IdAutenticacion }, autenticacion);
        }

        // DELETE: api/Autenticacions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Autenticacion>> DeleteAutenticacion(int id)
        {
            var autenticacion = new BE.BS.Autenticacion(_context).getOneById(id);
            if (autenticacion == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Autenticacion(_context).Delete(autenticacion);
            }
            catch (Exception)
            {

                BadRequest();
            }

            return autenticacion;
        }

        private bool AutenticacionExists(int id)
        {
            return (new BE.BS.Autenticacion(_context).getOneById(id) != null);
        }
    }
}
