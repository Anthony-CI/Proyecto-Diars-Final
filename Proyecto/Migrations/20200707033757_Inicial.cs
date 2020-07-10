using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadEmisora",
                columns: table => new
                {
                    IdEntidadEmisora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadEmisora", x => x.IdEntidadEmisora);
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
                    SaldoInicial = table.Column<decimal>(nullable: false),
                    Concepto = table.Column<string>(nullable: true),
                    Entidad = table.Column<string>(nullable: true),
                    NumeroTarjeta = table.Column<string>(nullable: true),
                    DiaCierre = table.Column<DateTime>(nullable: false),
                    DiaPago = table.Column<DateTime>(nullable: false),
                    LimiteCredito = table.Column<decimal>(nullable: false),
                    TipoCuentaId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.IdCuenta);
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
                        name: "FK_CuentaEntidadEmisoras_EntidadEmisora_EntidadEmidoraId",
                        column: x => x.EntidadEmidoraId,
                        principalTable: "EntidadEmisora",
                        principalColumn: "IdEntidadEmisora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuentaMetodoPagos",
                columns: table => new
                {
                    IdCuentaMetodoPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetodoPagoId = table.Column<int>(nullable: false),
                    CuentaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaMetodoPagos", x => x.IdCuentaMetodoPago);
                    table.ForeignKey(
                        name: "FK_CuentaMetodoPagos_Cuenta_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoId",
                        column: x => x.MetodoPagoId,
                        principalTable: "MetodoPago",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gasto",
                columns: table => new
                {
                    IdGasto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Transferencias",
                columns: table => new
                {
                    IdTransferencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaOrigenId = table.Column<int>(nullable: false),
                    CuentaDestinoId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencias", x => x.IdTransferencia);
                    table.ForeignKey(
                        name: "FK_Transferencias_Cuenta_CuentaDestinoId",
                        column: x => x.CuentaDestinoId,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta");
                    table.ForeignKey(
                        name: "FK_Transferencias_Cuenta_CuentaOrigenId",
                        column: x => x.CuentaOrigenId,
                        principalTable: "Cuenta",
                        principalColumn: "IdCuenta");
                });

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
                name: "IX_CuentaMetodoPagos_CuentaId",
                table: "CuentaMetodoPagos",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoId",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gasto_CuentaId",
                table: "Gasto",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_CuentaDestinoId",
                table: "Transferencias",
                column: "CuentaDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_CuentaOrigenId",
                table: "Transferencias",
                column: "CuentaOrigenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaEntidadEmisoras");

            migrationBuilder.DropTable(
                name: "CuentaMetodoPagos");

            migrationBuilder.DropTable(
                name: "Gasto");

            migrationBuilder.DropTable(
                name: "Transferencias");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "EntidadEmisora");

            migrationBuilder.DropTable(
                name: "MetodoPago");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "TipoCuenta");
        }
    }
}
