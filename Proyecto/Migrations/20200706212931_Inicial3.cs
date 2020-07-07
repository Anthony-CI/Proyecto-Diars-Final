using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_EntidadEmidora_EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_MetodoPago_MetodoPagoIdMetodoPago",
                table: "Cuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_CuentaEntidadEmisoras_EntidadEmidora_EntidadEmidoraId",
                table: "CuentaEntidadEmisoras");

            migrationBuilder.DropTable(
                name: "EntidadEmidora");

            migrationBuilder.DropIndex(
                name: "IX_Cuenta_EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta");

            migrationBuilder.DropIndex(
                name: "IX_Cuenta_MetodoPagoIdMetodoPago",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "MetodoPagoIdMetodoPago",
                table: "Cuenta");

            migrationBuilder.CreateTable(
                name: "CuentaMetodoPagos",
                columns: table => new
                {
                    IdCuentaMetodoPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaId = table.Column<int>(nullable: false),
                    MetodoPagoIdMetodoPago = table.Column<int>(nullable: true)
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
                        name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoIdMetodoPago",
                        column: x => x.MetodoPagoIdMetodoPago,
                        principalTable: "MetodoPago",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CuentaMetodoPagos_CuentaId",
                table: "CuentaMetodoPagos",
                column: "CuentaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoIdMetodoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaEntidadEmisoras_EntidadEmisora_EntidadEmidoraId",
                table: "CuentaEntidadEmisoras",
                column: "EntidadEmidoraId",
                principalTable: "EntidadEmisora",
                principalColumn: "IdEntidadEmisora",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentaEntidadEmisoras_EntidadEmisora_EntidadEmidoraId",
                table: "CuentaEntidadEmisoras");

            migrationBuilder.DropTable(
                name: "CuentaMetodoPagos");

            migrationBuilder.DropTable(
                name: "EntidadEmisora");

            migrationBuilder.AddColumn<int>(
                name: "EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MetodoPagoIdMetodoPago",
                table: "Cuenta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EntidadEmidora",
                columns: table => new
                {
                    IdEntidadEmidora = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadEmidora", x => x.IdEntidadEmidora);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta",
                column: "EntidadEmidoraIdEntidadEmidora");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_MetodoPagoIdMetodoPago",
                table: "Cuenta",
                column: "MetodoPagoIdMetodoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_EntidadEmidora_EntidadEmidoraIdEntidadEmidora",
                table: "Cuenta",
                column: "EntidadEmidoraIdEntidadEmidora",
                principalTable: "EntidadEmidora",
                principalColumn: "IdEntidadEmidora",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_MetodoPago_MetodoPagoIdMetodoPago",
                table: "Cuenta",
                column: "MetodoPagoIdMetodoPago",
                principalTable: "MetodoPago",
                principalColumn: "IdMetodoPago",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaEntidadEmisoras_EntidadEmidora_EntidadEmidoraId",
                table: "CuentaEntidadEmisoras",
                column: "EntidadEmidoraId",
                principalTable: "EntidadEmidora",
                principalColumn: "IdEntidadEmidora",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
