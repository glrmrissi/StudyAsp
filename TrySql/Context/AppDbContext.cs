using Microsoft.EntityFrameworkCore;
using TrySql.Model;

namespace TrySql.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Produtos>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Produtos>().HasKey(c => c.ID);
            mb.Entity<Produtos>().Property(c => c.Nome).HasMaxLength(100).IsRequired();
            mb.Entity<Produtos>().Property(c => c.Descricao).HasMaxLength(150);
            mb.Entity<Produtos>().Property(c => c.ImagemUrl).HasMaxLength(200);
            mb.Entity<Produtos>().Property(c => c.Preco).HasPrecision(14, 2);

            mb.Entity<Categoria>().HasKey(c => c.CategoriaId);
            mb.Entity<Categoria>().Property(c => c.CategoriaNome).HasMaxLength(100).IsRequired();
            mb.Entity<Categoria>().Property(c => c.CategoriaDescricao).HasMaxLength(150).IsRequired();

            mb.Entity<Produtos>()
                .HasOne<Categoria>(c => c.Categoria)
                .WithMany(p => p.Produtos)
                .HasForeignKey(c => c.CategoriaId);
        }
    }
}
