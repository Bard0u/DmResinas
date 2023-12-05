using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DmResinas.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Filtrar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Banner = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CategoriaPaiId = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Categoria_CategoriaPaiId",
                        column: x => x.CategoriaPaiId,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cor",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoHexa = table.Column<string>(type: "varchar(7)", maxLength: 7, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricaoresumida = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SKU = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    Material = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dimensao = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tamanho",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sigla = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanho", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdtoCategoria",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdtoCategoria", x => new { x.ProdutoId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_ProdtoCategoria_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdtoCategoria_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoCor",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    CorId = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCor", x => new { x.ProdutoId, x.CorId });
                    table.ForeignKey(
                        name: "FK_ProdutoCor_Cor_CorId",
                        column: x => x.CorId,
                        principalTable: "Cor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCor_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoFotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ArquivoFoto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destaque = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoFotos", x => new { x.Id, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ProdutoFotos_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProdutoAvaliacao",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoTexto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AvaliacaoData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProdutoNota = table.Column<byte>(type: "tinyint unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoAvaliacao", x => new { x.ProdutoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoAvaliacao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "330a0642-f381-47eb-bc76-d5b5a4e20c37", "2d2bd2d7-1b92-4e97-8edf-ab02bce0fe98", "Funcionário", "FUNCIONARIO" },
                    { "71d01fef-da3d-4140-8bb7-01651ce361e3", "53c87255-0979-4197-a4c4-25c8359d0e66", "Cliente", "CLIENTE" },
                    { "869d3187-0ff2-4880-9d27-c22da1ec1619", "f74f0355-6414-468e-ac3e-a405b5084404", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66ab7735-dfc0-49bb-9379-02c7ff3cc738", 0, "2778597a-bd73-41b1-a743-67cd055f13a7", "admin@dmresinas.com", true, false, null, "ADMIN@DMRESINAS.COM", "ADMIN", "AQAAAAEAACcQAAAAEJzO2VQeUvyuNHUgxoCbbN+MizjrH0JRuoudx1ia4HLs2i0kjxjngRCDgVZWN4BiGQ==", null, false, "8bbda3a9-3456-458c-9d71-3488333d752b", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Banner", "CategoriaPaiId", "Filtrar", "Foto", "Nome" },
                values: new object[,]
                {
                    { (byte)1, true, null, true, "images/categorias/1.png", "Folha-de-Ouro" },
                    { (byte)2, true, null, true, "images/categorias/2.png", "Flores" },
                    { (byte)3, true, null, false, "images/categorias/3.png", "Glitter" },
                    { (byte)4, false, null, true, "", "Chaveiros" },
                    { (byte)5, false, null, true, "", "Marca-Páginas" },
                    { (byte)6, false, null, true, "", "Placa" }
                });

            migrationBuilder.InsertData(
                table: "Cor",
                columns: new[] { "Id", "CodigoHexa", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "#000000", "Preto" },
                    { (byte)2, "#efca3e", "Amarelo" },
                    { (byte)3, "#9399a7", "Cinza" },
                    { (byte)4, "#85DECB", "Verde Água" },
                    { (byte)5, "#bd1600", "Vermelho" },
                    { (byte)6, "#ffffff", "Branco" },
                    { (byte)7, "#00E0FF", "Azul Turquesa" },
                    { (byte)8, "#7ab5f9", "Azul Candy" },
                    { (byte)9, "#D6B563", "Bege" },
                    { (byte)10, "#efe48a", "Amarelo Vintage" },
                    { (byte)11, "#978ec5", "Lilás" },
                    { (byte)12, "#df98b9", "Rosa Flamingo" },
                    { (byte)13, "#ffffff", "Branco Perolado" },
                    { (byte)14, "#524f40", "Cinza Perolado" },
                    { (byte)15, "#20362d", "Verde Escuro Perolado" },
                    { (byte)16, "#001386", "Azul Escuro Perolado" },
                    { (byte)17, "#034edb", "Azul Perolado" },
                    { (byte)18, "#2890e5", "Azul Claro Perolado" },
                    { (byte)19, "#835426", "Marrom Escuro Perolado" },
                    { (byte)20, "#5e4624", "Marrom Perolado" },
                    { (byte)21, "#835426", "Bronze Perolado" },
                    { (byte)22, "#ac7032", "Marrom Claro Perolado" },
                    { (byte)23, "#f03b04", "Laranja Perolado" },
                    { (byte)24, "#e8ce33", "Amarelo Perolado" },
                    { (byte)25, "#e0a621", "Dourado Claro Perolado" },
                    { (byte)26, "#cc9900", "Dourado Perolado" },
                    { (byte)27, "#581598", "Roxo Perolado" },
                    { (byte)28, "#ffb2d1", "Rosa Claro Perolado" },
                    { (byte)29, "#e17282", "Rosa Chiclete Perolado" },
                    { (byte)30, "#cb3038", "Pink Perolado" },
                    { (byte)31, "#cc2862", "Rosa Perolado" },
                    { (byte)32, "#f3134f", "Rosa Choque Perolado" },
                    { (byte)33, "#a31208", "Cobre Perolado" },
                    { (byte)34, "#4fdb22", "Verde Fluorescente Perolado" },
                    { (byte)35, "#06785f", "Verde Esmeralda Perolado" },
                    { (byte)36, "#38ab72", "Verde Água Perolado" },
                    { (byte)37, "#1d5236", "Verde Bandeira Perolado" },
                    { (byte)38, "#9dbd69", "Verde Claro Perolado" },
                    { (byte)39, "#d4124e", "Magenta Perolado" }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Descricaoresumida", "Destaque", "Dimensao", "Material", "Nome", "Peso", "Preco", "SKU" },
                values: new object[,]
                {
                    { 1, "Elegante e refinado, nosso chaveiro de letra A é uma obra-prima artesanal feita com resina de alta qualidade, realçada por uma delicada folha de ouro que confere um toque de sofisticação. A cor é totalmente personalizável, permitindo que você escolha a tonalidade que melhor reflete seu estilo único. Este chaveiro é mais do que um acessório funcional; é uma expressão de sua individualidade, combinando design contemporâneo com um toque de luxo. Leve consigo não apenas suas chaves, mas uma peça exclusiva que reflete seu gosto refinado.", "Chaveiro em formato de Letra A", true, null, null, "Letra A com Nome", 0m, 20m, null },
                    { 2, "Deslumbre-se com a sofisticação do nosso chaveiro exclusivo de letra B, meticulosamente confeccionado em resina de alta qualidade que irradia um brilho sutil. Uma delicada flor adorna a peça, acrescentando um toque de elegância, enquanto um pingente de borboleta simboliza transformação e beleza. A cor personalizável oferece a oportunidade de personalizar esta obra de arte conforme seu estilo e preferências únicas. Este não é apenas um chaveiro, é uma declaração de estilo refinado, perfeito para aqueles que apreciam acessórios distintos e atemporais.", "Chaveiro em formato de Letra B", true, null, null, "Letra B com Nome", 0m, 20m, null },
                    { 3, "Explore a elegância contemporânea com nosso chaveiro exclusivo de letra D, esculpido com maestria em resina de alta qualidade. Intrigantes borboletas douradas adornam a peça, conferindo-lhe um toque de sofisticação e leveza. O efeito de fumaça sutil proporciona uma aura única, elevando a peça a um patamar de distinção. A cor personalizável permite que você dê vida à sua visão estética, transformando este chaveiro em um acessório verdadeiramente único. Uma fusão de design inovador e artesanato excepcional, este chaveiro não apenas organiza suas chaves, mas também acrescenta um toque de requinte ao seu estilo diário.", "Chaveiro em formato de Letra D", true, null, null, "Letra D", 0m, 20m, null },
                    { 4, "Desfrute de momentos de leitura ainda mais refinados com nosso marcador de páginas exclusivo, meticulosamente elaborado em resina de alta qualidade e enriquecido com uma delicada folha de ouro. Este marcador transcende a funcionalidade, elevando-se a uma obra de arte que reflete sua sofisticação pessoal. A cor personalizável oferece a liberdade de harmonizar o marcador com seu estilo único, enquanto a folha de ouro adiciona um toque de luxo discreto. Seja em romances envolventes ou textos profundos, este marcador não só preserva sua página, mas também acrescenta um toque de elegância ao seu momento de leitura. Experimente a fusão sublime de estética refinada e praticidade inigualável.", "Marca Página Elegante", true, null, null, "Marca Página Três Cores", 0m, 30m, null },
                    { 5, "Evoque um toque de glamour em suas leituras com nosso marcador de páginas exclusivo, meticulosamente confeccionado em resina e acentuado por um brilho sutil de glitter. Personalize-o com seu nome, elevando-o de simples acessório a uma peça verdadeiramente única. A cor, à sua escolha, possibilita uma sintonia perfeita com seu estilo pessoal. Este marcador é mais do que uma simples ferramenta funcional; é uma expressão de sua individualidade refinada, combinando design contemporâneo com um toque de sofisticação. Deixe sua marca nas páginas com este acessório que equilibra o brilho discreto com a personalização elegante.", "Marca Página Elegante com Nome", true, null, null, "Marca Página com Nome", 0m, 30m, null },
                    { 6, "Encante-se com a beleza atemporal do nosso marcador de páginas, esculpido em resina com a graciosa forma de uma cauda de sereia. Uma fusão de elegância e fantasia, este marcador acrescenta um toque de sofisticação à sua leitura diária. A cor personalizável permite que você adapte esta peça singular ao seu estilo pessoal, transformando cada momento de pausa na narrativa em uma experiência verdadeiramente cativante. Seja mergulhando em clássicos literários ou navegando por novos horizontes, este marcador de cauda de sereia é um símbolo subtil de sua apreciação pela estética refinada e pela magia da literatura.", "Marca Página Elegante de cauda de sereia", true, null, null, "Marca Página Sereia", 0m, 30m, null },
                    { 7, "Celebre a individualidade com nosso chaveiro exclusivo de letra K, meticulosamente esculpido em resina de alta qualidade, enriquecido com a beleza intemporal de flores delicadamente dispostas. O toque sutil de glitter adiciona uma pitada de sofisticação, elevando este acessório a uma peça única que reflete sua personalidade distinta. A cor personalizável oferece a liberdade de adaptar o chaveiro ao seu estilo pessoal, tornando-o mais do que um simples objeto funcional, mas uma declaração de elegância e originalidade. Seja para organizar suas chaves ou para adornar sua bolsa, este chaveiro é uma expressão encantadora de estilo refinado e apreço pela beleza artística.", "Chaveiro em formato de Letra K", true, null, null, "Letra K", 0m, 20m, null },
                    { 8, "Explore a elegância única com nosso chaveiro exclusivo de letra L, meticulosamente esculpido em resina de alta qualidade e enriquecido com o luxo discreto de uma folha de ouro. Uma flor delicada adiciona um toque de sofisticação, transformando este chaveiro em uma peça de arte funcional. A cor personalizável permite que você adapte este acessório refinado ao seu estilo pessoal, tornando-o mais do que apenas um item utilitário, mas uma expressão distinta de sua individualidade. Seja em suas chaves ou como um adorno refinado, este chaveiro é um testemunho de estilo refinado e apreço pela qualidade artesanal.", "Chaveiro em formato de Letra L", true, null, null, "Letra L", 0m, 20m, null },
                    { 9, "Desperte a sofisticação com nosso chaveiro exclusivo de letra N, uma peça de resina cuidadosamente trabalhada, enriquecida com a sutileza do glitter que confere um brilho discreto. Uma flor delicadamente esculpida adiciona um toque de elegância, transformando este acessório em uma expressão refinada de estilo pessoal. A cor personalizável permite uma adaptação perfeita ao seu gosto distinto, tornando este chaveiro mais do que uma simples utilidade, mas uma declaração de individualidade. Seja em sua bolsa ou organizando suas chaves, este chaveiro é uma fusão harmoniosa de design contemporâneo e toques artísticos, criando um acessório que transcende o ordinário.", "Chaveiro em formato de Letra N", true, null, null, "Letra N", 0m, 20m, null },
                    { 10, "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.", "Placa para Manicures com Logomarca e nome da profissional", true, null, null, "Placa de Manicure com Logotipo", 0m, 40m, null },
                    { 11, "Placa para Manicures tiratem fotos de suas clientes após fazerem a unha para promover a divulgação da profissional.", "Placa para Manicures tirarem fotos das unhas", true, null, null, "Placa de Manicure com Logotipo", 0m, 40m, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "330a0642-f381-47eb-bc76-d5b5a4e20c37", "66ab7735-dfc0-49bb-9379-02c7ff3cc738" },
                    { "71d01fef-da3d-4140-8bb7-01651ce361e3", "66ab7735-dfc0-49bb-9379-02c7ff3cc738" },
                    { "869d3187-0ff2-4880-9d27-c22da1ec1619", "66ab7735-dfc0-49bb-9379-02c7ff3cc738" }
                });

            migrationBuilder.InsertData(
                table: "ProdtoCategoria",
                columns: new[] { "CategoriaId", "ProdutoId" },
                values: new object[,]
                {
                    { (byte)1, 1 },
                    { (byte)4, 1 },
                    { (byte)2, 2 },
                    { (byte)3, 2 },
                    { (byte)4, 2 },
                    { (byte)4, 3 },
                    { (byte)1, 4 },
                    { (byte)5, 4 },
                    { (byte)3, 5 },
                    { (byte)5, 5 },
                    { (byte)3, 6 },
                    { (byte)5, 6 },
                    { (byte)2, 7 },
                    { (byte)3, 7 },
                    { (byte)4, 7 },
                    { (byte)1, 8 },
                    { (byte)2, 8 },
                    { (byte)4, 8 },
                    { (byte)2, 9 },
                    { (byte)3, 9 },
                    { (byte)4, 9 },
                    { (byte)3, 10 },
                    { (byte)6, 10 },
                    { (byte)3, 11 },
                    { (byte)6, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoCor",
                columns: new[] { "CorId", "ProdutoId" },
                values: new object[,]
                {
                    { (byte)16, 1 },
                    { (byte)27, 2 },
                    { (byte)29, 3 },
                    { (byte)1, 4 },
                    { (byte)5, 4 },
                    { (byte)2, 5 },
                    { (byte)7, 6 },
                    { (byte)35, 7 },
                    { (byte)2, 8 },
                    { (byte)16, 9 },
                    { (byte)32, 10 },
                    { (byte)12, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProdutoFotos",
                columns: new[] { "Id", "ProdutoId", "ArquivoFoto", "Destaque" },
                values: new object[,]
                {
                    { 1, 1, "/images/Produtos/1/1.png", true },
                    { 2, 2, "/images/Produtos/2/1.png", true },
                    { 3, 3, "/images/Produtos/3/1.png", true },
                    { 4, 4, "/images/Produtos/9/1.png", true },
                    { 5, 5, "/images/Produtos/10/1.png", true },
                    { 6, 6, "/images/Produtos/11/1.png", true },
                    { 7, 7, "/images/Produtos/4/1.png", true },
                    { 8, 8, "/images/Produtos/5/1.png", true },
                    { 9, 9, "/images/Produtos/6/1.png", true },
                    { 10, 10, "/images/Produtos/7/1.png", true },
                    { 11, 11, "/images/Produtos/8/1.png", true }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "66ab7735-dfc0-49bb-9379-02c7ff3cc738", new DateTime(2006, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/users/avatar.png", "Bard0u" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_CategoriaPaiId",
                table: "Categoria",
                column: "CategoriaPaiId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdtoCategoria_CategoriaId",
                table: "ProdtoCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoAvaliacao_UsuarioId",
                table: "ProdutoAvaliacao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCor_CorId",
                table: "ProdutoCor",
                column: "CorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoFotos_ProdutoId",
                table: "ProdutoFotos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProdtoCategoria");

            migrationBuilder.DropTable(
                name: "ProdutoAvaliacao");

            migrationBuilder.DropTable(
                name: "ProdutoCor");

            migrationBuilder.DropTable(
                name: "ProdutoFotos");

            migrationBuilder.DropTable(
                name: "Tamanho");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cor");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
