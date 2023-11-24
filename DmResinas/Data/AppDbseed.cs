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
                CodigoHexa = "#000000"
            },
            new Cor() {
                Id = 2,
                Nome = "Amarelo",
                CodigoHexa = "#efca3e"
            },
            new Cor() {
                Id = 3,
                Nome = "Cinza",
                CodigoHexa = "#9399a7"
            },
            new Cor() {
                Id = 4,
                Nome = "Verde Água",
                CodigoHexa = "#85dedc"
            },
            new Cor() {
                Id = 5,
                Nome = "Vermelho",
                CodigoHexa = "#bd1600"
            },
            new Cor() {
                Id = 6,
                Nome = "Branco",
                CodigoHexa = "#ffffff"
            },
            new Cor() {
                Id = 7,
                Nome = "Azul Turquesa",
                CodigoHexa = "#1b4a82"
            },
            new Cor() {
                Id = 8,
                Nome = "Azul Candy",
                CodigoHexa = "#7ab5f9"
            },
            new Cor() {
                Id = 9,
                Nome = "Bege",
                CodigoHexa = "#7ab5f9"
            },
            new Cor() {
                Id = 10,
                Nome = "Amarelo Vintage",
                CodigoHexa = "#efe48a"
            },
            new Cor() {
                Id = 11,
                Nome = "Lilás",
                CodigoHexa = "#978ec5"
            },
            new Cor() {
                Id = 12,
                Nome = "Rosa Flamingo",
                CodigoHexa = "#df98b9"
            },
            new Cor() {
                Id = 13,
                Nome = "Branco Perolado",
                CodigoHexa = "#ffffff"
            },
            new Cor() {
                Id = 14,
                Nome = "Cinza Perolado",
                CodigoHexa = "#524f40"
            },
            new Cor() {
                Id = 15,
                Nome = "Verde Escuro Perolado",
                CodigoHexa = "#20362d"
            },
            new Cor() {
                Id = 16,
                Nome = "Azul Escuro Perolado",
                CodigoHexa = "#001386"
            },
            new Cor() {
                Id = 17,
                Nome = "Azul Perolado",
                CodigoHexa = "#034edb"
            },
            new Cor() {
                Id = 18,
                Nome = "Azul Claro Perolado",
                CodigoHexa = "#2890e5"
            },
            new Cor() {
                Id = 19,
                Nome = "Marrom Escuro Perolado",
                CodigoHexa = "#835426"
            },
            new Cor() {
                Id = 20,
                Nome = "Marrom Perolado",
                CodigoHexa = "#5e4624"
            },
            new Cor() {
                Id = 21,
                Nome = "Bronze Perolado",
                CodigoHexa = "#835426"
            },
            new Cor() {
                Id = 22,
                Nome = "Marrom Claro Perolado",
                CodigoHexa = "#ac7032"
            },
            new Cor() {
                Id = 23,
                Nome = "Laranja Perolado",
                CodigoHexa = "#f03b04"
            },
            new Cor() {
                Id = 24,
                Nome = "Amarelo Perolado",
                CodigoHexa = "#e8ce33"
            },
            new Cor() {
                Id = 25,
                Nome = "Dourado Claro Perolado",
                CodigoHexa = "#e0a621"
            },
            new Cor() {
                Id = 26,
                Nome = "Dourado Perolado",
                CodigoHexa = "#cc9900"
            },
            new Cor() {
                Id = 27,
                Nome = "Roxo Perolado",
                CodigoHexa = "#581598"
            },
            new Cor() {
                Id = 28,
                Nome = "Rosa Claro Perolado",
                CodigoHexa = "#ffb2d1"
            },
            new Cor() {
                Id = 29,
                Nome = "Rosa Chiclete Perolado",
                CodigoHexa = "#e17282"
            },
            new Cor() {
                Id = 30,
                Nome = "Pink Perolado",
                CodigoHexa = "#cb3038"
            },
            new Cor() {
                Id = 31,
                Nome = "Rosa Perolado",
                CodigoHexa = "#cc2862"
            },
            new Cor() {
                Id = 32,
                Nome = "Rosa Choque Perolado",
                CodigoHexa = "#f3134f"
            },
            new Cor() {
                Id = 33,
                Nome = "Cobre Perolado",
                CodigoHexa = "#a31208"
            },
            new Cor() {
                Id = 34,
                Nome = "Verde Fluorescente Perolado",
                CodigoHexa = "#4fdb22"
            },
            new Cor() {
                Id = 35,
                Nome = "Verde Esmeralda Perolado",
                CodigoHexa = "#06785f"
            },
            new Cor() {
                Id = 36,
                Nome = "Verde Água Perolado",
                CodigoHexa = "#38ab72"
            },
            new Cor() {
                Id = 37,
                Nome = "Verde Bandeira Perolado",
                CodigoHexa = "#1d5236"
            },
            new Cor() {
                Id = 38,
                Nome = "Verde Claro Perolado",
                CodigoHexa = "#9dbd69"
            },
            new Cor() {
                Id = 39,
                Nome = "Magenta Perolado",
                CodigoHexa = "#d4124e"
            }
        };
        builder.Entity<Cor>().HasData(cores);
        #endregion
         #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Nome = "Folha de Ouro",
                Foto = @"images/categorias/1.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Flores",
                Foto = @"images/categorias/2.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Decoração",
                Foto = @"images/categorias/3.jpg",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Chaveiros",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            new Categoria() {
                Id = 5,
                Nome = "Marca Páginas",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },
            /*new Categoria() {
                Id = 6,
                Nome = "Com Nome",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaPaiId = 3
            },*/ // O Gallo falou para rever a relação das categorias, segunda ve isso com ele certinho
            new Categoria() {
                Id = 7,
                Nome = "Placa",
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