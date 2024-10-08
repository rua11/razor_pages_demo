using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatada3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_unit",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_unit",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_tool",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_tool",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_product",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_product",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_partner",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_partner",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_material",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_material",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_crop",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_crop",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_category",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "parent_id",
                table: "ofit_category",
                type: "integer",
                nullable: true,
                comment: "Parent Category",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Parent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_category",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_activity",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Write Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_activity",
                type: "timestamp without time zone",
                nullable: true,
                comment: "Create Date",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_unit",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_unit",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_tool",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_tool",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_product",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_product",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_partner",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_partner",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_material",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_material",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_crop",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_crop",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_category",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<int>(
                name: "parent_id",
                table: "ofit_category",
                type: "integer",
                nullable: true,
                comment: "Parent",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Parent Category");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_category",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "write_date",
                table: "ofit_activity",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Write Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "create_date",
                table: "ofit_activity",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true,
                oldComment: "Create Date");
        }
    }
}
