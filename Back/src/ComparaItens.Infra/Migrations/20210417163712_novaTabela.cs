using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class novaTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabSpecificationCharacteristcRel_tabCharacteristicDescriptio~",
                table: "tabSpecificationCharacteristcRel");

            migrationBuilder.CreateTable(
                name: "tabProdutItem",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int(11)", nullable: false),
                    characteristicDescriptionId = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabProdutItem", x => new { x.productId, x.characteristicDescriptionId });
                    table.ForeignKey(
                        name: "FK_tabProdutItem_tabCharacteristicDescription_characteristicDes~",
                        column: x => x.characteristicDescriptionId,
                        principalTable: "tabCharacteristicDescription",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tabProdutItem_tabProdut_productId",
                        column: x => x.productId,
                        principalTable: "tabProdut",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabProdutItem_characteristicDescriptionId",
                table: "tabProdutItem",
                column: "characteristicDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_tabProdutItem_productId",
                table: "tabProdutItem",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabProdutItem");

            migrationBuilder.AddForeignKey(
                name: "FK_tabSpecificationCharacteristcRel_tabCharacteristicDescriptio~",
                table: "tabSpecificationCharacteristcRel",
                column: "characteristicDescriptionId",
                principalTable: "tabCharacteristicDescription",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}