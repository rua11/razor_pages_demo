using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ofit_category",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "ofit_category");
        }
    }
}
