﻿// <auto-generated />
using System;
using DmResinas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DmResinas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DmResinas.Models.Categories", b =>
                {
                    b.Property<byte>("CategoriesId")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("CategorieName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("CategoriesId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DmResinas.Models.Colors", b =>
                {
                    b.Property<byte>("CorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DmResinas.Models.Images", b =>
                {
                    b.Property<byte>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("ImageCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DmResinas.Models.ProductCategories", b =>
                {
                    b.Property<int>("ProdId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<byte>("CategorieId")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnOrder(2);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProdId", "CategorieId");

                    b.HasIndex("CategorieId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("DmResinas.Models.ProductColors", b =>
                {
                    b.Property<int>("ProdId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<byte>("ColorId")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnOrder(2);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProdId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("DmResinas.Models.Products", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("ProdCode")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("ProdDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProdName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<double>("ProdPrice")
                        .HasColumnType("double");

                    b.Property<byte>("ProdQtd")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("ProdId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DmResinas.Models.Sizes", b =>
                {
                    b.Property<byte>("SizeId")
                        .HasColumnType("tinyint unsigned");

                    b.Property<double>("height")
                        .HasColumnType("double");

                    b.Property<double>("width")
                        .HasColumnType("double");

                    b.HasKey("SizeId");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "91ee144c-af5f-4f11-a8a2-8e2be3f5ff6c",
                            ConcurrencyStamp = "137bf228-4fa9-48c9-bf2e-97c794acda14",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "6e458181-f3f8-4971-915f-0be18852e8e2",
                            ConcurrencyStamp = "7dfaae6d-de40-4949-b5ad-8627fbaa418f",
                            Name = "Moderador",
                            NormalizedName = "MODERADOR"
                        },
                        new
                        {
                            Id = "51e448ef-c856-42cc-bdce-09fe66297bed",
                            ConcurrencyStamp = "5545e0e0-5af7-4321-aa33-03b461cdbe55",
                            Name = "Usuário",
                            NormalizedName = "USUÁRIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RolesClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "65d65b72-4157-445e-93be-72727af19ada",
                            RoleId = "91ee144c-af5f-4f11-a8a2-8e2be3f5ff6c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("DmResinas.Models.Clients", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("ClientAge")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<short>("ClientPhone")
                        .HasColumnType("smallint");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            Id = "65d65b72-4157-445e-93be-72727af19ada",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dcd3ff48-58a1-49a6-b719-d8dca2ec63e2",
                            Email = "pedroarossettoo@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PEDROAROSSETTOO@GMAIL.COM",
                            NormalizedUserName = "BARD0U",
                            PasswordHash = "AQAAAAEAACcQAAAAEOJk+6WYKx/uQR4flVa5WOp1ZYjQT6Hjk6pvqDdvODX0EHWGCWbbTy7iGFQQxB2WLA==",
                            PhoneNumber = "14997418713",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "37c219cf-e7ca-47c7-adc8-575ea1be782b",
                            TwoFactorEnabled = false,
                            UserName = "Bard0u",
                            ClientAge = new DateTime(2006, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClientName = "Pedro Luiz",
                            ClientPhone = (short)0
                        });
                });

            modelBuilder.Entity("DmResinas.Models.ProductCategories", b =>
                {
                    b.HasOne("DmResinas.Models.Categories", "Categorie")
                        .WithMany("Products")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DmResinas.Models.Products", "Products")
                        .WithMany("Categories")
                        .HasForeignKey("ProdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("DmResinas.Models.ProductColors", b =>
                {
                    b.HasOne("DmResinas.Models.Colors", "Colors")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DmResinas.Models.Products", "Products")
                        .WithMany("Colors")
                        .HasForeignKey("ProdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colors");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DmResinas.Models.Clients", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithOne()
                        .HasForeignKey("DmResinas.Models.Clients", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DmResinas.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DmResinas.Models.Colors", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DmResinas.Models.Products", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Colors");
                });
#pragma warning restore 612, 618
        }
    }
}
