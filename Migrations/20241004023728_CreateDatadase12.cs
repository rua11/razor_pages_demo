using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ofit_category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    category_type = table.Column<string>(type: "varchar", nullable: true, comment: "Category Type"),
                    sequence = table.Column<int>(type: "integer", nullable: true, comment: "Sequence"),
                    parent_path = table.Column<string>(type: "varchar", nullable: true, comment: "Parent Path"),
                    depth = table.Column<int>(type: "integer", nullable: true, comment: "Depth"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    parent_id = table.Column<int>(type: "integer", nullable: true, comment: "Parent"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_category", x => x.id);
                    table.ForeignKey(
                        name: "ofit_category_category_id_fkey",
                        column: x => x.parent_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Category Management");

            migrationBuilder.CreateTable(
                name: "ofit_crop",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    crop_code = table.Column<string>(type: "varchar", nullable: false, comment: "Crop Code"),
                    internal_code = table.Column<string>(type: "varchar", nullable: false, comment: "Internal Code"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    category_id = table.Column<int>(type: "integer", nullable: false, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_crop", x => x.id);
                    table.ForeignKey(
                        name: "ofit_tool_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Crop Management");

            migrationBuilder.CreateTable(
                name: "ofit_material",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    material_code = table.Column<string>(type: "varchar", nullable: false, comment: "Material Code"),
                    internal_code = table.Column<string>(type: "varchar", nullable: false, comment: "Internal Code"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    category_id = table.Column<int>(type: "integer", nullable: false, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_material", x => x.id);
                    table.ForeignKey(
                        name: "ofit_material_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Material Management");

            migrationBuilder.CreateTable(
                name: "ofit_partner",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    internal_code = table.Column<string>(type: "varchar", nullable: false, comment: "Internal Code"),
                    contact = table.Column<string>(type: "varchar", nullable: true, comment: "Contact"),
                    phone = table.Column<string>(type: "varchar", nullable: true, comment: "Phone"),
                    email = table.Column<string>(type: "varchar", nullable: true, comment: "Email"),
                    website = table.Column<string>(type: "varchar", nullable: true, comment: "Website"),
                    address = table.Column<string>(type: "varchar", nullable: true, comment: "Address"),
                    comment = table.Column<string>(type: "varchar", nullable: true, comment: "Comment"),
                    category_id = table.Column<int>(type: "integer", nullable: true, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_partner", x => x.id);
                    table.ForeignKey(
                        name: "ofit_tool_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Partner Management");

            migrationBuilder.CreateTable(
                name: "ofit_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    internal_code = table.Column<string>(type: "varchar", nullable: false, comment: "Internal Code"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    category_id = table.Column<int>(type: "integer", nullable: false, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_product", x => x.id);
                    table.ForeignKey(
                        name: "ofit_tool_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Product Management");

            migrationBuilder.CreateTable(
                name: "ofit_tool",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    tool_code = table.Column<string>(type: "varchar", nullable: false, comment: "Tool Code"),
                    internal_code = table.Column<string>(type: "varchar", nullable: false, comment: "Internal Code"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    category_id = table.Column<int>(type: "integer", nullable: false, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_tool", x => x.id);
                    table.ForeignKey(
                        name: "ofit_tool_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Tool Management");

            migrationBuilder.CreateTable(
                name: "ofit_unit",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    notation = table.Column<string>(type: "varchar", nullable: true, comment: "Notation"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    default_unit = table.Column<bool>(type: "boolean", nullable: false, comment: "Default Unit"),
                    is_active = table.Column<bool>(type: "boolean", nullable: false, comment: "Actived"),
                    convert = table.Column<double>(type: "double precision", nullable: true, comment: "Convert"),
                    category_id = table.Column<int>(type: "integer", nullable: false, comment: "Category"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_unit", x => x.id);
                    table.ForeignKey(
                        name: "ofit_tool_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "ofit_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Unit Management");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_category_parent_id",
                table: "ofit_category",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "ofit_category_parent_path_index",
                table: "ofit_category",
                column: "parent_path");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_crop_category_id",
                table: "ofit_crop",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_material_category_id",
                table: "ofit_material",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_partner_category_id",
                table: "ofit_partner",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_product_category_id",
                table: "ofit_product",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_tool_category_id",
                table: "ofit_tool",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_ofit_unit_category_id",
                table: "ofit_unit",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ofit_crop");

            migrationBuilder.DropTable(
                name: "ofit_material");

            migrationBuilder.DropTable(
                name: "ofit_partner");

            migrationBuilder.DropTable(
                name: "ofit_product");

            migrationBuilder.DropTable(
                name: "ofit_tool");

            migrationBuilder.DropTable(
                name: "ofit_unit");

            migrationBuilder.DropTable(
                name: "ofit_category");
        }
    }
}
