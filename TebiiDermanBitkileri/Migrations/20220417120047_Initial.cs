using Microsoft.EntityFrameworkCore.Migrations;

namespace TebiiDermanBitkileri.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BitkiNovleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitkiNovleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Simptomlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simptomlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vitaminler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitaminler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xestelikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xestelikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bitkiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sekil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BitkiNovuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitkiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bitkiler_BitkiNovleri_BitkiNovuId",
                        column: x => x.BitkiNovuId,
                        principalTable: "BitkiNovleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XestelikSimptom",
                columns: table => new
                {
                    XestelikId = table.Column<int>(type: "int", nullable: false),
                    SimptomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XestelikSimptom", x => new { x.XestelikId, x.SimptomId });
                    table.ForeignKey(
                        name: "FK_XestelikSimptom_Simptomlar_SimptomId",
                        column: x => x.SimptomId,
                        principalTable: "Simptomlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XestelikSimptom_Xestelikler_XestelikId",
                        column: x => x.XestelikId,
                        principalTable: "Xestelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BitkiVitamin",
                columns: table => new
                {
                    BitkiId = table.Column<int>(type: "int", nullable: false),
                    VitaminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitkiVitamin", x => new { x.BitkiId, x.VitaminId });
                    table.ForeignKey(
                        name: "FK_BitkiVitamin_Bitkiler_BitkiId",
                        column: x => x.BitkiId,
                        principalTable: "Bitkiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BitkiVitamin_Vitaminler_VitaminId",
                        column: x => x.VitaminId,
                        principalTable: "Vitaminler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BitkiXestelik",
                columns: table => new
                {
                    BitkiId = table.Column<int>(type: "int", nullable: false),
                    XestelikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BitkiXestelik", x => new { x.BitkiId, x.XestelikId });
                    table.ForeignKey(
                        name: "FK_BitkiXestelik_Bitkiler_BitkiId",
                        column: x => x.BitkiId,
                        principalTable: "Bitkiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BitkiXestelik_Xestelikler_XestelikId",
                        column: x => x.XestelikId,
                        principalTable: "Xestelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bitkiler_BitkiNovuId",
                table: "Bitkiler",
                column: "BitkiNovuId");

            migrationBuilder.CreateIndex(
                name: "IX_BitkiVitamin_VitaminId",
                table: "BitkiVitamin",
                column: "VitaminId");

            migrationBuilder.CreateIndex(
                name: "IX_BitkiXestelik_XestelikId",
                table: "BitkiXestelik",
                column: "XestelikId");

            migrationBuilder.CreateIndex(
                name: "IX_XestelikSimptom_SimptomId",
                table: "XestelikSimptom",
                column: "SimptomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BitkiVitamin");

            migrationBuilder.DropTable(
                name: "BitkiXestelik");

            migrationBuilder.DropTable(
                name: "XestelikSimptom");

            migrationBuilder.DropTable(
                name: "Vitaminler");

            migrationBuilder.DropTable(
                name: "Bitkiler");

            migrationBuilder.DropTable(
                name: "Simptomlar");

            migrationBuilder.DropTable(
                name: "Xestelikler");

            migrationBuilder.DropTable(
                name: "BitkiNovleri");
        }
    }
}
