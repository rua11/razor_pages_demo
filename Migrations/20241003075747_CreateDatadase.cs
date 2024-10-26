using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace razor_demo.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatadase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ofit_activity",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false, comment: "Name"),
                    description = table.Column<string>(type: "varchar", nullable: true, comment: "Description"),
                    is_active = table.Column<bool>(type: "boolean", nullable: true, comment: "Actived"),
                    is_farmer_activity = table.Column<bool>(type: "boolean", nullable: true, comment: "Is Farmer Activity"),
                    is_harvesting = table.Column<bool>(type: "boolean", nullable: true, comment: "Is Harvesting"),
                    sequence = table.Column<int>(type: "integer", nullable: true, comment: "Sequence"),
                    display_type = table.Column<int>(type: "integer", nullable: true, comment: "Display Type"),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    write_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ofit_activity", x => x.id);
                },
                comment: "Activity Management");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ofit_activity");
        }
    }
}
