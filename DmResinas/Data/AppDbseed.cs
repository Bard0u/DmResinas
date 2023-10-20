using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DmResinas.Models;

namespace DmResinas.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        
        List<Cor> cores = new() {
            
           //Colocar as Cores!!!!!!!!!
        };
        builder.Entity<Cor>().HasData(cores);

        #region Populate Categoria
        List<Categoria> categorias = new() {
           // Aqui vc coloca as categorias
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Tag
        List<Tag> tags = new() {
            //Aqui coloca as tags
        };
        builder.Entity<Tag>().HasData(tags);
        #endregion

        #region Populate Produtos
        List<Produto> produtos = new() {
            //Aqui vc coloca os produtos
        };
        builder.Entity<Produto>().HasData(produtos);



        List<ProdutoCategoria> produtoCategorias = new() {
            //aqui vc vai colocar as categorias
        };
        builder.Entity<ProdutoCategoria>().HasData(produtoCategorias);



        List<ProdutoTag> produtoTags = new();
        for (int i = 1; i <= 12; i++)
            produtoTags.Add(new ProdutoTag()
            {
                //Aqui vc coloca as tags
            });
        builder.Entity<ProdutoTag>().HasData(produtoTags);
//sorteio de tags e categorias
        List<ProdutoFoto> produtoFotos = new();
        for (int i = 1; i <= 12; i++)
            produtoFotos.Add(new ProdutoFoto()
            {//Aqui entra as fotos dos produtos
            });
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);

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
                Email = "admin@cozastore.com",
                NormalizedEmail = "pedroarossettoo@gmail.COM",
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
                Nome = "Resinas",
                DataNascimento = DateTime.Parse("22/05/2006"),
                Foto = "/images/usuarios/avatar.png"
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