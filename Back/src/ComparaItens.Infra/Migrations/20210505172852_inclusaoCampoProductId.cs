using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class inclusaoCampoProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idUser",
                table: "tabUser",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_tabUser_idUser",
                table: "tabUser",
                newName: "IX_tabUser_id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "tabUser",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "produtoId",
                table: "tabCharacteristicDescription",
                type: "int(11)",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "produtoId",
                table: "tabCharacteristicDescription");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tabUser",
                newName: "idUser");

            migrationBuilder.RenameIndex(
                name: "IX_tabUser_id",
                table: "tabUser",
                newName: "IX_tabUser_idUser");

            migrationBuilder.AlterColumn<string>(
                name: "idUser",
                table: "tabUser",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}