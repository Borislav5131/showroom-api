﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Showroom.Infrastructure.Data;

#nullable disable

namespace Showroom.Infrastructure.Migrations
{
    [DbContext(typeof(ShowroomDbContext))]
    [Migration("20221123194326_AddGarage3")]
    partial class AddGarage3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarPart", b =>
                {
                    b.Property<Guid>("CarsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PartsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CarsId", "PartsId");

                    b.HasIndex("PartsId");

                    b.ToTable("CarPart");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GarageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ShowroomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GarageId");

                    b.HasIndex("ShowroomId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Garage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Garages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("157d1dc4-1948-4a26-9891-8a5f5e76c9af"),
                            UserId = new Guid("895aa13a-4eaf-4382-9d93-a646b9cf6929")
                        });
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Part", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Showroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Showrooms");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GarageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("895aa13a-4eaf-4382-9d93-a646b9cf6929"),
                            FirstName = "ADMIN",
                            GarageId = new Guid("157d1dc4-1948-4a26-9891-8a5f5e76c9af"),
                            LastName = "ADMINOV",
                            Password = "123456",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("CarPart", b =>
                {
                    b.HasOne("Showroom.Infrastructure.Data.Entities.Car", null)
                        .WithMany()
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Showroom.Infrastructure.Data.Entities.Part", null)
                        .WithMany()
                        .HasForeignKey("PartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Car", b =>
                {
                    b.HasOne("Showroom.Infrastructure.Data.Entities.Garage", null)
                        .WithMany("Cars")
                        .HasForeignKey("GarageId");

                    b.HasOne("Showroom.Infrastructure.Data.Entities.Showroom", "Showroom")
                        .WithMany("Cars")
                        .HasForeignKey("ShowroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Showroom");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Garage", b =>
                {
                    b.HasOne("Showroom.Infrastructure.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Garage", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Showroom.Infrastructure.Data.Entities.Showroom", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
