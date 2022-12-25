using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDemoApi.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttendRegBoys",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "AttendRegGirls",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "HeadCountBoys",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "HeadCountGirls",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "NewEnrollBoys",
                table: "StudentEnrollment");

            migrationBuilder.DropColumn(
                name: "NewEnrolltGirls",
                table: "StudentEnrollment");

            migrationBuilder.CreateTable(
                name: "StudentEnrollmentDetails",
                columns: table => new
                {
                    StudentEnrollmentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrolltGirls = table.Column<short>(type: "smallint", nullable: false),
                    NewEnrollBoys = table.Column<short>(type: "smallint", nullable: false),
                    AttendRegGirls = table.Column<short>(type: "smallint", nullable: false),
                    AttendRegBoys = table.Column<short>(type: "smallint", nullable: false),
                    HeadCountGirls = table.Column<short>(type: "smallint", nullable: false),
                    HeadCountBoys = table.Column<short>(type: "smallint", nullable: false),
                    StudentEnrollmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollmentDetails", x => x.StudentEnrollmentDetailId);
                    table.ForeignKey(
                        name: "FK_StudentEnrollmentDetails_StudentEnrollment_StudentEnrollmentId",
                        column: x => x.StudentEnrollmentId,
                        principalTable: "StudentEnrollment",
                        principalColumn: "StudentEnrollmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollmentDetails_StudentEnrollmentId",
                table: "StudentEnrollmentDetails",
                column: "StudentEnrollmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEnrollmentDetails");

            migrationBuilder.AddColumn<short>(
                name: "AttendRegBoys",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "AttendRegGirls",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ClassId",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "HeadCountBoys",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "HeadCountGirls",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NewEnrollBoys",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NewEnrolltGirls",
                table: "StudentEnrollment",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
