using Microsoft.EntityFrameworkCore.Migrations;

namespace ComparaItens.Infra.Migrations
{
    public partial class initialSqlServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabCategory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabCategory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tabManufacturer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    idUser = table.Column<string>(type: "varchar(50)", nullable: false),
                    login = table.Column<string>(type: "varchar(50)", nullable: false),
                    password = table.Column<string>(type: "varchar(50)", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    role = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabUser", x => x.idUser);
                });

            migrationBuilder.CreateTable(
                name: "tabProdut",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "tabSpecificationItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int(11)", nullable: false),
                    description = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabSpecificationItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_tabSpecificationItems_tabProdut_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tabProdut",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabCategory_id",
                table: "tabCategory",
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
                name: "IX_tabSpecificationItems_description",
                table: "tabSpecificationItems",
                column: "description");

            migrationBuilder.CreateIndex(
                name: "IX_tabSpecificationItems_ProductId",
                table: "tabSpecificationItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tabUser_idUser",
                table: "tabUser",
                column: "idUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabSpecificationItems");

            migrationBuilder.DropTable(
                name: "tabUser");

            migrationBuilder.DropTable(
                name: "tabProdut");

            migrationBuilder.DropTable(
                name: "tabCategory");

            migrationBuilder.DropTable(
                name: "tabManufacturer");
        }
    }
}
