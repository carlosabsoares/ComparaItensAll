using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class tabelaRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabSpecificationItems_tabProdut_ProductId",
                table: "tabSpecificationItems");

            migrationBuilder.DropIndex(
                name: "IX_tabSpecificationItems_ProductId",
                table: "tabSpecificationItems");

            migrationBuilder.DropIndex(
                name: "IX_tabCharacteristicDescription_productId",
                table: "tabCharacteristicDescription");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "tabCharacteristicDescription");

            migrationBuilder.CreateTable(
                name: "tabSpecificationCharacteristcRel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabSpecificationCharacteristcRel", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabSpecificationCharacteristcRel_id",
                table: "tabSpecificationCharacteristcRel",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabSpecificationCharacteristcRel_id1",
                table: "tabSpecificationCharacteristcRel",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabSpecificationCharacteristcRel");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "tabCharacteristicDescription",
                type: "int(11)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tabSpecificationItems_ProductId",
                table: "tabSpecificationItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicDescription_productId",
                table: "tabCharacteristicDescription",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_tabSpecificationItems_tabProdut_ProductId",
                table: "tabSpecificationItems",
                column: "ProductId",
                principalTable: "tabProdut",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
