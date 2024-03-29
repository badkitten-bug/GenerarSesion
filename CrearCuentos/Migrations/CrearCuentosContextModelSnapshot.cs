﻿// <auto-generated />
using System;
using CrearCuentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrearCuentos.Migrations
{
    [DbContext(typeof(CrearCuentosContext))]
    partial class CrearCuentosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("CrearCuentos.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("ID");

                    b.Property<string>("Contraseña")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Correo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Dni")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("DNI");

                    b.Property<ulong?>("Estado")
                        .HasColumnType("bit(1)");

                    b.Property<string>("NombreCompletos")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreDeUsuario")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("PermisoInicial")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PermisoPrimaria")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PermisoSecundaria")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
