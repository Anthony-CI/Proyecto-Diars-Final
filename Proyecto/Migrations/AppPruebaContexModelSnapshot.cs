﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.DB;

namespace Proyecto.Migrations
{
    [DbContext(typeof(AppPruebaContex))]
    partial class AppPruebaContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto.Models.Cuenta", b =>
                {
                    b.Property<int>("IdCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Concepto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiaCierre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DiaPago")
                        .HasColumnType("datetime2");

                    b.Property<string>("Entidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LimiteCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SaldoInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoCuentaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("IdCuenta");

                    b.HasIndex("TipoCuentaId");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("Proyecto.Models.CuentaEntidadEmisora", b =>
                {
                    b.Property<int>("IdCuentaEntidadEmisora")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<int>("EntidadEmidoraId")
                        .HasColumnType("int");

                    b.HasKey("IdCuentaEntidadEmisora");

                    b.HasIndex("CuentaId");

                    b.HasIndex("EntidadEmidoraId");

                    b.ToTable("CuentaEntidadEmisoras");
                });

            modelBuilder.Entity("Proyecto.Models.CuentaMetodoPago", b =>
                {
                    b.Property<int>("IdCuentaMetodoPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<int>("MetodoPagoId")
                        .HasColumnType("int");

                    b.HasKey("IdCuentaMetodoPago");

                    b.HasIndex("CuentaId");

                    b.HasIndex("MetodoPagoId");

                    b.ToTable("CuentaMetodoPagos");
                });

            modelBuilder.Entity("Proyecto.Models.EntidadEmisora", b =>
                {
                    b.Property<int>("IdEntidadEmisora")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntidadEmisora");

                    b.ToTable("EntidadEmisora");
                });

            modelBuilder.Entity("Proyecto.Models.Gasto", b =>
                {
                    b.Property<int>("IdGasto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGasto");

                    b.HasIndex("CuentaId");

                    b.ToTable("Gasto");
                });

            modelBuilder.Entity("Proyecto.Models.MetodoPago", b =>
                {
                    b.Property<int>("IdMetodoPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMetodoPago");

                    b.ToTable("MetodoPago");
                });

            modelBuilder.Entity("Proyecto.Models.TipoCuenta", b =>
                {
                    b.Property<int>("IdTipoCuenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoCuenta");

                    b.ToTable("TipoCuenta");
                });

            modelBuilder.Entity("Proyecto.Models.Transferencia", b =>
                {
                    b.Property<int>("IdTransferencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaDestinoId")
                        .HasColumnType("int");

                    b.Property<int?>("CuentaIdCuenta")
                        .HasColumnType("int");

                    b.Property<int>("CuentaOrigenId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdTransferencia");

                    b.HasIndex("CuentaDestinoId");

                    b.HasIndex("CuentaIdCuenta");

                    b.HasIndex("CuentaOrigenId");

                    b.ToTable("Transferencias");
                });

            modelBuilder.Entity("Proyecto.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Proyecto.Models.Cuenta", b =>
                {
                    b.HasOne("Proyecto.Models.TipoCuenta", "TipoCuenta")
                        .WithMany("Cuentas")
                        .HasForeignKey("TipoCuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Models.CuentaEntidadEmisora", b =>
                {
                    b.HasOne("Proyecto.Models.Cuenta", "Cuenta")
                        .WithMany("CuentaEntidadEmisora")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Models.EntidadEmisora", "EntidadEmidora")
                        .WithMany("CuentaEntidadEmisora")
                        .HasForeignKey("EntidadEmidoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Models.CuentaMetodoPago", b =>
                {
                    b.HasOne("Proyecto.Models.Cuenta", "Cuenta")
                        .WithMany("CuentaMetodoPago")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Models.MetodoPago", "MetodoPago")
                        .WithMany("CuentaMetodoPago")
                        .HasForeignKey("MetodoPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Models.Gasto", b =>
                {
                    b.HasOne("Proyecto.Models.Cuenta", "Cuenta")
                        .WithMany("Gastos")
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Proyecto.Models.Transferencia", b =>
                {
                    b.HasOne("Proyecto.Models.Cuenta", "CuentaDestino")
                        .WithMany("TransferenciasComoDestino")
                        .HasForeignKey("CuentaDestinoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Proyecto.Models.Cuenta", null)
                        .WithMany("Transferencias")
                        .HasForeignKey("CuentaIdCuenta");

                    b.HasOne("Proyecto.Models.Cuenta", "CuentaOrigen")
                        .WithMany("TransferenciasComoOrigen")
                        .HasForeignKey("CuentaOrigenId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
