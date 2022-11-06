using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietTracker.Data.Migrations
{
    public partial class AddSustenanceAndTargets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sustenance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalorieAmount = table.Column<int>(type: "int", nullable: false),
                    FatAmount = table.Column<double>(type: "float", nullable: false),
                    CarbAmount = table.Column<double>(type: "float", nullable: false),
                    ProteinAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sustenance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalorieTarget = table.Column<int>(type: "int", nullable: false),
                    FatTarget = table.Column<double>(type: "float", nullable: false),
                    CarbTarget = table.Column<double>(type: "float", nullable: false),
                    ProteinTarget = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Targets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubsistenceTarget",
                columns: table => new
                {
                    SustenanceId = table.Column<int>(type: "int", nullable: false),
                    TargetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubsistenceTarget", x => new { x.SustenanceId, x.TargetsId });
                    table.ForeignKey(
                        name: "FK_SubsistenceTarget_Sustenance_SustenanceId",
                        column: x => x.SustenanceId,
                        principalTable: "Sustenance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubsistenceTarget_Targets_TargetsId",
                        column: x => x.TargetsId,
                        principalTable: "Targets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubsistenceTarget_TargetsId",
                table: "SubsistenceTarget",
                column: "TargetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Targets_UserId",
                table: "Targets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubsistenceTarget");

            migrationBuilder.DropTable(
                name: "Sustenance");

            migrationBuilder.DropTable(
                name: "Targets");
        }
    }
}
