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
  public class BolsasController : ControllerBase
  {
    private readonly Shop_OnlineContext _context;

    public BolsasController(Shop_OnlineContext context)
    {
      _context = context;
    }

    // GET: api/Bolsas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bolsa>>> GetBolsas()
    {
      return await _context.Bolsas.ToListAsync();
    }

    // GET: api/Bolsas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Bolsa>> GetBolsa(int id)
    {
      var bolsa = await _context.Bolsas.FindAsync(id);

      if (bolsa == null)
      {
        return NotFound();
      }

      return bolsa;
    }

    // PUT: api/Bolsas/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutBolsa(int id, Bolsa bolsa)
    {
      if (id != bolsa.BolsaId)
      {
        return BadRequest();
      }

      _context.Entry(bolsa).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BolsaExists(id))
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

    // POST: api/Bolsas
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Bolsa>> PostBolsa(Bolsa bolsa)
    {
      _context.Bolsas.Add(bolsa);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetBolsa", new { id = bolsa.BolsaId }, bolsa);
    }

    // DELETE: api/Bolsas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBolsa(int id)
    {
      var bolsa = await _context.Bolsas.FindAsync(id);
      if (bolsa == null)
      {
        return NotFound();
      }

      _context.Bolsas.Remove(bolsa);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool BolsaExists(int id)
    {
      return  _context.Bolsas.Any(e => e.BolsaId == id);
    }
  }
}
