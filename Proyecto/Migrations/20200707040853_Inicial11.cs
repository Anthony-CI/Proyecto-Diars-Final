using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class Inicial11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuentaIdCuenta",
                table: "Transferencias",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transferencias_CuentaIdCuenta",
                table: "Transferencias",
                column: "CuentaIdCuenta");

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Cuenta_CuentaIdCuenta",
                table: "Transferencias",
                column: "CuentaIdCuenta",
                principalTable: "Cuenta",
                principalColumn: "IdCuenta",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Cuenta_CuentaIdCuenta",
                table: "Transferencias");

            migrationBuilder.DropIndex(
                name: "IX_Transferencias_CuentaIdCuenta",
                table: "Transferencias");

            migrationBuilder.DropColumn(
                name: "CuentaIdCuenta",
                table: "Transferencias");
        }
    }
}
