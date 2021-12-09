using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Sql.Migrations
{
    public partial class A3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LaptopCategory",
                columns: table => new
                {
                    LaptopCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LaptopCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopCategory", x => x.LaptopCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    LaptopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LaptopName = table.Column<string>(type: "varchar(50)", nullable: true),
                    LaptopDescription = table.Column<string>(type: "varchar(500)", nullable: true),
                    LaptopPrice = table.Column<int>(nullable: false),
                    LaptopCategoryId = table.Column<int>(nullable: true),
                    LaptopInsertTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.LaptopID);
                    table.ForeignKey(
                        name: "FK_Laptops_LaptopCategory_LaptopCategoryId",
                        column: x => x.LaptopCategoryId,
                        principalTable: "LaptopCategory",
                        principalColumn: "LaptopCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaptopMedia",
                columns: table => new
                {
                    LaptopMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LaptopPicPath = table.Column<string>(nullable: true),
                    LaptopID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopMedia", x => x.LaptopMediaId);
                    table.ForeignKey(
                        name: "FK_LaptopMedia_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LaptopMedia_LaptopID",
                table: "LaptopMedia",
                column: "LaptopID");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_LaptopCategoryId",
                table: "Laptops",
                column: "LaptopCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LaptopMedia");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "LaptopCategory");
        }
    }
}
