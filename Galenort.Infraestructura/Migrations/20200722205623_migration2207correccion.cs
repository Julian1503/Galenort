using Microsoft.EntityFrameworkCore.Migrations;

namespace Galenort.Infraestructura.Migrations
{
    public partial class migration2207correccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 57L, (short)0, 1L, 57L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 57L);
        }
    }
}
