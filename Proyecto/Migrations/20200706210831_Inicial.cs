using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadEmidora",
                columns: table => new
                {
                    IdEntidadEmidora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadEmidora", x => x.IdEntidadEmidora);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPago",
                columns: table => new
                {
                    IdMetodoPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPago", x => x.IdMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "TipoCuenta",
                columns: table => new
                {
                    IdTipoCuenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCuenta", x => x.IdTipoCuenta);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    SaldoInicial = table.Column<double>(nullable: false),
                    Concepto = table.Column<string>(nullable: true),
                    Entidad = table.Column<string>(nullable: true),
                    NumeroTarjeta = table.Column<int>(nullable: false),
                    DiaCierre = table.Column<DateTime>(nullable: false),
                    DiaPago = table.Column<DateTime>(nullable: false),
                    LimiteCredito = table.Column<double>(nullable: false),
                    TipoCuentaId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    EntidadEmidoraIdEntidadEmidora = table.Column<int>(nullable: true),
                    MetodoPagoIdMetodoPago = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.IdCuenta);
                    table.ForeignKey(
                        name: "FK_Cuenta_EntidadEmidora_EntidadEmidoraIdEntidadEmidora",
                        column: x => x.EntidadEmidoraIdEntidadEmidora,
                        principalTable: "EntidadEmidora",
                        principalColumn: "IdEntidadEmidora",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuenta_MetodoPago_MetodoPagoIdMetodoPago",
                        column: x => x.MetodoPagoIdMetodoPago,
                        principalTable: "MetodoPago",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cuenta_TipoCuenta_TipoCuentaId",
                        column: x => x.TipoCuentaId,
                        principalTable: "TipoCuenta",
                        principalColumn: "IdTipoCuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentaEntidadEmisoras",
                columns: table => new
                {
                    IdCuentaEntidadEmisora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntidadEmidoraId = table.Column<int>(nullable: false),
                    CuentaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaEntidadEmisoras", x => x.IdCuentaEntidadEmisora);
                    table.ForeignKey(
                        name: "FK_CuentaEntidadEmisoras_Cuenta_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuentaEntidadEmisoras_EntidadEmidora_EntidadEmidoraId",
                        column: x => x.EntidadEmidoraId,
                        principalTable: "EntidadEmidora",
                        principalColumn: "IdEntidadEmidora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    IdGasto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Monto = table.Column<int>(nullable: false),
                    CuentaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasto", x => x.IdGasto);
                    table.ForeignKey(
                        name: "FK_Gasto_Cuenta_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta",
                column: "EntidadEmidoraIdEntidadEmidora");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_MetodoPagoIdMetodoPago",
                table: "Cuenta",
                column: "MetodoPagoIdMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_TipoCuentaId",
                table: "Cuenta",
                column: "TipoCuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaEntidadEmisoras_CuentaId",
                table: "CuentaEntidadEmisoras",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaEntidadEmisoras_EntidadEmidoraId",
                table: "CuentaEntidadEmisoras",
                column: "EntidadEmidoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_CuentaId",
                table: "Gasto",
                column: "CuentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaEntidadEmisoras");

            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "EntidadEmidora");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "TipoCuenta");
        }
    }
}
