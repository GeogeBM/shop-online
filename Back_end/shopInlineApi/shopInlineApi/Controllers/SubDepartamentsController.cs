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
  public class SubDepartamentsController : ControllerBase
  {
    private readonly Shop_OnlineContext _context;

    public SubDepartamentsController(Shop_OnlineContext context)
    {
      _context = context;
    }

    // GET: api/SubDepartaments
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubDepartament>>> GetSubDepartaments()
    {
      return await _context.SubDepartaments.ToListAsync();
    }

    // GET: api/SubDepartaments/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SubDepartament>> GetSubDepartament(int id)
    {
      var subDepartament = await _context.SubDepartaments.FindAsync(id);

      if (subDepartament == null)
      {
        return NotFound();
      }

      return subDepartament;
    }

    // PUT: api/SubDepartaments/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSubDepartament(int id, SubDepartament subDepartament)
    {
      if (id != subDepartament.SubDepartamentId)
      {
        return BadRequest();
      }

      _context.Entry(subDepartament).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!SubDepartamentExists(id))
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

    // POST: api/SubDepartaments
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<SubDepartament>> PostSubDepartament(SubDepartament subDepartament)
    {
      _context.SubDepartaments.Add(subDepartament);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetSubDepartament", new { id = subDepartament.SubDepartamentId }, subDepartament);
    }

    // DELETE: api/SubDepartaments/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubDepartament(int id)
    {
      var subDepartament = await _context.SubDepartaments.FindAsync(id);
      if (subDepartament == null)
      {
        return NotFound();
      }

      _context.SubDepartaments.Remove(subDepartament);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool SubDepartamentExists(int id)
    {
      return _context.SubDepartaments.Any(e => e.SubDepartamentId == id);
    }
  }
}
