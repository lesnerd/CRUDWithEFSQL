using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDWithEFSQL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    StudentName = table.Column<string>(type: "varchar(150)", nullable: false),
                    RollNo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Class = table.Column<string>(type: "varchar(50)", nullable: false),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
