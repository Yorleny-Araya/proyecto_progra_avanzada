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
    public class BitacotaAccionController : ControllerBase
    {

        private readonly NDbContext _context;
        private readonly IMapper _mapper;

        public BitacotaAccionController(NDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: api/BitacotaAccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<models.BitacotaAccion>>> GetBitacotaAccion()
        {
            var res = await new BE.BS.BitacotaAccion(_context).GetAllAsync();
            List<models.BitacotaAccion> mapaAux = _mapper.Map<IEnumerable<data.BitacotaAccion>, IEnumerable<models.BitacotaAccion>>(res).ToList();
            return mapaAux;
        }



        // GET: api/BitacotaAccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<models.BitacotaAccion>> GetBitacotaAccion(int id)
        {
            var BitacotaAccion = await new BE.BS.BitacotaAccion(_context).GetOneByIdAsync(id);

            if (BitacotaAccion == null)
            {
                return NotFound();
            }
            models.BitacotaAccion mapaAux = _mapper.Map<data.BitacotaAccion, models.BitacotaAccion>(BitacotaAccion);

            return mapaAux;
        }

        // PUT: api/BitacotaAccion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBitacotaAccion(int id, models.BitacotaAccion BitacotaAccion)
        {
            if (id != BitacotaAccion.IdBitacotaAccion)
            {
                return BadRequest();
            }

            try
            {
                data.BitacotaAccion mapaAux = _mapper.Map<models.BitacotaAccion, data.BitacotaAccion>(BitacotaAccion);

                new BE.BS.BitacotaAccion(_context).Update(mapaAux);
            }
            catch (Exception ee)
            {
                if (!BiracotaAccionExists(id))
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

        // POST: api/BitacotaAccion
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<models.BitacotaAccion>> PostBitacotaAccion(models.BitacotaAccion BitacotaAccion)
        {
            try
            {
                data.BitacotaAccion mapaAux = _mapper.Map<models.BitacotaAccion, data.BitacotaAccion>(BitacotaAccion);
                new BE.BS.BitacotaAccion(_context).Insert(mapaAux);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetBitacotaAccion", new { id = BitacotaAccion.IdBitacotaAccion }, BitacotaAccion);
        }

        // DELETE: api/BitacotaAccion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<models.BitacotaAccion>> DeleteBitacotaAccion(int id)
        {

            var BitacotaAccion = await new BE.BS.BitacotaAccion(_context).GetOneByIdAsync(id);
            if (BitacotaAccion == null)
            {
                return NotFound();
            }

            try
            {
                new BE.BS.BitacotaAccion(_context).Delete(BitacotaAccion);
            }
            catch (Exception)
            {
                BadRequest();
            }
            models.BitacotaAccion mapaAux = _mapper.Map<data.BitacotaAccion, models.BitacotaAccion>(BitacotaAccion);

            return mapaAux;
        }

        private bool BiracotaAccionExists(int id)
        {
            return (new BE.BS.BitacotaAccion(_context).GetOneById(id) != null);
        }
    }
}
