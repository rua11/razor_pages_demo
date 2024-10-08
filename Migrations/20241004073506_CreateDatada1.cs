using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatada1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category_type",
                table: "ofit_category",
                newName: "category_type1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category_type1",
                table: "ofit_category",
                newName: "category_type");
        }
    }
}
