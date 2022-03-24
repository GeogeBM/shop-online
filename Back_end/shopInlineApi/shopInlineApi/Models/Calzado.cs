using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Calzado
    {
        public int CalzadoId { get; set; }
        public string CalzadoDesc { get; set; }
        public int SubDepartamentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual SubDepartament SubDepartament { get; set; }
    }
}
