using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingPostsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Title", "Content", "Created", "CategoryId" },
                values: new object[,]
                {
                    {1,"First Post","First Post Content" , DateTime.Now,3},
                    {2,"Second Post","Second Post Content" , DateTime.Now,4},
                    {3,"Third Post","Third Post Content" , DateTime.Now,5},
                    {4,"Forth Post","Forth Post Content" , DateTime.Now,3}
                }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Posts");
        }
    }
}
