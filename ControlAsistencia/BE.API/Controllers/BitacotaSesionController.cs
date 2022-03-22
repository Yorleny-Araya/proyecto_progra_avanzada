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
    public class BitacotaSesionController : Controller
    {
        private readonly NDbContext _context;

        public BitacotaSesionController(NDbContext context)
        {
            _context = context;
        }
        // GET: api/BitacotaSesion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BitacotaSesion>>> GetBitacotaSesion()
        {
            var res = await new BE.BS.BitacotaSesion(_context).getAllAsync();
            return res.ToList();
        }

        // GET: api/BitacotaSesion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BitacotaSesion>> GetBitacotaSesion(int id)
        {
            var BitacotaSesion = await new BE.BS.BitacotaSesion(_context).getOneByIdAsync(id);

            if (BitacotaSesion == null)
            {
                return NotFound();
            }

            return BitacotaSesion;
        }

        // PUT: api/BitacotaSesion/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBitacotaSesion(int id, BitacotaSesion BitacotaSesion)
        {
            if (id != BitacotaSesion.IdBitacotaSesion)
            {
                return BadRequest();
            }

            try
            {
                new BE.BS.BitacotaSesion(_context).Update(BitacotaSesion);
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
        public async Task<ActionResult<BitacotaSesion>> PostBitacotaSesion(BitacotaSesion BitacotaSesion)
        {
            try
            {
                new BE.BS.BitacotaSesion(_context).Insert(BitacotaSesion);
            }
            catch (Exception ee)
            {
                BadRequest();
            }

            return CreatedAtAction("GetBitacotaSesion", new { id = BitacotaSesion.IdBitacotaSesion }, BitacotaSesion);
        }

        // DELETE: api/BitacotaSesion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BitacotaSesion>> DeleteBitacotaSesion(int id)
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

            return BitacotaSesion;
        }

        private bool BitacotaSesionExists(int id)
        {
            return (new BE.BS.BitacotaSesion(_context).getOneById(id) != null);
        }
    }
}