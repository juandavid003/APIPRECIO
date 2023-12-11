using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIPRECIO.Migrations
{
    /// <inheritdoc />
    public partial class hola1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProducto);
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre", "Precio" },
                values: new object[] { 1, 12, "Descripcion Producto1", "Producto1", 12f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
