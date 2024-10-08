using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatada7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "company_id",
                table: "ofit_category",
                type: "integer",
                nullable: true,
                comment: "Company");

            migrationBuilder.CreateTable(
                name: "OfitCompany",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar(10)", nullable: false, comment: "Name"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfitCompany", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ofit_category_company_id",
                table: "ofit_category",
                column: "company_id");

            migrationBuilder.AddForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_category",
                column: "company_id",
                principalTable: "OfitCompany",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "ofit_tool_category_id_fkey",
                table: "ofit_category");

            migrationBuilder.DropTable(
                name: "OfitCompany");

            migrationBuilder.DropIndex(
                name: "IX_ofit_category_company_id",
                table: "ofit_category");

            migrationBuilder.DropColumn(
                name: "company_id",
                table: "ofit_category");
        }
    }
}
