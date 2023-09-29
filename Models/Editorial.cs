using System.ComponentModel.DataAnnotations;

namespace MyEfTools.Models;

class Editorial
{
    // EFCore utiliza la propiedad Id de tipo int como PK
    // una PK por default es Not Null (Required) y Auto incremental
    public int Id { get; set; }
    [Required, MaxLength(100)] public string Nombre { get; set; }
    [EmailAddress] public string CorreoElectronico { get; set; }
    [Url] public string SitioWeb { get; set; }
    [Required, MaxLength(300)] public string Docimilio { get; set; }
}