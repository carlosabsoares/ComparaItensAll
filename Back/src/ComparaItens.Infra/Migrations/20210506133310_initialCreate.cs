using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabCategory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabCharacteristic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCharacteristic", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabCharacteristicKey",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    key = table.Column<string>(type: "varchar(60)", nullable: false),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCharacteristicKey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabManufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabManufacturer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(type: "varchar(50)", nullable: false),
                    password = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    role = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabCharacteristicDescription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<int>(type: "int(11)", nullable: false),
                    characteristicId = table.Column<int>(type: "int(11)", nullable: false),
                    characteristicKeyId = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCharacteristicDescription", x => x.id);
                    table.ForeignKey(
                        name: "FK_tabCharacteristicDescription_tabCharacteristic_characteristi~",
                        column: x => x.characteristicId,
                        principalTable: "tabCharacteristic",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tabCharacteristicDescription_tabCharacteristicKey_characteri~",
                        column: x => x.characteristicKeyId,
                        principalTable: "tabCharacteristicKey",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tabProdut",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "varchar(150)", nullable: false),
                    manufecturerId = table.Column<int>(type: "int(11)", nullable: false),
                    model = table.Column<string>(type: "varchar(150)", nullable: true),
                    categoryId = table.Column<int>(type: "int(11)", nullable: false),
                    yearOfManufacture = table.Column<int>(type: "int(11)", nullable: false),
                    image = table.Column<string>(type: "varchar(250)", nullable: true),
                    folder = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabProdut", x => x.id);
                    table.ForeignKey(
                        name: "FK_tabProdut_tabCategory_categoryId",
                        column: x => x.categoryId,
                        principalTable: "tabCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tabProdut_tabManufacturer_manufecturerId",
                        column: x => x.manufecturerId,
                        principalTable: "tabManufacturer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabCategory_id",
                table: "tabCategory",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristic_id",
                table: "tabCharacteristic",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicDescription_characteristicId",
                table: "tabCharacteristicDescription",
                column: "characteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicDescription_characteristicKeyId",
                table: "tabCharacteristicDescription",
                column: "characteristicKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicDescription_id",
                table: "tabCharacteristicDescription",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicDescription_productId",
                table: "tabCharacteristicDescription",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_tabCharacteristicKey_id",
                table: "tabCharacteristicKey",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabManufacturer_id",
                table: "tabManufacturer",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabProdut_categoryId",
                table: "tabProdut",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tabProdut_id",
                table: "tabProdut",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_tabProdut_manufecturerId",
                table: "tabProdut",
                column: "manufecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_tabUser_id",
                table: "tabUser",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabCharacteristicDescription");

            migrationBuilder.DropTable(
                name: "tabProdut");

            migrationBuilder.DropTable(
                name: "tabUser");

            migrationBuilder.DropTable(
                name: "tabCharacteristic");

            migrationBuilder.DropTable(
                name: "tabCharacteristicKey");

            migrationBuilder.DropTable(
                name: "tabCategory");

            migrationBuilder.DropTable(
                name: "tabManufacturer");
        }
    }
}