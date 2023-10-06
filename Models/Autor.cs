using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEfTools.Models;

class Autor
{
    public int Id { get; set; }
    [Required, MaxLength(50)] public string Nombres { get; set; }
    [Required, MaxLength(100)] public string Apellidos { get; set; }

    // propiedades exclusivas para uso de EFCore
    [NotMapped]
    public List<AutorLibro> AutoresLibros { get; set; }
}