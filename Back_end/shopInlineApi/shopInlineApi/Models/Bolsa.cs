using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Bolsa
    {
        public int BolsaId { get; set; }
        public string BolsaDesc { get; set; }
        public int SubDepartamentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual SubDepartament SubDepartament { get; set; }
    }
}
