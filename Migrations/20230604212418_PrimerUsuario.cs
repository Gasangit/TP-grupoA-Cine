using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_grupoA_Cine.Migrations
{
    /// <inheritdoc />
    public partial class PrimerUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "ID", "Apellido", "Bloqueado", "Credito", "DNI", "EsAdmin", "FechaNacimiento", "IntentosFallidos", "Mail", "Nombre", "Password" },
                values: new object[] { 1, "Gomez", false, 0.0, "45678964", true, new DateTime(1974, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "m@mail", "Obdulio", "123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
