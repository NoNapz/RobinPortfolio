using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class AddedPostModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    Thumbnail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Content", "Thumbnail", "Title" },
                values: new object[] { 1001, "Descriprion for test data one", "./uploads/placeholder.jpg", "Test Data One" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Content", "Thumbnail", "Title" },
                values: new object[] { 1002, "Descriprion for test data two", "./uploads/placeholder.jpg", "Test Data Two" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Content", "Thumbnail", "Title" },
                values: new object[] { 1003, "Descriprion for test data three", "./uploads/placeholder.jpg", "Test Data Three" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
