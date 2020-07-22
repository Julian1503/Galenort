using Microsoft.EntityFrameworkCore.Migrations;

namespace Galenort.Infraestructura.Migrations
{
    public partial class migration2207 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 7L, "SABADO", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 8L, "Sujeto a acuerdo previo con el especialista", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 15L, "GASTROENTEROLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 16L, "CIRUGIA CARDIOVASCULAR", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 17L, "PEDIATRIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 18L, "ODONTOLOGIA", (short)0 });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Agüero Avila", "Marcelo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Escodamaglia", "Sergio" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Chavez", "Nilda" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Cabral", "Clelia" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Benaglio", "Horacio" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Gimenez", "Nazareno" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Venturini", "Arturo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Baza", "David" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Frau", "Daniel" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Argañaraz", "Carmen" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Valde lico", "Guillermo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Fernandez", "Silvio" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Quiroga", "Adrian" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Juarez", "Pablo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Figueroa", "Ricardo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Lazarte", "Jorge" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Gerez", "Liliana" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Neme", "Graciela" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Tobias Teruel", "Oscar" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Lopez", "Lorena" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Perpignal", "Luisa" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Silva", "Enzo" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Mena", "Vicente" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "Canseco", "Ricardo" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 47L, "Triguero", (short)0, "Felix" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 48L, "Raya", (short)0, "Jose" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 49L, "Suarez", (short)0, "Jorge" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 50L, "Alonso", (short)0, "Gustavo" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 51L, "Campero", (short)0, "Silvia Graciela" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 52L, "Romaño", (short)0, "Murga" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 53L, "Juan Ramon", (short)0, "Cecilia" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 54L, "Rovarini", (short)0, "Ana" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 57L, "Perez Ordoñes", (short)0, "Veronica" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 56L, "Almeida", (short)0, "Maria" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 46L, "Martinez", (short)0, "Fabian" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 58L, "Alvarez", (short)0, "Carlos" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 59L, "Fernandez", (short)0, "Alvaro" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 60L, "Perez", (short)0, "Mulki" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 61L, "Martinez", (short)0, "Javier" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 62L, "Avellaneda", (short)0, "Maria" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 63L, "Fierro", (short)0, "Jorge" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 55L, "Chehade", (short)0, "Wadi" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 45L, "Brito", (short)0, "Guillermo" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 30L, "Brodesen", (short)0, "Liliana" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 43L, "Ale Levin", (short)0, "Walter" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 25L, "Gómez", (short)0, "Sergio" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 26L, "Mena", (short)0, "Hernán" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 27L, "Ramos", (short)0, "Hernández" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 28L, "Robles", (short)0, "Chavez" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 29L, "Nieto", (short)0, "Silva" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 64L, "Ledesma", (short)0, "Jesus Emiliano" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 31L, "Jaime", (short)0, "Sebastian" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 32L, "Fernandez", (short)0, "Gómez" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 44L, "Paz", (short)0, "Claudio" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 33L, "Erbetta", (short)0, "Ruben Julio" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 35L, "Saracho", (short)0, "Victor Manuel" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 36L, "Raskosky", (short)0, "Luis Raul" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 37L, "Azcárate Pacheres", (short)0, "Aníbal" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 38L, "Zelada", (short)0, "Fernando" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 39L, "Michel", (short)0, "  Jhony" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 40L, "Rojas", (short)0, "Adrian" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 41L, "Ruiz Diaz", (short)0, "Hector" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 42L, "Ale", (short)0, "Pablo" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 34L, "Andjel", (short)0, "Germán Alejandro" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 65L, "Fadel", (short)0, "Julio" });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 25L, (short)0, 9L, 25L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 47L, (short)0, 12L, 47L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 48L, (short)0, 11L, 48L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 49L, (short)0, 11L, 49L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 50L, (short)0, 12L, 50L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 51L, (short)0, 6L, 51L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 52L, (short)0, 15L, 52L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 53L, (short)0, 15L, 53L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 54L, (short)0, 12L, 54L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 55L, (short)0, 17L, 55L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 56L, (short)0, 17L, 56L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 57L, (short)0, 17L, 57L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 58L, (short)0, 16L, 58L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 59L, (short)0, 16L, 59L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 60L, (short)0, 18L, 60L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 61L, (short)0, 11L, 61L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 62L, (short)0, 17L, 62L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 63L, (short)0, 9L, 63L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 46L, (short)0, 11L, 46L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 64L, (short)0, 11L, 64L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 45L, (short)0, 17L, 45L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 43L, (short)0, 8L, 43L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 26L, (short)0, 9L, 26L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 27L, (short)0, 7L, 27L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 28L, (short)0, 7L, 28L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 29L, (short)0, 7L, 29L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 30L, (short)0, 15L, 30L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 31L, (short)0, 13L, 31L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 32L, (short)0, 13L, 32L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 33L, (short)0, 16L, 33L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 34L, (short)0, 4L, 34L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 35L, (short)0, 11L, 35L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 36L, (short)0, 9L, 36L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 37L, (short)0, 5L, 37L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 38L, (short)0, 3L, 38L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 39L, (short)0, 9L, 39L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 40L, (short)0, 9L, 40L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 41L, (short)0, 13L, 41L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 42L, (short)0, 8L, 42L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 44L, (short)0, 8L, 44L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 65L, (short)0, 8L, 65L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 25L, (short)0, 2L, 25L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 47L, (short)0, 1L, 47L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 48L, (short)0, 1L, 48L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 49L, (short)0, 1L, 49L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 50L, (short)0, 1L, 50L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 51L, (short)0, 1L, 51L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 52L, (short)0, 1L, 52L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 53L, (short)0, 1L, 53L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 46L, (short)0, 1L, 46L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 54L, (short)0, 1L, 54L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 56L, (short)0, 1L, 57L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 58L, (short)0, 1L, 58L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 59L, (short)0, 1L, 59L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 60L, (short)0, 1L, 60L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 61L, (short)0, 4L, 61L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 62L, (short)0, 4L, 62L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 63L, (short)0, 4L, 63L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 55L, (short)0, 1L, 55L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 45L, (short)0, 1L, 45L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 44L, (short)0, 1L, 44L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 43L, (short)0, 1L, 43L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 26L, (short)0, 2L, 26L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 27L, (short)0, 2L, 27L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 28L, (short)0, 2L, 28L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 29L, (short)0, 2L, 29L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 30L, (short)0, 2L, 30L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 31L, (short)0, 2L, 31L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 32L, (short)0, 2L, 32L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 33L, (short)0, 2L, 33L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 34L, (short)0, 2L, 34L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 35L, (short)0, 2L, 35L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 36L, (short)0, 2L, 36L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 37L, (short)0, 2L, 37L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 38L, (short)0, 1L, 38L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 39L, (short)0, 1L, 39L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 40L, (short)0, 1L, 40L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 41L, (short)0, 1L, 41L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 42L, (short)0, 1L, 42L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 64L, (short)0, 4L, 64L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 65L, (short)0, 4L, 65L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dias",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Dias",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "PrestadorEstablecimientos",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "PrestadorEspecialidades",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "AGÜERO AVILA", "MARCELO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "ESCODAMAGLIA", "SERGIO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "CHAVEZ", "NILDA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "CABRAL", "CLELIA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "BENAGLIO", "HORACIO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "GIMENEZ", "NAZARENO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "VENTURINI", "ARTURO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "BAZA", "DAVID" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "FRAU", "DANIEL" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "ARGAÑARAZ", "CARMEN" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "VALDE LICO", "GUILLERMO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "FERNANDEZ", "SILVIO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "QUIROGA", "ADRIAN" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "JUAREZ", "PABLO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "FIGUEROA", "RICARDO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "LAZARTE", "JORGE" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "GEREZ", "LILIANA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "NEME", "GRACIELA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "TOBIAS TERUEL", "OSCAR" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "LOPEZ", "LORENA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "PERPIGNAL", "LUISA" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "SILVA", "ENZO" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "MENA", "VICENTE" });

            migrationBuilder.UpdateData(
                table: "Prestadores",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Apellido", "Nombre" },
                values: new object[] { "CANSECO", "RICARDO" });
        }
    }
}
