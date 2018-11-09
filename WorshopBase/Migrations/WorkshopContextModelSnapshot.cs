﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorshopBase.Models;

namespace WorshopBase.Migrations
{
    [DbContext(typeof(WorkshopContext))]
    partial class WorkshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

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

            modelBuilder.Entity("WorshopBase.Models.Breakdown", b =>
                {
                    b.Property<int>("breakdownID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("orderID");

                    b.Property<int>("partID");

                    b.Property<int?>("workerID");

                    b.HasKey("breakdownID");

                    b.HasIndex("orderID");

                    b.HasIndex("partID");

                    b.HasIndex("workerID");

                    b.ToTable("Breakdowns");
                });

            modelBuilder.Entity("WorshopBase.Models.Car", b =>
                {
                    b.Property<int>("carID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("bodyNumber");

                    b.Property<string>("colour");

                    b.Property<int>("engineNumber");

                    b.Property<string>("model");

                    b.Property<int>("ownerID");

                    b.Property<string>("stateNumber");

                    b.Property<int>("vis");

                    b.Property<int>("yearOfIssue");

                    b.HasKey("carID");

                    b.HasIndex("ownerID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WorshopBase.Models.Order", b =>
                {
                    b.Property<int>("orderID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("carID");

                    b.Property<DateTime?>("dateCompletion");

                    b.Property<DateTime>("dateReceipt");

                    b.Property<int>("workerID");

                    b.HasKey("orderID");

                    b.HasIndex("carID");

                    b.HasIndex("workerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WorshopBase.Models.Owner", b =>
                {
                    b.Property<int>("ownerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("adress");

                    b.Property<int>("driverLicense");

                    b.Property<string>("fioOwner");

                    b.Property<int>("phone");

                    b.HasKey("ownerID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("WorshopBase.Models.Part", b =>
                {
                    b.Property<int>("partID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descriptionPart");

                    b.Property<string>("partName");

                    b.Property<decimal>("price");

                    b.HasKey("partID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("WorshopBase.Models.Post", b =>
                {
                    b.Property<int>("postID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("descriptionPost");

                    b.Property<string>("postName");

                    b.HasKey("postID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WorshopBase.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

                    b.Property<int?>("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WorshopBase.Models.Worker", b =>
                {
                    b.Property<int>("workerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("dateOfDismissal");

                    b.Property<DateTime>("dateOfEmployment");

                    b.Property<string>("fioWorker");

                    b.Property<int?>("postID");

                    b.Property<decimal>("salary");

                    b.HasKey("workerID");

                    b.HasIndex("postID");

                    b.ToTable("Workers");
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
                    b.HasOne("WorshopBase.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WorshopBase.Models.User")
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

                    b.HasOne("WorshopBase.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WorshopBase.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorshopBase.Models.Breakdown", b =>
                {
                    b.HasOne("WorshopBase.Models.Order", "Order")
                        .WithMany("Breakdowns")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorshopBase.Models.Part", "Part")
                        .WithMany("Breakdowns")
                        .HasForeignKey("partID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorshopBase.Models.Worker", "Worker")
                        .WithMany("Breakdowns")
                        .HasForeignKey("workerID");
                });

            modelBuilder.Entity("WorshopBase.Models.Car", b =>
                {
                    b.HasOne("WorshopBase.Models.Owner", "Owner")
                        .WithMany("Cars")
                        .HasForeignKey("ownerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorshopBase.Models.Order", b =>
                {
                    b.HasOne("WorshopBase.Models.Car", "Car")
                        .WithMany("Orders")
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorshopBase.Models.Worker", "Worker")
                        .WithMany("Orders")
                        .HasForeignKey("workerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorshopBase.Models.Worker", b =>
                {
                    b.HasOne("WorshopBase.Models.Post", "Post")
                        .WithMany("Workers")
                        .HasForeignKey("postID");
                });
#pragma warning restore 612, 618
        }
    }
}
