using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PT.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    PricePerUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Investments",
                columns: new[] { "Id", "ActionType", "Amount", "AssetType", "Date", "Name", "PricePerUnit" },
                values: new object[,]
                {
                    { -7, "Buy", 6, "Stock", new DateOnly(2025, 8, 24), "IBM", 240 },
                    { -6, "Buy", 5, "Stock", new DateOnly(2025, 8, 24), "Microsoft", 500 },
                    { -5, "Buy", 1, "Metal", new DateOnly(2025, 8, 24), "Silver", 150 },
                    { -4, "Buy", 10, "Metal", new DateOnly(2025, 8, 24), "Gold", 3372 },
                    { -3, "Buy", 2, "Stock", new DateOnly(2025, 8, 24), "Tesla Inc.", 340 },
                    { -2, "Buy", 4, "Crypto", new DateOnly(2025, 8, 24), "Ethereum", 4231 },
                    { -1, "Buy", 2, "Crypto", new DateOnly(2025, 8, 24), "Bitcoin", 323232 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investments");
        }
    }
}
