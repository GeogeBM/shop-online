using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopInlineApi.Entitys
{
  public class File
  {

    public int Idfile { get; set; }
    public int ProductoId { get; set; }
    public string FileNombre { get; set; }
    public byte[] FileData { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifyDate { get; set; }
    public IFormFile Picture { get; set; }
  }
}
