using AutoMapper;
using BE.DAL.DO.Objetos;
using BE.DAL.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitacotaAccionController : ControllerBase
    {

        private readonly NDbContext _context;

        public BitacotaAccionController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/BitacotaAccion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BitacotaAccion>>> GetBitacotaAccion()
        {
            return new BE.BS.BitacotaAccion(_context).GetAll().ToList();
        }



        // GET: api/BitacotaAccion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BitacotaAccion>> GetBitacotaAccion(int id)
        {
            var bitacotaAccion = new BE.BS.BitacotaAccion(_context).GetOneById(id);

            if (bitacotaAccion == null)
            {
                return NotFound();
            }

            return bitacotaAccion;
        }

        // PUT: api/BitacotaAccion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBitacotaAccion(int id, BitacotaAccion BitacotaAccion)
        {
            if (id != BitacotaAccion.IdBitacotaAccion)
            {
                return BadRequest();
            }

            try
            {
                new BE.BS.BitacotaAccion(_context).Update(BitacotaAccion);
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
        public async Task<ActionResult<BitacotaAccion>> PostBitacotaAccion(BitacotaAccion BitacotaAccion)
        {
            try
            {
                new BE.BS.BitacotaAccion(_context).Insert(BitacotaAccion);
            }
            catch (Exception)
            {
                BadRequest();
            }

            return CreatedAtAction("GetBitacotaAccion", new { id = BitacotaAccion.IdBitacotaAccion }, BitacotaAccion);
        }

        // DELETE: api/BitacotaAccion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BitacotaAccion>> DeleteBitacotaAccion(int id)
        {
            var BitacotaAccion = new BE.BS.BitacotaAccion(_context).GetOneById(id);
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

            return BitacotaAccion;
        }

        private bool BiracotaAccionExists(int id)
        {
            return (new BE.BS.BitacotaAccion(_context).GetOneById(id) != null);
        }
    }
}
