using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBooks.Migrations
{
    public partial class Films : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Artist = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Lenght = table.Column<int>(nullable: false),
                    MojaOcena = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");
        }
    }
}
