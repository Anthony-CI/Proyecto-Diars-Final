using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class Inicial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos");

            migrationBuilder.DropIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos");

            migrationBuilder.DropColumn(
                name: "MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos");

            migrationBuilder.AddColumn<int>(
                name: "MetodoPagoId",
                table: "CuentaMetodoPagos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoId",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoId",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoId",
                principalTable: "MetodoPago",
                principalColumn: "IdMetodoPago",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoId",
                table: "CuentaMetodoPagos");

            migrationBuilder.DropIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoId",
                table: "CuentaMetodoPagos");

            migrationBuilder.DropColumn(
                name: "MetodoPagoId",
                table: "CuentaMetodoPagos");

            migrationBuilder.AddColumn<int>(
                name: "MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CuentaMetodoPagos_MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoIdMetodoPago");

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaMetodoPagos_MetodoPago_MetodoPagoIdMetodoPago",
                table: "CuentaMetodoPagos",
                column: "MetodoPagoIdMetodoPago",
                principalTable: "MetodoPago",
                principalColumn: "IdMetodoPago",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
