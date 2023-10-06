using Microsoft.EntityFrameworkCore;

namespace MyEfTools.Models;

class SqliteDbContext : DbContext
{
    // definir los dbset que corresponden a las tablas
    // los nombres del dbset son utilizados para nombrar las tablas
    public DbSet<Editorial> Editoriales { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<AutorLibro> AutoresLibros { get; set; }

    // configurar el acceso a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Db/libros.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AutorLibro>(al =>
        {
            // definir la llave primaria compuesta por dos columnas
            al.HasKey(x => new { x.AutorId, x.LibroId });

            // definir la relacion con la tabla autores
            al.HasOne(x => x.Autor)
                .WithMany(y => y.AutoresLibros)
                .HasForeignKey(x => x.AutorId);

            // definir la relacion con la tabla libros
            al.HasOne(x => x.Libro)
                .WithMany(y => y.AutoresLibros)
                .HasForeignKey(x => x.LibroId);
        });

        // definir la relacion entre libros y editoriales
        modelBuilder.Entity<Libro>(libro =>
        {
            libro.HasOne(l => l.Editorial)
                 .WithMany(e => e.Libros)
                 .HasForeignKey(l => l.EditorialId);
        });

        base.OnModelCreating(modelBuilder);
    }
}