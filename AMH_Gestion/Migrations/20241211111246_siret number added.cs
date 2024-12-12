using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AMH_Gestion.Migrations
{
    /// <inheritdoc />
    public partial class siretnumberadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiretNumber",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiretNumber",
                table: "Companies");
        }
    }
}
