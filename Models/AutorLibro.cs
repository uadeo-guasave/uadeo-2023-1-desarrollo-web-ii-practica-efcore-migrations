using System.ComponentModel.DataAnnotations.Schema;

namespace MyEfTools.Models;

class AutorLibro
{
    public int AutorId { get; set; }
    public int LibroId { get; set; }

    // propiedades exclusivas para uso de EFCore
    [NotMapped]
    public Autor Autor { get; set; }

    [NotMapped]
    public Libro Libro { get; set; }
}