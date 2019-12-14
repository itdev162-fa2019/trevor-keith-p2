using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    replyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    posterId = table.Column<int>(nullable: false),
                    replyContent = table.Column<string>(nullable: true),
                    creationDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.replyId);
                });

            migrationBuilder.CreateTable(
                name: "threads",
                columns: table => new
                {
                    threadId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    posterId = table.Column<int>(nullable: false),
                    postContent = table.Column<string>(nullable: true),
                    creationDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_threads", x => x.threadId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(nullable: true),
                    creationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "threads");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
