using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Producto
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
        public decimal ProductoImpuestoPorc { get; set; }
        public int ProductoCantidad { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

    public virtual Departement Departament { get; set; }
    public virtual Marca Marca { get; set; }
    public virtual SubDepartament SubDepartament { get; set; }
  }
}
