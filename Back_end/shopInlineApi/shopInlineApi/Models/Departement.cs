using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Departement
    {
        public Departement()
        {
            Productos = new HashSet<Producto>();
            SubDepartaments = new HashSet<SubDepartament>();
        }

        public int DepartamentId { get; set; }
        public string DepartamentDescripcion { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<SubDepartament> SubDepartaments { get; set; }
    }
}
