using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopInlineApi.Models;

namespace shopInlineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RopasController : ControllerBase
    {
        private readonly Shop_OnlineContext _context;

        public RopasController(Shop_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/Ropas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ropa>>> GetRopas()
        {
            return await _context.Ropas.ToListAsync();
        }

        // GET: api/Ropas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ropa>> GetRopa(int id)
        {
            var ropa = await _context.Ropas.FindAsync(id);

            if (ropa == null)
            {
                return NotFound();
            }

            return ropa;
        }

        // PUT: api/Ropas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRopa(int id, Ropa ropa)
        {
            if (id != ropa.RopaId)
            {
                return BadRequest();
            }

            _context.Entry(ropa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RopaExists(id))
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

        // POST: api/Ropas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ropa>> PostRopa(Ropa ropa)
        {
            _context.Ropas.Add(ropa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRopa", new { id = ropa.RopaId }, ropa);
        }

        // DELETE: api/Ropas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRopa(int id)
        {
            var ropa = await _context.Ropas.FindAsync(id);
            if (ropa == null)
            {
                return NotFound();
            }

            _context.Ropas.Remove(ropa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RopaExists(int id)
        {
            return _context.Ropas.Any(e => e.RopaId == id);
        }
    }
}
