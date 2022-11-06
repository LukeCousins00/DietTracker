using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DietTracker.Data.Migrations
{
    public partial class AddExplicitSubsistenceTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubsistenceTarget_Sustenance_SustenanceId",
                table: "SubsistenceTarget");

            migrationBuilder.DropForeignKey(
                name: "FK_SubsistenceTarget_Targets_TargetsId",
                table: "SubsistenceTarget");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubsistenceTarget",
                table: "SubsistenceTarget");

            migrationBuilder.DropIndex(
                name: "IX_SubsistenceTarget_TargetsId",
                table: "SubsistenceTarget");

            migrationBuilder.RenameColumn(
                name: "TargetsId",
                table: "SubsistenceTarget",
                newName: "PortionSize");

            migrationBuilder.RenameColumn(
                name: "SustenanceId",
                table: "SubsistenceTarget",
                newName: "MealPeriod");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Sustenance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DefaultPortionSize",
                table: "Sustenance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnitOfMeasure",
                table: "Sustenance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubsistenceId",
                table: "SubsistenceTarget",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "SubsistenceTarget",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubsistenceTarget",
                table: "SubsistenceTarget",
                columns: new[] { "SubsistenceId", "TargetId" });

            migrationBuilder.CreateIndex(
                name: "IX_SubsistenceTarget_TargetId",
                table: "SubsistenceTarget",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubsistenceTarget_Sustenance_SubsistenceId",
                table: "SubsistenceTarget",
                column: "SubsistenceId",
                principalTable: "Sustenance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubsistenceTarget_Targets_TargetId",
                table: "SubsistenceTarget",
                column: "TargetId",
                principalTable: "Targets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubsistenceTarget_Sustenance_SubsistenceId",
                table: "SubsistenceTarget");

            migrationBuilder.DropForeignKey(
                name: "FK_SubsistenceTarget_Targets_TargetId",
                table: "SubsistenceTarget");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubsistenceTarget",
                table: "SubsistenceTarget");

            migrationBuilder.DropIndex(
                name: "IX_SubsistenceTarget_TargetId",
                table: "SubsistenceTarget");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Sustenance");

            migrationBuilder.DropColumn(
                name: "DefaultPortionSize",
                table: "Sustenance");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasure",
                table: "Sustenance");

            migrationBuilder.DropColumn(
                name: "SubsistenceId",
                table: "SubsistenceTarget");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "SubsistenceTarget");

            migrationBuilder.RenameColumn(
                name: "PortionSize",
                table: "SubsistenceTarget",
                newName: "TargetsId");

            migrationBuilder.RenameColumn(
                name: "MealPeriod",
                table: "SubsistenceTarget",
                newName: "SustenanceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubsistenceTarget",
                table: "SubsistenceTarget",
                columns: new[] { "SustenanceId", "TargetsId" });

            migrationBuilder.CreateIndex(
                name: "IX_SubsistenceTarget_TargetsId",
                table: "SubsistenceTarget",
                column: "TargetsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubsistenceTarget_Sustenance_SustenanceId",
                table: "SubsistenceTarget",
                column: "SustenanceId",
                principalTable: "Sustenance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubsistenceTarget_Targets_TargetsId",
                table: "SubsistenceTarget",
                column: "TargetsId",
                principalTable: "Targets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
