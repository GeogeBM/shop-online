using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Accesorio
    {
        public int AccesorioId { get; set; }
        public string AccesorioDesc { get; set; }
        public int SubDepartamentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual SubDepartament SubDepartament { get; set; }
    }
}
