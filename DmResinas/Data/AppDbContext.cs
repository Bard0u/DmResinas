using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DmResinas.Models;

namespace DmResinas.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cor> Cores { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Tamanho> Tamanhos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<ProdutoAvaliacao> ProdutoAvaliacaos { get; set; }
    public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; }
    public DbSet<ProdutoFoto> ProdutoFotos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

        #region Chave Primaria Composta - ProdutoFoto
        builder.Entity<ProdutoFoto>().HasKey(
            pf => new { pf.Id, pf.ProdutoId }
        );
        #endregion

        #region Relacionamento Muitos para Muitos - ProdutoAvaliacao

        builder.Entity<ProdutoAvaliacao>().HasKey(
            pa => new { pa.ProdutoId, pa.UsuarioId }
        );

        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Produto)
            .WithMany(P => P.Avaliacoes)
            .HasForeignKey(pa => pa.ProdutoId);

        builder.Entity<ProdutoAvaliacao>()
            .HasOne(pa => pa.Usuario)
            .WithMany(u => u.Avaliacoes)
            .HasForeignKey(pa => pa.UsuarioId);
        #endregion

        #region Relacionamento Muitos para Muitos - ProdutoCategoria

        builder.Entity<ProdutoCategoria>().HasKey(
            pc => new { pc.ProdutoId, pc.CategoriaId }
        );

        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Produto)
            .WithMany(c => c.Categorias)
            .HasForeignKey(pc => pc.ProdutoId);
        builder.Entity<ProdutoCategoria>()
            .HasOne(pc => pc.Categoria)
            .WithMany(c => c.Produtos)
            .HasForeignKey(pc => pc.CategoriaId);
        #endregion

    }
}
