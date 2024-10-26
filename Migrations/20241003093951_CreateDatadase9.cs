using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "ofit_activity");

            migrationBuilder.AddColumn<bool>(
                name: "t_Active",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "t_Active",
                table: "ofit_activity");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: true);
        }
    }
}
