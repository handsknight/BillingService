using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Billing.Infastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APICallLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APIServiceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CallDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CallThrough = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APICallLogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "APICallLogs",
                columns: new[] { "Id", "APIServiceId", "CallDate", "CallThrough", "CustomerName" },
                values: new object[,]
                {
                    { 1L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 27L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 28L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 29L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 30L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 31L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 32L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 33L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 34L, "SAPI09-0982", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 35L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "INTERSWITCH" },
                    { 26L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 36L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "INTERSWITCH" },
                    { 38L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 39L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 40L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 41L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 42L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 43L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 44L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 45L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 46L, "SAPI09-0982", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 37L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 25L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 24L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "INTERSWITCH" },
                    { 23L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "INTERSWITCH" },
                    { 2L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 3L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 4L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 5L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 6L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 7L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 8L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 9L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 10L, "SAPI09-0982", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 11L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "INTERSWITCH" },
                    { 12L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "INTERSWITCH" },
                    { 13L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 14L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 15L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 16L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" },
                    { 17L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "MTN" },
                    { 18L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MTN" }
                });

            migrationBuilder.InsertData(
                table: "APICallLogs",
                columns: new[] { "Id", "APIServiceId", "CallDate", "CallThrough", "CustomerName" },
                values: new object[,]
                {
                    { 19L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 20L, "SAPI09-0982", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 21L, "SAPI09-0982", new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "STANBIC" },
                    { 22L, "SAPI09-0982", new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "STANBIC" },
                    { 47L, "SAPI09-0982", new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "INTERSWITCH" },
                    { 48L, "SAPI09-0982", new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "INTERSWITCH" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APICallLogs");
        }
    }
}
