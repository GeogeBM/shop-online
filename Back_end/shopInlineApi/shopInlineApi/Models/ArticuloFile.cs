using System;
using System.Collections.Generic;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class ArticuloFile
    {
        public int Idfile { get; set; }
        public int ProductoId { get; set; }
        public string FileNombre { get; set; }
        public string FileData { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
