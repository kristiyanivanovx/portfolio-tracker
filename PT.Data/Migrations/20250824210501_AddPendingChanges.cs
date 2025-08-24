using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PT.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPendingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Investments",
                columns: new[] { "Id", "ActionType", "Amount", "AssetType", "Date", "Name", "PricePerUnit" },
                values: new object[] { -8, "Buy", 10, "Stock", new DateOnly(2025, 8, 24), "NVDA", 3450 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Investments",
                keyColumn: "Id",
                keyValue: -8);
        }
    }
}
