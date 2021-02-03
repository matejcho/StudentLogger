using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLogger.Migrations
{
    public partial class AddingEnrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnrolledIn",
                columns: table => new
                {
                    EnrolledInID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolledIn", x => x.EnrolledInID);
                    table.ForeignKey(
                        name: "FK_EnrolledIn_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrolledIn_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledIn_CourseID",
                table: "EnrolledIn",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledIn_StudentID",
                table: "EnrolledIn",
                column: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnrolledIn");
        }
    }
}
