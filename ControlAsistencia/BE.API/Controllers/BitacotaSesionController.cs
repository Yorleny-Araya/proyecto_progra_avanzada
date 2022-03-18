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
    public class BitacotaSesionController : Controller
    {
        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public BitacotaSesionController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/BitacotaSesion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.BitacotaSesion>>> GetBitacotaSesion()
        {
            var res = await new BE.BS.BitacotaSesion(_context).getAllAsync();
            List<models.BitacotaSesion> mapaAux = _mapper.Map<IEnumerable<data.BitacotaSesion>, IEnumerable<models.BitacotaSesion>>(res).ToList();
            return mapaAux;
        }

        // GET: api/BitacotaSesion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.BitacotaSesion>> GetBitacotaSesion(int id)
        {
            var BitacotaSesion = await new BE.BS.BitacotaSesion(_context).getOneByIdAsync(id);

            if (BitacotaSesion == null)
            {
                return NotFound();
            }
            models.BitacotaSesion mapaAux = _mapper.Map<data.BitacotaSesion, models.BitacotaSesion>(BitacotaSesion);

            return mapaAux;
        }

        // PUT: api/BitacotaSesion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBitacotaSesion(int id, models.BitacotaSesion BitacotaSesion)
        {
            if (id != BitacotaSesion.IdBitacotaSesion)
            {
                return BadRequest();
            }

            try
            {
                data.BitacotaSesion mapaAux = _mapper.Map<models.BitacotaSesion, data.BitacotaSesion>(BitacotaSesion);

                new BE.BS.BitacotaSesion(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!BitacotaSesionExists(id))
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

        // POST: api/BitacotaSesion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.BitacotaSesion>> PostBitacotaSesion(models.BitacotaSesion BitacotaSesion)
        {
            try
            {
                data.BitacotaSesion mapaAux = _mapper.Map<models.BitacotaSesion, data.BitacotaSesion>(BitacotaSesion);
                new BE.BS.BitacotaSesion(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetBitacotaSesion", new { id = BitacotaSesion.IdBitacotaSesion }, BitacotaSesion);
        }

        // DELETE: api/BitacotaSesion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.BitacotaSesion>> DeleteBitacotaSesion(int id)
        {
            var BitacotaSesion = await new BE.BS.BitacotaSesion(_context).getOneByIdAsync(id);
            if (BitacotaSesion == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.BitacotaSesion(_context).Delete(BitacotaSesion);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.BitacotaSesion mapaAux = _mapper.Map<data.BitacotaSesion, models.BitacotaSesion>(BitacotaSesion);

            return mapaAux;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        private bool BitacotaSesionExists(int id)
        {
            return (new BE.BS.BitacotaSesion(_context).getOneById(id) != null);
        }
    }
}
