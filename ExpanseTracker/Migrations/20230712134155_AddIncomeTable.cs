using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpanseTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddIncomeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "CategoryId", "Date", "Planned", "Title" },
                values: new object[,]
                {
                    { 2, 3.5, 1, new DateTime(2023, 7, 17, 21, 0, 0, 0, DateTimeKind.Utc), false, "Bubble Gum" },
                    { 3, 20.0, 5, new DateTime(2012, 7, 17, 21, 0, 0, 0, DateTimeKind.Utc), true, "Sun glasses" },
                    { 4, 25.0, 4, new DateTime(2031, 7, 17, 21, 0, 0, 0, DateTimeKind.Utc), false, "Calculator" }
                });

            migrationBuilder.InsertData(
                table: "Income",
                columns: new[] { "Id", "Amount", "Date", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 2500.0, new DateTime(2022, 1, 31, 22, 0, 0, 0, DateTimeKind.Utc), "Ropardo_January", 0 },
                    { 2, 0.40000000000000002, new DateTime(2022, 9, 20, 21, 0, 0, 0, DateTimeKind.Utc), "Cash on the street", 3 },
                    { 3, 500.0, new DateTime(2012, 9, 14, 21, 0, 0, 0, DateTimeKind.Utc), "Erasmus", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
