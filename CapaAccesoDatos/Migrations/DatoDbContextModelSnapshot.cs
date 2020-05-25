﻿// <auto-generated />
using System;
using CapaAccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapaAccesoDatos.Migrations
{
    [DbContext(typeof(DatoDbContext))]
    partial class DatoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapaDeDominio.Entity.DestinoVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DestinoVentas");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_ventaReclamo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoEstadoNavigatorId")
                        .HasColumnType("int");

                    b.Property<int>("Tipoestado")
                        .HasColumnType("int");

                    b.Property<int?>("VentaReclamoNavigatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoEstadoNavigatorId");

                    b.HasIndex("VentaReclamoNavigatorId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Forma")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormaPagos");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.TipoEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoEstados");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DestinoVentaNavigatorId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadoVentaNavigatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FormaPagoNavigatorId")
                        .HasColumnType("int");

                    b.Property<int>("Id_carrito")
                        .HasColumnType("int");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_destinoventa")
                        .HasColumnType("int");

                    b.Property<int>("Id_estadoventa")
                        .HasColumnType("int");

                    b.Property<int>("Id_tomapago")
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.HasIndex("DestinoVentaNavigatorId");

                    b.HasIndex("EstadoVentaNavigatorId");

                    b.HasIndex("FormaPagoNavigatorId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.VentaReclamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reclamo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VentasReclamos");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.Estado", b =>
                {
                    b.HasOne("CapaDeDominio.Entity.TipoEstado", "TipoEstadoNavigator")
                        .WithMany()
                        .HasForeignKey("TipoEstadoNavigatorId");

                    b.HasOne("CapaDeDominio.Entity.VentaReclamo", "VentaReclamoNavigator")
                        .WithMany()
                        .HasForeignKey("VentaReclamoNavigatorId");
                });

            modelBuilder.Entity("CapaDeDominio.Entity.Venta", b =>
                {
                    b.HasOne("CapaDeDominio.Entity.DestinoVenta", "DestinoVentaNavigator")
                        .WithMany()
                        .HasForeignKey("DestinoVentaNavigatorId");

                    b.HasOne("CapaDeDominio.Entity.Estado", "EstadoVentaNavigator")
                        .WithMany()
                        .HasForeignKey("EstadoVentaNavigatorId");

                    b.HasOne("CapaDeDominio.Entity.FormaPago", "FormaPagoNavigator")
                        .WithMany()
                        .HasForeignKey("FormaPagoNavigatorId");
                });
#pragma warning restore 612, 618
        }
    }
}
