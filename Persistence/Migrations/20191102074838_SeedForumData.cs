using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedForumData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "postContent",
                table: "threads",
                newName: "threadTitle");

            migrationBuilder.AddColumn<string>(
                name: "threadContent",
                table: "threads",
                nullable: true);

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "replyId", "creationDT", "posterId", "replyContent" },
                values: new object[] { -1, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(5086), -1, "Reply -1" });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "replyId", "creationDT", "posterId", "replyContent" },
                values: new object[] { -2, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(6758), -2, "Reply -2" });

            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "replyId", "creationDT", "posterId", "replyContent" },
                values: new object[] { -3, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(6781), -3, "Reply -3" });

            migrationBuilder.InsertData(
                table: "threads",
                columns: new[] { "threadId", "creationDT", "posterId", "threadContent", "threadTitle" },
                values: new object[] { -1, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(1698), -1, "Thread Content -1", "Thread -1" });

            migrationBuilder.InsertData(
                table: "threads",
                columns: new[] { "threadId", "creationDT", "posterId", "threadContent", "threadTitle" },
                values: new object[] { -2, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(3697), -2, "Thread Content -2", "Thread -2" });

            migrationBuilder.InsertData(
                table: "threads",
                columns: new[] { "threadId", "creationDT", "posterId", "threadContent", "threadTitle" },
                values: new object[] { -3, new DateTime(2019, 11, 2, 2, 48, 38, 596, DateTimeKind.Local).AddTicks(3733), -3, "Thread Content -3", "Thread -3" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -1, new DateTime(2019, 11, 2, 2, 48, 38, 592, DateTimeKind.Local).AddTicks(994), "Name -1" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -2, new DateTime(2019, 11, 2, 2, 48, 38, 595, DateTimeKind.Local).AddTicks(8355), "Name -2" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -3, new DateTime(2019, 11, 2, 2, 48, 38, 595, DateTimeKind.Local).AddTicks(8379), "Name -3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "replyId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "replyId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "replyId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "threads",
                keyColumn: "threadId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "threads",
                keyColumn: "threadId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "threads",
                keyColumn: "threadId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "threadContent",
                table: "threads");

            migrationBuilder.RenameColumn(
                name: "threadTitle",
                table: "threads",
                newName: "postContent");
        }
    }
}
