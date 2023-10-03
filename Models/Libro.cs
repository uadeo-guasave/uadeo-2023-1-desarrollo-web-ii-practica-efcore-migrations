using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEfTools.Models;

class Libro
{
    public int Id { get; set; }
    [Required, MaxLength(100)] public string Titulo { get; set; }
    [Required] public int Edicion { get; set; }
    [Required] public int EditorialId { get; set; }

    // propiedades para manejo de relaciones desde EFCore
    [NotMapped] public Editorial Editorial { get; set; }
}