﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcSoporte.Data;

namespace MvcSoporte.Migrations
{
    [DbContext(typeof(MvcSoporteContexto))]
    [Migration("20211202143028_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcSoporte.Models.Aviso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAviso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCierre")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoAveriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TipoAveriaId");

                    b.ToTable("Aviso");
                });

            modelBuilder.Entity("MvcSoporte.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("MvcSoporte.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caracteristicas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocalizacionId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrecioCadena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalizacionId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("MvcSoporte.Models.Localizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Localizacion");
                });

            modelBuilder.Entity("MvcSoporte.Models.TipoAveria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoAveria");
                });

            modelBuilder.Entity("MvcSoporte.Models.Aviso", b =>
                {
                    b.HasOne("MvcSoporte.Models.Empleado", "Empleado")
                        .WithMany("Avisos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MvcSoporte.Models.Equipo", "Equipo")
                        .WithMany("Avisos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MvcSoporte.Models.TipoAveria", "TipoAveria")
                        .WithMany("Avisos")
                        .HasForeignKey("TipoAveriaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Equipo");

                    b.Navigation("TipoAveria");
                });

            modelBuilder.Entity("MvcSoporte.Models.Equipo", b =>
                {
                    b.HasOne("MvcSoporte.Models.Localizacion", "Localizacion")
                        .WithMany("Equipos")
                        .HasForeignKey("LocalizacionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Localizacion");
                });

            modelBuilder.Entity("MvcSoporte.Models.Empleado", b =>
                {
                    b.Navigation("Avisos");
                });

            modelBuilder.Entity("MvcSoporte.Models.Equipo", b =>
                {
                    b.Navigation("Avisos");
                });

            modelBuilder.Entity("MvcSoporte.Models.Localizacion", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("MvcSoporte.Models.TipoAveria", b =>
                {
                    b.Navigation("Avisos");
                });
#pragma warning restore 612, 618
        }
    }
}
