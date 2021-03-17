using Microsoft.EntityFrameworkCore.Migrations;

namespace _413_Project_one.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: false),
                    GroupSize = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupContactEmailAddress = table.Column<string>(type: "TEXT", nullable: false),
                    GroupContactPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    GroupAppointmentID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
