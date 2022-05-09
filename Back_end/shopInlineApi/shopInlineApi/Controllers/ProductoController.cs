using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopInlineApi.Entitys;
using shopInlineApi.Models;

namespace shopInlineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly Shop_OnlineContext _context;

        public ProductoController(Shop_OnlineContext context)
        {
            _context = context;
        }

        // GET: api/Productoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
          try
          {
            return await _context.Productos.ToListAsync();
          }
          catch (Exception ex)
          {

            throw ex;
          }
        }

        // GET: api/Productoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        // PUT: api/Productoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.ProductoId)
            {
                return BadRequest();
            }

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
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

        // POST: api/Productoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto([FromBody] ProductoEntity p)
        {

      Producto pro = new Producto();
      pro.DepartamentId = p.DepartamentId;
      pro.SubDepartamentId = p.SubDepartamentId;
      pro.ProductoNombre = p.ProductoNombre;
      pro.ProductoDesc = p.ProductoDesc;
      pro.MarcaId = p.MarcaId;
      pro.PrecioCompra = p.PrecioCompra;
      pro.PrecioBrutoVenta = p.PrecioBrutoVenta;
      pro.PrecioNetoVenta = p.PrecioNetoVenta;
      pro.ProductoImpuesto = p.ProductoImpuesto;
      //pro.ProductoImpuestoPorc = p.pro
      pro.ProductoCantidad = p.ProductoCantidad;
      pro.CreateDate = DateTime.Now;
      pro.ModifyDate = DateTime.Now;
      _context.Productos.Add(pro);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetProducto", new { id = pro.ProductoId }, pro);
      return null;
        }

        // DELETE: api/Productoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.ProductoId == id);
        }
    }
}
