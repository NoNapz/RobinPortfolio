using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    Created_At = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Thumbnail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogId);
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogId", "Content", "Created_At", "Thumbnail", "Title", "Updated_At" },
                values: new object[] { 1, "Descriprion for test data 1", new DateTime(2021, 12, 19, 7, 38, 4, 919, DateTimeKind.Local).AddTicks(5373), "./images/placeholder.jpg", "Test Data 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogId", "Content", "Created_At", "Thumbnail", "Title", "Updated_At" },
                values: new object[] { 2, "Descriprion for test data 2", new DateTime(2021, 12, 19, 7, 38, 4, 919, DateTimeKind.Local).AddTicks(5410), "./images/placeholder.jpg", "Test Data 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "BlogId", "Content", "Created_At", "Thumbnail", "Title", "Updated_At" },
                values: new object[] { 3, "Descriprion for test data 3", new DateTime(2021, 12, 19, 7, 38, 4, 919, DateTimeKind.Local).AddTicks(5413), "./images/placeholder.jpg", "Test Data 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
