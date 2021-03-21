using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class AlteraTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "tabUser",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "tabUser",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "tabUser");

            migrationBuilder.DropColumn(
                name: "name",
                table: "tabUser");
        }
    }
}