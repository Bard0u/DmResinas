using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DmResinas.Models;

namespace DmResinas.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Roles - Perfis de Usuário

        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Moderador",
                NormalizedName = "MODERADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Usuário",
                NormalizedName = "USUÁRIO"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Popular Clients - Usuários
        List<Clients> users= new(){
            new Clients(){
                Id = Guid.NewGuid().ToString(),
                ClientName="Pedro Luiz",
                ClientAge = 17,
                Email = "pedroarossettoo@gmail.com",
                NormalizedEmail = "PEDROAROSSETTOO@GMAIL.COM",
                UserName = "Bard0u",
                NormalizedUserName= "BARD0U",
                LockoutEnabled = false,
                PhoneNumber = "14997418713",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<Clients> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<Clients>().HasData(users);
        #endregion

        #region Popular UserRole - Usuário com Perfil

            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>(){
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                }
            };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion


    }
}