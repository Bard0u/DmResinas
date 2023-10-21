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

        #region Popular Usuario - Usuários
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@cozastore.com",
                NormalizedEmail = "ADMIN@COZASTORE.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "José Antonio Gallo Junior",
                DataNascimento = DateTime.Parse("05/08/1981"),
                Foto = "/images/usuarios/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
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