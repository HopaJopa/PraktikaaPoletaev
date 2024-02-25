using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazTurizmaPoletaev.Migrations
{
    /// <inheritdoc />
    public partial class hyu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kratkOpis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    polnOpis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
