using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatada2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_crop");

            migrationBuilder.DropForeignKey(
                name: "ofit_material_category_id_fkey",
                table: "ofit_material");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_partner");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_product");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_tool");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_unit");

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_crop",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ofit_material_category_id_fkey",
                table: "ofit_material",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_partner",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_product",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_tool",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_unit",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_crop");

            migrationBuilder.DropForeignKey(
                name: "ofit_material_category_id_fkey",
                table: "ofit_material");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_partner");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_product");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_tool");

            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_unit");

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_crop",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ofit_material_category_id_fkey",
                table: "ofit_material",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_partner",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_product",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_tool",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_unit",
                column: "category_id",
                principalTable: "ofit_category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
