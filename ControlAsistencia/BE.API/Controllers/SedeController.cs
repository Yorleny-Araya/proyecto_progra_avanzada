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
    public class SedeController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public SedeController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/Sede
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.Sede>>> GetSede()
        {
            // return null;
            // return new BE.BS.Sede(_context).GetAll().ToList();
            var res = new BE.BS.Sede(_context).GetAll();
            List<models.Sede> mapaAux = _mapper.Map<IEnumerable<data.Sede>, IEnumerable<models.Sede>>(res).ToList();
            return mapaAux;
        }

        // GET: api/Sede/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.Sede>> GetSede(int id)
        {
            var Sede = new BE.BS.Sede(_context).GetOneById(id);

            if (Sede == null)
            {
                return NotFound();
            }

            models.Sede mapaAux = _mapper.Map<data.Sede, models.Sede>(Sede);

            return mapaAux;
        }

        // PUT: api/Sede/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSede(int id, models.Sede Sede)
        {
            if (id != Sede.IdSede)
            {
                return BadRequest();
            }

            try
            {
                data.Sede mapaAux = _mapper.Map<models.Sede, data.Sede>(Sede);
                new BE.BS.Sede(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!SedeExists(id))
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

        // POST: api/Sede
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.Sede>> PostSede(models.Sede Sede)
        {
            try
            {
                data.Sede mapaAux = _mapper.Map<models.Sede, data.Sede>(Sede);
                new BE.BS.Sede(_context).Insert(mapaAux);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetSede", new { id = Sede.IdSede }, Sede);
        }

        // DELETE: api/Sede/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.Sede>> DeleteSede(int id)
        {
            var Sede = new BE.BS.Sede(_context).GetOneById(id);
            if (Sede == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.Sede(_context).Delete(Sede);
            }
            catch (Exception)
            {
                BadRequest();
            }

            models.Sede mapaAux = _mapper.Map<data.Sede, models.Sede>(Sede);

            return mapaAux;
        }

        private bool SedeExists(int id)
        {
            return (new BE.BS.Sede(_context).GetOneById(id) != null);
        }
    }
}
