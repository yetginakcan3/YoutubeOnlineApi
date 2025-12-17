using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineEdu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_courseVideo_entity_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseRegisters_AspNetUsers_AppUserId",
                table: "courseRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_courseRegisters_Courses_CourseId",
                table: "courseRegisters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseRegisters",
                table: "courseRegisters");

            migrationBuilder.RenameTable(
                name: "courseRegisters",
                newName: "CourseRegisters");

            migrationBuilder.RenameIndex(
                name: "IX_courseRegisters_CourseId",
                table: "CourseRegisters",
                newName: "IX_CourseRegisters_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_courseRegisters_AppUserId",
                table: "CourseRegisters",
                newName: "IX_CourseRegisters_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRegisters",
                table: "CourseRegisters",
                column: "CourseRegisterId");

            migrationBuilder.CreateTable(
                name: "CourseVideos",
                columns: table => new
                {
                    CourseVideoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    VideoNumber = table.Column<int>(type: "int", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseVideos", x => x.CourseVideoId);
                    table.ForeignKey(
                        name: "FK_CourseVideos_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseVideos_CourseId",
                table: "CourseVideos",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegisters_AspNetUsers_AppUserId",
                table: "CourseRegisters",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRegisters_Courses_CourseId",
                table: "CourseRegisters",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegisters_AspNetUsers_AppUserId",
                table: "CourseRegisters");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRegisters_Courses_CourseId",
                table: "CourseRegisters");

            migrationBuilder.DropTable(
                name: "CourseVideos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRegisters",
                table: "CourseRegisters");

            migrationBuilder.RenameTable(
                name: "CourseRegisters",
                newName: "courseRegisters");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegisters_CourseId",
                table: "courseRegisters",
                newName: "IX_courseRegisters_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseRegisters_AppUserId",
                table: "courseRegisters",
                newName: "IX_courseRegisters_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseRegisters",
                table: "courseRegisters",
                column: "CourseRegisterId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseRegisters_AspNetUsers_AppUserId",
                table: "courseRegisters",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courseRegisters_Courses_CourseId",
                table: "courseRegisters",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
