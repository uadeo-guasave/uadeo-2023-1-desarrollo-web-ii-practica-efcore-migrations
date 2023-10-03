using System.ComponentModel.DataAnnotations;

namespace MyEfTools.Models;

class Autor
{
    public int Id { get; set; }
    [Required, MaxLength(50)] public string Nombres { get; set; }
    [Required, MaxLength(100)] public string Apellidos { get; set; }
}