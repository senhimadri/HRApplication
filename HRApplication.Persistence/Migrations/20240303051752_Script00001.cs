using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRApplication.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Script00001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                schema: "base",
                table: "TblAccountInfo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "base",
                table: "TblAccountInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
