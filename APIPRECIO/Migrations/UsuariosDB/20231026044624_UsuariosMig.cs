using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIPRECIO.Migrations.UsuariosDB
{
    /// <inheritdoc />
    public partial class UsuariosMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Nombre);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Nombre", "Contrasena", "Correo" },
                values: new object[] { "Juan David", "El_gatofly2", "rjuandavid2002@gmailcom" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
