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
  public class CalzadoController : ControllerBase
  {
    private readonly Shop_OnlineContext _context;

    public CalzadoController(Shop_OnlineContext context)
    {
      _context = context;
    }

    // GET: api/Calzado
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Calzado>>> GetCalzados()
    {
      return await _context.Calzados.ToListAsync();
    }

    // GET: api/Calzado/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Calzado>> GetCalzado(int id)
    {
      var calzado = await _context.Calzados.FindAsync(id);

      if (calzado == null)
      {
        return NotFound();
      }

      return calzado;
    }

    // PUT: api/Calzado/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCalzado(int id, Calzado calzado)
    {
      if (id != calzado.CalzadoId)
      {
        return BadRequest();
      }

      _context.Entry(calzado).State = EntityState.Modified;

      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CalzadoExists(id))
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

    // POST: api/Calzado
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Calzado>> PostCalzado(Calzado calzado)
    {
      _context.Calzados.Add(calzado);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetCalzado", new { id = calzado.CalzadoId }, calzado);
    }

    // DELETE: api/Calzado/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCalzado(int id)
    {
      var calzado = await _context.Calzados.FindAsync(id);
      if (calzado == null)
      {
        return NotFound();
      }

      _context.Calzados.Remove(calzado);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool CalzadoExists(int id)
    {
      return _context.Calzados.Any(e => e.CalzadoId == id);
    }
  }
}
