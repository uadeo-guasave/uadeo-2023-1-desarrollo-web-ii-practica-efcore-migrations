using Microsoft.EntityFrameworkCore;

namespace MyEfTools.Models;

class SqliteDbContext : DbContext
{
    // definir los dbset que corresponden a las tablas
    // los nombres del dbset son utilizados para nombrar las tablas
    public DbSet<Editorial> Editoriales { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Libro> Libros { get; set; }

    // configurar el acceso a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Db/libros.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // definir la relacion entre libros y editoriales
        modelBuilder.Entity<Libro>(libro => {
            libro.HasOne(l => l.Editorial)
                 .WithMany(e => e.Libros)
                 .HasForeignKey(l => l.EditorialId);
        });

        base.OnModelCreating(modelBuilder);
    }
}