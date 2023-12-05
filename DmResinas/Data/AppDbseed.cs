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
                CodigoHexa = "#85DECB"
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
                CodigoHexa = "#00E0FF"
            },
            new Cor() {
                Id = 8,
                Nome = "Azul Candy",
                CodigoHexa = "#7ab5f9"
            },
            new Cor() {
                Id = 9,
                Nome = "Bege",
                CodigoHexa = "#D6B563"
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
                Descricao = "Elegante e refinado, nosso chaveiro de letra A é uma obra-prima artesanal feita com resina de alta qualidade, realçada por uma delicada folha de ouro que confere um toque de sofisticação. A cor é totalmente personalizável, permitindo que você escolha a tonalidade que melhor reflete seu estilo único. Este chaveiro é mais do que um acessório funcional; é uma expressão de sua individualidade, combinando design contemporâneo com um toque de luxo. Leve consigo não apenas suas chaves, mas uma peça exclusiva que reflete seu gosto refinado.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 2,
                Nome = "Letra B com Nome",
                Descricaoresumida = "Chaveiro em formato de Letra B",
                Descricao = "Deslumbre-se com a sofisticação do nosso chaveiro exclusivo de letra B, meticulosamente confeccionado em resina de alta qualidade que irradia um brilho sutil. Uma delicada flor adorna a peça, acrescentando um toque de elegância, enquanto um pingente de borboleta simboliza transformação e beleza. A cor personalizável oferece a oportunidade de personalizar esta obra de arte conforme seu estilo e preferências únicas. Este não é apenas um chaveiro, é uma declaração de estilo refinado, perfeito para aqueles que apreciam acessórios distintos e atemporais.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 3,
                Nome = "Letra D",
                Descricaoresumida = "Chaveiro em formato de Letra D",
                Descricao = "Explore a elegância contemporânea com nosso chaveiro exclusivo de letra D, esculpido com maestria em resina de alta qualidade. Intrigantes borboletas douradas adornam a peça, conferindo-lhe um toque de sofisticação e leveza. O efeito de fumaça sutil proporciona uma aura única, elevando a peça a um patamar de distinção. A cor personalizável permite que você dê vida à sua visão estética, transformando este chaveiro em um acessório verdadeiramente único. Uma fusão de design inovador e artesanato excepcional, este chaveiro não apenas organiza suas chaves, mas também acrescenta um toque de requinte ao seu estilo diário.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 4,
                Nome = "Marca Página Três Cores",
                Descricaoresumida = "Marca Página Elegante",
                Descricao = "Desfrute de momentos de leitura ainda mais refinados com nosso marcador de páginas exclusivo, meticulosamente elaborado em resina de alta qualidade e enriquecido com uma delicada folha de ouro. Este marcador transcende a funcionalidade, elevando-se a uma obra de arte que reflete sua sofisticação pessoal. A cor personalizável oferece a liberdade de harmonizar o marcador com seu estilo único, enquanto a folha de ouro adiciona um toque de luxo discreto. Seja em romances envolventes ou textos profundos, este marcador não só preserva sua página, mas também acrescenta um toque de elegância ao seu momento de leitura. Experimente a fusão sublime de estética refinada e praticidade inigualável.",
                Preco = 30M,
                Destaque = true
            },
            new Produto() {
                Id = 5,
                Nome = "Marca Página com Nome",
                Descricaoresumida = "Marca Página Elegante com Nome",
                Descricao = "Evoque um toque de glamour em suas leituras com nosso marcador de páginas exclusivo, meticulosamente confeccionado em resina e acentuado por um brilho sutil de glitter. Personalize-o com seu nome, elevando-o de simples acessório a uma peça verdadeiramente única. A cor, à sua escolha, possibilita uma sintonia perfeita com seu estilo pessoal. Este marcador é mais do que uma simples ferramenta funcional; é uma expressão de sua individualidade refinada, combinando design contemporâneo com um toque de sofisticação. Deixe sua marca nas páginas com este acessório que equilibra o brilho discreto com a personalização elegante.",
                Preco = 30M,
                Destaque = true
            },
            new Produto() {
                Id = 6,
                Nome = "Marca Página Sereia",
                Descricaoresumida = "Marca Página Elegante de cauda de sereia",
                Descricao = "Encante-se com a beleza atemporal do nosso marcador de páginas, esculpido em resina com a graciosa forma de uma cauda de sereia. Uma fusão de elegância e fantasia, este marcador acrescenta um toque de sofisticação à sua leitura diária. A cor personalizável permite que você adapte esta peça singular ao seu estilo pessoal, transformando cada momento de pausa na narrativa em uma experiência verdadeiramente cativante. Seja mergulhando em clássicos literários ou navegando por novos horizontes, este marcador de cauda de sereia é um símbolo subtil de sua apreciação pela estética refinada e pela magia da literatura.",
                Preco = 30M,
                Destaque = true
            },
        new Produto() {
                Id = 7,
                Nome = "Letra K",
                Descricaoresumida = "Chaveiro em formato de Letra K",
                Descricao = "Celebre a individualidade com nosso chaveiro exclusivo de letra K, meticulosamente esculpido em resina de alta qualidade, enriquecido com a beleza intemporal de flores delicadamente dispostas. O toque sutil de glitter adiciona uma pitada de sofisticação, elevando este acessório a uma peça única que reflete sua personalidade distinta. A cor personalizável oferece a liberdade de adaptar o chaveiro ao seu estilo pessoal, tornando-o mais do que um simples objeto funcional, mas uma declaração de elegância e originalidade. Seja para organizar suas chaves ou para adornar sua bolsa, este chaveiro é uma expressão encantadora de estilo refinado e apreço pela beleza artística.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 8,
                Nome = "Letra L",
                Descricaoresumida = "Chaveiro em formato de Letra L",
                Descricao = "Explore a elegância única com nosso chaveiro exclusivo de letra L, meticulosamente esculpido em resina de alta qualidade e enriquecido com o luxo discreto de uma folha de ouro. Uma flor delicada adiciona um toque de sofisticação, transformando este chaveiro em uma peça de arte funcional. A cor personalizável permite que você adapte este acessório refinado ao seu estilo pessoal, tornando-o mais do que apenas um item utilitário, mas uma expressão distinta de sua individualidade. Seja em suas chaves ou como um adorno refinado, este chaveiro é um testemunho de estilo refinado e apreço pela qualidade artesanal.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id =9,
                Nome = "Letra N",
                Descricaoresumida = "Chaveiro em formato de Letra N",
                Descricao = "Desperte a sofisticação com nosso chaveiro exclusivo de letra N, uma peça de resina cuidadosamente trabalhada, enriquecida com a sutileza do glitter que confere um brilho discreto. Uma flor delicadamente esculpida adiciona um toque de elegância, transformando este acessório em uma expressão refinada de estilo pessoal. A cor personalizável permite uma adaptação perfeita ao seu gosto distinto, tornando este chaveiro mais do que uma simples utilidade, mas uma declaração de individualidade. Seja em sua bolsa ou organizando suas chaves, este chaveiro é uma fusão harmoniosa de design contemporâneo e toques artísticos, criando um acessório que transcende o ordinário.",
                Preco = 20M,
                Destaque = true
            },
            new Produto() {
                Id = 10,
                Nome = "Placa de Manicure com Logotipo",
                Descricaoresumida = "Placa para Manicures com Logomarca e nome da profissional",
                Descricao = "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.",
                Preco = 40M,
                Destaque = true
            },
            new Produto() {
                Id = 11,
                Nome = "Placa de Manicure com Logotipo",
                Descricaoresumida = "Placa para Manicures tirarem fotos das unhas",
                Descricao = "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.",
                Preco = 40M,
                Destaque = true
            },
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
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 4,
                CategoriaId = 5
            },
            ////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 5,
                CategoriaId = 5
            },
            /////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 6,
                CategoriaId = 5
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 7,
                CategoriaId = 4
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 1
            },
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 8,
                CategoriaId = 4
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 2
            },
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 9,
                CategoriaId = 4
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 10,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 10,
                CategoriaId = 6
            },
            //////////////////////////////////
            new ProdutoCategoria() {
                ProdutoId = 11,
                CategoriaId = 3
            },
            new ProdutoCategoria() {
                ProdutoId = 11,
                CategoriaId = 6
            }
            //////////////////////////////////
        };
        builder.Entity<ProdutoCategoria>().HasData(produtoCategorias);

         List<ProdutoCor> produtoCores = new() {
            new ProdutoCor() {
                ProdutoId = 1,
                CorId = 16
            },
            ////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 2,
                CorId = 27
            },
            /////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 3,
                CorId = 29
            },
            /////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 4,
                CorId = 1
            },
            new ProdutoCor() {
                ProdutoId = 4,
                CorId = 5
            },
            ////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 5,
                CorId = 2
            },
            /////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 6,
                CorId = 7
            },
            //////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 7,
                CorId = 35
            },
            //////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 8,
                CorId = 2
            },
            //////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 9,
                CorId = 16
            },
            //////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 10,
                CorId = 32
            },
            //////////////////////////////////
            new ProdutoCor() {
                ProdutoId = 11,
                CorId = 12
            },
            //////////////////////////////////
        };
        builder.Entity<ProdutoCor>().HasData(produtoCores);

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
            ArquivoFoto = @"/images/Produtos/9/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 5,
            ProdutoId = 5,
            ArquivoFoto = @"/images/Produtos/10/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 6,
            ProdutoId = 6,
            ArquivoFoto = @"/images/Produtos/11/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 7,
            ProdutoId = 7,
            ArquivoFoto = @"/images/Produtos/4/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 8,
            ProdutoId = 8,
            ArquivoFoto = @"/images/Produtos/5/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 9,
            ProdutoId = 9,
            ArquivoFoto = @"/images/Produtos/6/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 10,
            ProdutoId = 10,
            ArquivoFoto = @"/images/Produtos/7/1.png",
            Destaque = true
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 11,
            ProdutoId = 11,
            ArquivoFoto = @"/images/Produtos/8/1.png",
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