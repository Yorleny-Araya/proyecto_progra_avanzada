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
    public class EmpleadoController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public EmpleadoController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Empleado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Empleado>>> GetEmpleado()
        {
            var res = await new BE.BS.Empleado(_context).GetAllAsync();
            List<models.Empleado> mapaAux = _mapper.Map<IEnumerable<data.Empleado>, IEnumerable<models.Empleado>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Empleado>> GetEmpleado(int id)
        {
            var Empleado = await new BE.BS.Empleado(_context).GetOneByIdAsync(id);

            if (Empleado == null)
            {
                return NotFound();
            }
            models.Empleado mapaAux = _mapper.Map<data.Empleado, models.Empleado>(Empleado);

            return mapaAux;
        }

        // PUT: api/Empleado/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleado(int id, models.Empleado Empleado)
        {
            if (id != Empleado.IdEmpleado)
            {
                return BadRequest();
            }

            try
            {
                data.Empleado mapaAux = _mapper.Map<models.Empleado, data.Empleado>(Empleado);

                new BE.BS.Empleado(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!EmpleadoExists(id))
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

        // POST: api/Empleado
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Empleado>> PostEmpleado(models.Empleado Empleado)
        {
            try
            {
                data.Empleado mapaAux = _mapper.Map<models.Empleado, data.Empleado>(Empleado);
                new BE.BS.Empleado(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetEmpleado", new { id = Empleado.IdEmpleado }, Empleado);
        }

        // DELETE: api/Empleado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Empleado>> DeleteEmpleado(int id)
        {
            var Empleado = await new BE.BS.Empleado(_context).GetOneByIdAsync(id);
            if (Empleado == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Empleado(_context).Delete(Empleado);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.Empleado mapaAux = _mapper.Map<data.Empleado, models.Empleado>(Empleado);

            return mapaAux;
        }

        private bool EmpleadoExists(int id)
        {
            return (new BE.BS.Empleado(_context).GetOneById(id) != null);
        }
    }
}
