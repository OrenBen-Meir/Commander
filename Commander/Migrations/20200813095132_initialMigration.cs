using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    how_to = table.Column<string>(nullable: false),
                    line = table.Column<string>(nullable: false),
                    platform = table.Column<string>(maxLength: 510, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
