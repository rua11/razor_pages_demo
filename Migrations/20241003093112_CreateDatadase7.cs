using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "is_harvesting",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Is Harvesting",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true,
                oldComment: "Is Harvesting");

            migrationBuilder.AlterColumn<bool>(
                name: "is_farmer_activity",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Is Farmer Activity",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true,
                oldComment: "Is Farmer Activity");

            migrationBuilder.AlterColumn<bool>(
                name: "is_active",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                comment: "Actived",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true,
                oldComment: "Actived");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "ofit_activity",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true,
                oldDefaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "is_harvesting",
                table: "ofit_activity",
                type: "boolean",
                nullable: true,
                comment: "Is Harvesting",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Is Harvesting");

            migrationBuilder.AlterColumn<bool>(
                name: "is_farmer_activity",
                table: "ofit_activity",
                type: "boolean",
                nullable: true,
                comment: "Is Farmer Activity",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Is Farmer Activity");

            migrationBuilder.AlterColumn<bool>(
                name: "is_active",
                table: "ofit_activity",
                type: "boolean",
                nullable: true,
                comment: "Actived",
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldComment: "Actived");

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "ofit_activity",
                type: "boolean",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);
        }
    }
}
