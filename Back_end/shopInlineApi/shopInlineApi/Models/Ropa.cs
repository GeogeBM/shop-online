using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Ropa
    {
        public int RopaId { get; set; }
        public string RopaDesc { get; set; }
        public int SubDepartamentId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual SubDepartament SubDepartament { get; set; }
    }
}
