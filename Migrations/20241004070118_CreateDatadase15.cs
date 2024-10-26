using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ofit_category_ofit_category_parent_id",
                table: "ofit_category");

            migrationBuilder.AddForeignKey(
                name: "ofit_category_category_id_fkey",
                table: "ofit_category",
                column: "parent_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ofit_category_category_id_fkey",
                table: "ofit_category");

            migrationBuilder.AddForeignKey(
                name: "FK_ofit_category_ofit_category_parent_id",
                table: "ofit_category",
                column: "parent_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
