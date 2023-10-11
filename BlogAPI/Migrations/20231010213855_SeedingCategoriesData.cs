using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics;

#nullable disable

namespace BlogAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCategoriesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    {1,"Sports" },
                    {2,"Programming" },
                    {3,"Travel" },
                    {4,"Food" },
                    {5,"Music" },
                }
                );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
