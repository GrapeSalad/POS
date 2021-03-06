﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using POS.Models;

namespace POS.Migrations
{
    [DbContext(typeof(POSDbContext))]
    [Migration("20170817215129_TestingCalculatedColumns")]
    partial class TestingCalculatedColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("POS.Models.App", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Availability");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("POS.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("POS.Models.Beer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ABV");

                    b.Property<bool>("Availability");

                    b.Property<float>("BottlePrice");

                    b.Property<float>("GlassPrice");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<string>("Producer");

                    b.Property<string>("Style");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("POS.Models.Dessert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Availability");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Desserts");
                });

            modelBuilder.Entity("POS.Models.Entre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Availability");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Entres");
                });

            modelBuilder.Entity("POS.Models.MixedDrink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Availability");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<float>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("MixedDrinks");
                });

            modelBuilder.Entity("POS.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TableId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("POS.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<int>("Number");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("POS.Models.Wine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("ABV");

                    b.Property<bool>("Availability");

                    b.Property<double>("BottlePrice");

                    b.Property<double>("Cost");

                    b.Property<double>("GlassPrice")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<double>("Markup");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<string>("Producer");

                    b.Property<string>("Varietals");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Wines");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("POS.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("POS.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("POS.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("POS.Models.App", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("App")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("POS.Models.Beer", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("Beer")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("POS.Models.Dessert", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("Dessert")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("POS.Models.Entre", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("Entre")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("POS.Models.MixedDrink", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("MixedDrink")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("POS.Models.Order", b =>
                {
                    b.HasOne("POS.Models.Table")
                        .WithMany("Order")
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("POS.Models.Table", b =>
                {
                    b.HasOne("POS.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("POS.Models.Wine", b =>
                {
                    b.HasOne("POS.Models.Order")
                        .WithMany("Wine")
                        .HasForeignKey("OrderId");
                });
        }
    }
}
