using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Sql.Migrations
{
    public partial class A5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellphoneCategory",
                columns: table => new
                {
                    CellphoneCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CellphoneCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellphoneCategory", x => x.CellphoneCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cellphones",
                columns: table => new
                {
                    CellphoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CellphoneName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CellphoneDescription = table.Column<string>(type: "varchar(500)", nullable: true),
                    CellphonePrice = table.Column<int>(nullable: false),
                    CellphoneCategoryId = table.Column<int>(nullable: true),
                    CellphoneInsertTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellphones", x => x.CellphoneID);
                    table.ForeignKey(
                        name: "FK_Cellphones_CellphoneCategory_CellphoneCategoryId",
                        column: x => x.CellphoneCategoryId,
                        principalTable: "CellphoneCategory",
                        principalColumn: "CellphoneCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CellphoneMedia",
                columns: table => new
                {
                    CellphoneMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CellphonePicPath = table.Column<string>(nullable: true),
                    CellphoneID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellphoneMedia", x => x.CellphoneMediaId);
                    table.ForeignKey(
                        name: "FK_CellphoneMedia_Cellphones_CellphoneID",
                        column: x => x.CellphoneID,
                        principalTable: "Cellphones",
                        principalColumn: "CellphoneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CellphoneMedia_CellphoneID",
                table: "CellphoneMedia",
                column: "CellphoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Cellphones_CellphoneCategoryId",
                table: "Cellphones",
                column: "CellphoneCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellphoneMedia");

            migrationBuilder.DropTable(
                name: "Cellphones");

            migrationBuilder.DropTable(
                name: "CellphoneCategory");
        }
    }
}
