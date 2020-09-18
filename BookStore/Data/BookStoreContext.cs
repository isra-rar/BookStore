using LivrariaProject.Models;
using Microsoft.EntityFrameworkCore;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }


    public DbSet<Livro> Livro { get; set; }
    public DbSet<Autor> Autor { get; set; }
    public DbSet<Marca> Marca { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>().Property(l => l.Preco).HasColumnType("decimal(5,2)");
        base.OnModelCreating(modelBuilder);
    }
}

