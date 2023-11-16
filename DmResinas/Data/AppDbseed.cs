using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DmResinas.Models;

namespace DmResinas.Data;
public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Cor
        List<Cor> cores = new() {
            new Cor() {
                Id = 1,
                Nome = "Preto",
                CodigoHexa = "#222"
            },
            new Cor() {
                Id = 2,
                Nome = "Azul",
                CodigoHexa = "#4272d7"
            },
            new Cor() {
                Id = 3,
                Nome = "Cinza",
                CodigoHexa = "#b3b3b3"
            },
            new Cor() {
                Id = 4,
                Nome = "Verde",
                CodigoHexa = "#00ad5f"
            },
            new Cor() {
                Id = 5,
                Nome = "Vermelho",
                CodigoHexa = "#fa4251"
            },
            new Cor() {
                Id = 6,
                Nome = "Branco",
                CodigoHexa = "#aaa"
            }
        };
        builder.Entity<Cor>().HasData(cores);
        #endregion
         #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Nome = "Feminina",
                Foto = @"images/categorias/1.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Masculina",
                Foto = @"images/categorias/2.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Acessórios",
                Foto = @"images/categorias/3.jpg",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Bolsas",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 5,
                Nome = "Calçados",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 6,
                Nome = "Relógios",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

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
               Name = "Funcionário",
               NormalizedName = "FUNCIONARIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion
        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@dmresinas.com",
                NormalizedEmail = "ADMIN@DMRESINAS.COM",
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
                Nome = "Bard0u",
                DataNascimento = DateTime.Parse("22/03/2006"),
                Foto = "/img/users/avatar.png"
            }   
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}