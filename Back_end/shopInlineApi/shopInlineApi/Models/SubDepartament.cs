using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class SubDepartament
    {
        public SubDepartament()
        {
            Accesorios = new HashSet<Accesorio>();
            Bolsas = new HashSet<Bolsa>();
            Calzados = new HashSet<Calzado>();
            Productos = new HashSet<Producto>();
            Ropas = new HashSet<Ropa>();
        }

        public int SubDepartamentId { get; set; }
        public string SubDepartamentDesc { get; set; }
        public int? DepartamentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual Departement Departament { get; set; }
        public virtual ICollection<Accesorio> Accesorios { get; set; }
        public virtual ICollection<Bolsa> Bolsas { get; set; }
        public virtual ICollection<Calzado> Calzados { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Ropa> Ropas { get; set; }
    }
}
