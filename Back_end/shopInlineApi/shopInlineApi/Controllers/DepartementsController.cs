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
    public class DepartementsController : ControllerBase
    {
        private readonly Shop_OnlineContext _context;

        public DepartementsController(Shop_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/Departements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> GetDepartements()
        {
      var departamenst = await _context.Departements.Join(_context.SubDepartaments,
                                              dep => dep.DepartamentId,
                                              sub => sub.Departament.DepartamentId,
                                              (dep, sub) => new { Departament = dep, SubDepartament = sub }).ToListAsync();
      return Ok(departamenst);
        }

        // GET: api/Departements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Departement>> GetDepartement(int id)
        {
            var departement = await _context.Departements.FindAsync(id);

            if (departement == null)
            {
                return NotFound();
            }

            return departement;
        }

        // PUT: api/Departements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartement(int id, Departement departement)
        {
            if (id != departement.DepartamentId)
            {
                return BadRequest();
            }

            _context.Entry(departement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartementExists(id))
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

        // POST: api/Departements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Departement>> PostDepartement(Departement departement)
        {
            _context.Departements.Add(departement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartement", new { id = departement.DepartamentId }, departement);
        }

        // DELETE: api/Departements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartement(int id)
        {
            var departement = await _context.Departements.FindAsync(id);
            if (departement == null)
            {
                return NotFound();
            }

            _context.Departements.Remove(departement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartementExists(int id)
        {
            return _context.Departements.Any(e => e.DepartamentId == id);
        }
    }
}
