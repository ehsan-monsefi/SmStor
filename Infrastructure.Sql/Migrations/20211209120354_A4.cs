using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Sql.Migrations
{
    public partial class A4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CameraCategory",
                columns: table => new
                {
                    CameraCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CameraCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraCategory", x => x.CameraCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CameraName = table.Column<string>(type: "varchar(50)", nullable: true),
                    CameraDescription = table.Column<string>(type: "varchar(500)", nullable: true),
                    CameraPrice = table.Column<int>(nullable: false),
                    CameraCategoryId = table.Column<int>(nullable: true),
                    CameraInsertTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraID);
                    table.ForeignKey(
                        name: "FK_Cameras_CameraCategory_CameraCategoryId",
                        column: x => x.CameraCategoryId,
                        principalTable: "CameraCategory",
                        principalColumn: "CameraCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CameraMedia",
                columns: table => new
                {
                    CameraMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CameraPicPath = table.Column<string>(nullable: true),
                    CameraID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraMedia", x => x.CameraMediaId);
                    table.ForeignKey(
                        name: "FK_CameraMedia_Cameras_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CameraMedia_CameraID",
                table: "CameraMedia",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_CameraCategoryId",
                table: "Cameras",
                column: "CameraCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraMedia");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "CameraCategory");
        }
    }
}
