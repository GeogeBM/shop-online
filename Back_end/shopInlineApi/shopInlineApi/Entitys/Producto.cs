using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopInlineApi.Entitys
{
  public class ProductoEntity
  {
    public int ProductoId { get; set; }
    public int DepartamentId { get; set; }
    public int SubDepartamentId { get; set; }
    public string ProductoNombre { get; set; }
    public string ProductoDesc { get; set; }
    public int MarcaId { get; set; }
    public decimal PrecioCompra { get; set; }
    public decimal PrecioBrutoVenta { get; set; }
    public decimal PrecioNetoVenta { get; set; }
    public decimal ProductoImpuesto { get; set; }
    public int ProductoCantidad { get; set; }
    public string ArchivoImagen { get; set; }
  }
}
