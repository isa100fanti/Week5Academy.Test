﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Week5Academy.Esercitazione.EF;

namespace Week5Academy.Esercitazione.EF.Migrations
{
    [DbContext(typeof(DishContext))]
    [Migration("20210827121517_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Week5Academy.Esercitazione.Core.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReturnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "1234",
                            Role = 1,
                            Username = "ginos@venice.it"
                        },
                        new
                        {
                            Id = 2,
                            Password = "5678",
                            Role = 0,
                            Username = "isacento@vabc.it"
                        });
                });

            modelBuilder.Entity("Week5Academy.Esercitazione.Core.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TypeCourse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dish");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "pasta al pomodoro con basilico",
                            Name = "pasta al sugo",
                            Price = 8.0,
                            TypeCourse = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "hamburger con cheddar e insalata",
                            Name = " hamburger",
                            Price = 10.300000000000001,
                            TypeCourse = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
