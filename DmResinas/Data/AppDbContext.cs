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
    public DbSet<Categories> Categorie { get; set; }
    public DbSet<Colors> Color { get; set; }
    public DbSet<Images> Image { get; set; }

    public DbSet<Products> Product { get; set; }

    public DbSet<Sizes> Size { get; set; }

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
        
    }
}