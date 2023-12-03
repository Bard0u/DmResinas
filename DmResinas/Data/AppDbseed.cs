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
                Nome = "Folha-de-Ouro",
                Foto = @"images/categorias/1.png",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Flores",
                Foto = @"images/categorias/2.png",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Glitter",
                Foto = @"images/categorias/3.png",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Chaveiros",
                Foto = "",
                Filtrar = true,
                Banner = false,
            },
            new Categoria() {
                Id = 5,
                Nome = "Marca-Páginas",
                Foto = "",
                Filtrar = true,
                Banner = false,
            },
            new Categoria() {
                Id = 6,
                Nome = "Placa",
                Foto = "",
                Filtrar = true,
                Banner = false,
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        List<Produto> produtos = new() {
            new Produto() {
                Id = 1,
                Nome = "Letra A com Nome",
                Descricaoresumida = "Chaveiro em formato de Letra A",
                Descricao = "Chaveiro em formato de Letra A, com nome, folha de ouro e cordinha.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 2,
                Nome = "Letra B com Nome",
                Descricaoresumida = "Chaveiro em formato de Letra B",
                Descricao = "Chaveiro em formato de Letra B, com pingente borboleta, flores, brilho, nome e cordinha.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 3,
                Nome = "Letra D",
                Descricaoresumida = "Chaveiro em formato de Letra D",
                Descricao = "Chaveiro em formato de Letra D, com efeito de fumaça, borboletas e cordinha.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 4,
                Nome = "Letra K",
                Descricaoresumida = "Chaveiro em formato de Letra K",
                Descricao = "Chaveiro em formato de Letra K, com flores e brilho na argola prata.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 5,
                Nome = "Letra L",
                Descricaoresumida = "Chaveiro em formato de Letra L",
                Descricao = "Chaveiro em formato de Letra L, com flores na resina totalmente transparente e folha de ouro.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 6,
                Nome = "Letra N",
                Descricaoresumida = "Chaveiro em formato de Letra N",
                Descricao = "Chaveiro em formato de Letra N, com flores e brilho na argola dourada.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 7,
                Nome = "Placa de Manicure com Logo 1",
                Descricaoresumida = "Placa para Manicures tirarem fotos das unhas",
                Descricao = "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.",
                Preco = 40M,
                Destaque = true
            },
            new Produto() {
                Id = 8,
                Nome = "Placa de Manicure com Logo 2",
                Descricaoresumida = "Placa para Manicures tirarem fotos das unhas",
                Descricao = "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.",
                Preco = 40M,
                Destaque = true
            },
            new Produto() {
                Id = 9,
                Nome = "Marca Página 1",
                Descricaoresumida = "Marca Página Elegante",
                Descricao = "Marca Páginas inspirado na banda RHCP com as cores principais e cordinha.",
                Preco = 30M,
                Destaque = true
            },
            new Produto() {
                Id = 10,
                Nome = "Marca Página com Nome",
                Descricaoresumida = "Marca Página Elegante com Nome",
                Descricao = "Marca Páginas elegante com nome, símbolo, brilho e cordinha.",
                Preco = 30M,
                Destaque = true
            },
            new Produto() {
                Id = 11,
                Nome = "Marca Página cauda",
                Descricaoresumida = "Marca Página Elegante de cauda de sereia",
                Descricao = "Marca Página elegante com formato diferente lembrando a cauda de uma sereia e com brilho.",
                Preco = 30M,
                Destaque = true
            }
        };
        builder.Entity<Produto>().HasData(produtos);

        List<ProdutoCategoria> produtoCategorias = new() {
            new ProdutoCategoria() {
                ProdutoId = 1,
                CategoriaId = 1 
            },
            new ProdutoCategoria() {
                ProdutoId = 1,
                CategoriaId = 4
            },
            ////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 2,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 2,
                CategoriaId = 4
            },
            new ProdutoCategoria() {
                ProdutoId = 2,
                CategoriaId = 2
            },
            /////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 3,
                CategoriaId = 4
            },
            /////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 4,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 4,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 4,
                CategoriaId = 4
            },
            ////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 4
            },
            /////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 4
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 6
            },
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 3
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 6
            },
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 3
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 5
            },
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 3
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 10,
                CategoriaId = 5
            },
            new ProdutoCategoria() {
                ProdutoId = 10,
                CategoriaId = 3
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 11,
                CategoriaId = 5
            },
            new ProdutoCategoria() {
                ProdutoId = 11,
                CategoriaId = 3
            }
            //////////////////////////////////
        };
        builder.Entity<ProdutoCategoria>().HasData(produtoCategorias);

        List<ProdutoFoto> produtoFotos = new();
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 1,
            ProdutoId = 1,
            ArquivoFoto = @"/images/Produtos/1/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 2,
            ProdutoId = 2,
            ArquivoFoto = @"/images/Produtos/2/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 3,
            ProdutoId = 3,
            ArquivoFoto = @"/images/Produtos/3/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 4,
            ProdutoId = 4,
            ArquivoFoto = @"/images/Produtos/4/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 5,
            ProdutoId = 5,
            ArquivoFoto = @"/images/Produtos/5/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 6,
            ProdutoId = 6,
            ArquivoFoto = @"/images/Produtos/6/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 7,
            ProdutoId = 7,
            ArquivoFoto = @"/images/Produtos/7/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 8,
            ProdutoId = 8,
            ArquivoFoto = @"/images/Produtos/8/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 9,
            ProdutoId = 9,
            ArquivoFoto = @"/images/Produtos/9/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 10,
            ProdutoId = 10,
            ArquivoFoto = @"/images/Produtos/10/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 11,
            ProdutoId = 11,
            ArquivoFoto = @"/images/Produtos/11/1.png",
            Destaque = true
        });
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);


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