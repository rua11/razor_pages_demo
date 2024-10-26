using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ofit_activity",
                type: "varchar(10)",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldComment: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ofit_activity",
                type: "varchar",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldComment: "Name");
        }
    }
}
