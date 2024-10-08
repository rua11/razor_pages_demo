using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatada4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "sequence",
                table: "ofit_category",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Sequence",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Sequence");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "sequence",
                table: "ofit_category",
                type: "integer",
                nullable: true,
                comment: "Sequence",
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Sequence");
        }
    }
}
