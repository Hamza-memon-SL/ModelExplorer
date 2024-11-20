using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenAiPoc.Contracts.Migrations
{
    /// <inheritdoc />
    public partial class Newtablewithkeysss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "FileDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "FileDetails");
        }
    }
}
