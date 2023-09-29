using Microsoft.EntityFrameworkCore;

namespace MyEfTools.Models;

class SqliteDbContext : DbContext
{
    // definir los dbset que corresponden a las tablas
    // los nombres del dbset son utilizados para nombrar las tablas
    public DbSet<Editorial> Editoriales { get; set; }

    // configurar el acceso a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Db/libros.db");
        base.OnConfiguring(optionsBuilder);
    }
}