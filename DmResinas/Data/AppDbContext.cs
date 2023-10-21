using DmResinas.Data;
using DmResinas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DmResinas.Data;

public class AppDbContext : IdentityDbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Clients> Client { get; set; }
    public DbSet<Colors> Color { get; set; }
    public DbSet<Categories> Categorie { get; set; }
    public DbSet<Products> Product { get; set; }

    public DbSet<Sizes> Size { get; set; }

    public DbSet<Images> Image { get; set; }
    public DbSet<ProductCategories> ProductCategorie { get; set; }
    public DbSet<ProductColors> ProductColor { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

        #region personalização do Identity
        builder.Entity<IdentityUser>(b =>
        {
            b.ToTable("Users");
        });
        builder.Entity<IdentityUserClaim<string>>(b =>
        {
            b.ToTable("UserClaims");
        });
        builder.Entity<IdentityUserLogin<string>>(b =>
        {
            b.ToTable("UserLogins");
        });
        builder.Entity<IdentityUserToken<string>>(b =>
        {
            b.ToTable("UserTokens");
        });
        builder.Entity<IdentityRole>(b =>
        {
            b.ToTable("Roles");
        });
        builder.Entity<IdentityRoleClaim<string>>(b =>
        {
            b.ToTable("RolesClaims");
        });
        builder.Entity<IdentityUserRole<string>>(b =>
        {
            b.ToTable("UserRoles");
        });
        #endregion


        #region Many to Many - ProductCategories
        builder.Entity<ProductCategories>().HasKey(
            pc => new { pc.ProdId, pc.CategorieId }
        );

        builder.Entity<ProductCategories>()
        .HasOne(pc => pc.Products)
        .WithMany(ca => ca.Categories)
        .HasForeignKey(pc => pc.ProdId);

        builder.Entity<ProductCategories>()
        .HasOne(pc => pc.Categories)
        .WithMany(pr => pr .Products)
        .HasForeignKey(pc => pc.CategorieId);

        #endregion

        #region Many to Many - ProductColors
        
        builder.Entity<ProductColors>().HasKey(
            ps => new { ps.ProdId, ps.ColorId }
        );

        builder.Entity<ProductColors>()
            .HasOne(ps=> ps.Products)
            .WithMany(c=> c.Colors)
            .HasForeignKey(ps => ps.ProdId);

        builder.Entity<ProductColors>()
        .HasOne(ps => ps.Colors)
        .WithMany(pr =>pr .Products)
        .HasForeignKey(ps => ps.ColorId);

        #endregion

        #region Many to Many - ProductImages
        builder.Entity<ProductImages>().HasKey(
            pc => new { pc.ProdId, pc.ImageId }
        );

        builder.Entity<ProductImages>()
        .HasOne(pc => pc.Products)
        .WithMany(im => im.Images)
        .HasForeignKey(pc => pc.ProdId);

        builder.Entity<ProductImages>()
        .HasOne(pc => pc.Images)
        .WithMany(im => im.Products)
        .HasForeignKey(pc => pc.ImageId);

        #endregion


        
    }
}