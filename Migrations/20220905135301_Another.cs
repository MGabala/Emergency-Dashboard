using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmergencyDashboard.Migrations
{
    public partial class Another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeofReport",
                table: "Reports",
                newName: "Time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Reports",
                newName: "TimeofReport");
        }
    }
}
