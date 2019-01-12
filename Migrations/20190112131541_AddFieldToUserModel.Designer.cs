﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Project_Bier.Repository;

namespace ProjectBier.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20190112131541_AddFieldToUserModel")]
    partial class AddFieldToUserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Project_Bier.Models.Beer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlcoholPercentage");

                    b.Property<bool>("Available");

                    b.Property<string>("BeerColourHex");

                    b.Property<string>("BrewerName");

                    b.Property<string>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<string>("CountryName");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ServingGlass");

                    b.Property<string>("ServingTemperature");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("Project_Bier.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Project_Bier.Models.Discount", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<bool>("Procent");

                    b.HasKey("Code");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Project_Bier.Models.FavoriteList", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("WebshopUserId");

                    b.HasKey("Guid");

                    b.HasIndex("WebshopUserId");

                    b.ToTable("FavoriteList");
                });

            modelBuilder.Entity("Project_Bier.Models.GuestUser", b =>
                {
                    b.Property<Guid>("UserGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<Guid?>("ShippingAddressAssociatedUser");

                    b.Property<string>("ShippingAddressPostalCode");

                    b.Property<string>("ShippingAddressStreetNumber");

                    b.HasKey("UserGuid");

                    b.HasIndex("ShippingAddressPostalCode", "ShippingAddressStreetNumber", "ShippingAddressAssociatedUser");

                    b.ToTable("GuestUsers");
                });

            modelBuilder.Entity("Project_Bier.Models.Order", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AssociatedUserGuid");

                    b.Property<string>("CouponCode");

                    b.Property<decimal>("Discount");

                    b.Property<bool>("EmailConfirmationSent");

                    b.Property<decimal>("FinalPrice");

                    b.Property<DateTime>("OrderCreated");

                    b.Property<DateTime>("OrderPaid");

                    b.Property<DateTime>("OrderShipped");

                    b.Property<int>("OrderStatus");

                    b.Property<bool>("OrderedFromGuestAccount");

                    b.Property<bool>("Paid");

                    b.Property<bool>("Shipped");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Guid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Project_Bier.Models.ProductOrder", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<Guid?>("OrderGuid");

                    b.Property<string>("ProductId");

                    b.HasKey("Guid");

                    b.HasIndex("OrderGuid");

                    b.ToTable("ProductOrder");
                });

            modelBuilder.Entity("Project_Bier.Models.ShippingAddress", b =>
                {
                    b.Property<string>("PostalCode");

                    b.Property<string>("StreetNumber");

                    b.Property<Guid>("AssociatedUser");

                    b.Property<string>("CityName")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Province");

                    b.Property<string>("StreetName")
                        .IsRequired();

                    b.Property<string>("WebshopUserId");

                    b.HasKey("PostalCode", "StreetNumber", "AssociatedUser");

                    b.HasIndex("WebshopUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Project_Bier.Models.WebshopUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<Guid>("UserGuid");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<bool>("isAdmin");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project_Bier.Models.FavoriteList", b =>
                {
                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany("FavoriteLists")
                        .HasForeignKey("WebshopUserId");
                });

            modelBuilder.Entity("Project_Bier.Models.GuestUser", b =>
                {
                    b.HasOne("Project_Bier.Models.ShippingAddress", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressPostalCode", "ShippingAddressStreetNumber", "ShippingAddressAssociatedUser");
                });

            modelBuilder.Entity("Project_Bier.Models.ProductOrder", b =>
                {
                    b.HasOne("Project_Bier.Models.Order")
                        .WithMany("OrderedProducts")
                        .HasForeignKey("OrderGuid");
                });

            modelBuilder.Entity("Project_Bier.Models.ShippingAddress", b =>
                {
                    b.HasOne("Project_Bier.Models.WebshopUser")
                        .WithMany("ShippingAddresses")
                        .HasForeignKey("WebshopUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
