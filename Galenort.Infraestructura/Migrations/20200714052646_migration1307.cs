using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Galenort.Infraestructura.Migrations
{
    public partial class migration1307 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prestadores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Nombre = table.Column<string>(maxLength: 250, nullable: false),
                    Apellido = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Establecimientos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    RazonSocial = table.Column<string>(maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(maxLength: 200, nullable: false),
                    IdLocalidad = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establecimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidad_Establecimientos",
                        column: x => x.IdLocalidad,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestadorEspecialidades",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdPrestador = table.Column<long>(nullable: false),
                    IdEspecialidad = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorEspecialidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Especialidad_PrestadorEspecialidad",
                        column: x => x.IdEspecialidad,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestador_PrestadorEspecialidad",
                        column: x => x.IdPrestador,
                        principalTable: "Prestadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestadorEstablecimientos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdPrestadorEspecialidad = table.Column<long>(nullable: false),
                    IdEstablecimiento = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorEstablecimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establecimiento_PrestadorEstablecimientos",
                        column: x => x.IdEstablecimiento,
                        principalTable: "Establecimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestador_PrestadorEstablecimientos",
                        column: x => x.IdPrestadorEspecialidad,
                        principalTable: "PrestadorEspecialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HorarioPrestadores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdPrestadorEstablecimiento = table.Column<long>(nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "Time", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "Time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioPrestadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestadorEstablecimiento_HorarioPrestadores",
                        column: x => x.IdPrestadorEstablecimiento,
                        principalTable: "PrestadorEstablecimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DiaHorarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdDia = table.Column<long>(nullable: false),
                    IdHorarioPrestador = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaHorarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dia_DiaHorarios",
                        column: x => x.IdDia,
                        principalTable: "Dias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HorarioPrestador_DiaHorarios",
                        column: x => x.IdHorarioPrestador,
                        principalTable: "HorarioPrestadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 1L, "LUNES", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 2L, "MARTES", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 3L, "MIERCOLES", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 4L, "JUEVES", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 5L, "VIERNES", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 6L, "LUNES A VIERNES", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 14L, "PSICOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 13L, "UROLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 12L, "NEUMONOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 10L, "PROCTOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 9L, "CIRUGIA GRAL", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 8L, "TRAUMATOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 11L, "CARDIOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 6L, "DERMATOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 5L, "CLINICO", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 4L, "NEUROLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 3L, "ECOGRAFIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 2L, "ENDOCRINOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 1L, "FLEBOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 7L, "GINECOLOGIA", (short)0 });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 1L, "San Miguel de Tucumán", (short)0 });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 2L, "Aguilares", (short)0 });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 14L, "JUAREZ", (short)0, "PABLO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 15L, "FIGUEROA", (short)0, "RICARDO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 16L, "LAZARTE", (short)0, "JORGE" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 17L, "GEREZ", (short)0, "LILIANA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 22L, "SILVA", (short)0, "ENZO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 19L, "TOBIAS TERUEL", (short)0, "OSCAR" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 20L, "LOPEZ", (short)0, "LORENA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 21L, "PERPIGNAL", (short)0, "LUISA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 13L, "QUIROGA", (short)0, "ADRIAN" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 18L, "NEME", (short)0, "GRACIELA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 12L, "FERNANDEZ", (short)0, "SILVIO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 1L, "AGÜERO AVILA", (short)0, "MARCELO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 10L, "ARGAÑARAZ", (short)0, "CARMEN" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 9L, "FRAU", (short)0, "DANIEL" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 8L, "BAZA", (short)0, "DAVID" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 7L, "VENTURINI", (short)0, "ARTURO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 6L, "GIMENEZ", (short)0, "NAZARENO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 5L, "BENAGLIO", (short)0, "HORACIO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 4L, "CABRAL", (short)0, "CLELIA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 3L, "CHAVEZ", (short)0, "NILDA" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 2L, "ESCODAMAGLIA", (short)0, "SERGIO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 23L, "MENA", (short)0, "VICENTE" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 11L, "VALDE LICO", (short)0, "GUILLERMO" });

            migrationBuilder.InsertData(
                table: "Prestadores",
                columns: new[] { "Id", "Apellido", "EstaEliminado", "Nombre" },
                values: new object[] { 24L, "CANSECO", (short)0, "RICARDO" });

            migrationBuilder.InsertData(
                table: "Establecimientos",
                columns: new[] { "Id", "Direccion", "EstaEliminado", "IdLocalidad", "RazonSocial" },
                values: new object[] { 1L, "Avenida Belgrano 2970", (short)0, 1L, "Sanatorio Galeno S.C.E.I" });

            migrationBuilder.InsertData(
                table: "Establecimientos",
                columns: new[] { "Id", "Direccion", "EstaEliminado", "IdLocalidad", "RazonSocial" },
                values: new object[] { 2L, "Jujuy 111", (short)0, 1L, "Sanatorio C.I.M.S.A" });

            migrationBuilder.InsertData(
                table: "Establecimientos",
                columns: new[] { "Id", "Direccion", "EstaEliminado", "IdLocalidad", "RazonSocial" },
                values: new object[] { 3L, "Avenida Mitre 268", (short)0, 1L, "Sanatorio Central S.R.L" });

            migrationBuilder.InsertData(
                table: "Establecimientos",
                columns: new[] { "Id", "Direccion", "EstaEliminado", "IdLocalidad", "RazonSocial" },
                values: new object[] { 4L, "Avenida Mitre 263", (short)0, 2L, "Sanatorio Mitre S.R.L" });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 22L, (short)0, 13L, 22L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 21L, (short)0, 12L, 21L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 20L, (short)0, 11L, 20L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 19L, (short)0, 11L, 19L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 18L, (short)0, 11L, 18L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 17L, (short)0, 10L, 17L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 16L, (short)0, 9L, 16L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 15L, (short)0, 9L, 15L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 14L, (short)0, 8L, 14L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 13L, (short)0, 8L, 13L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 12L, (short)0, 8L, 12L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 10L, (short)0, 7L, 10L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 23L, (short)0, 5L, 23L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 9L, (short)0, 7L, 9L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 8L, (short)0, 6L, 8L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 7L, (short)0, 5L, 7L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 6L, (short)0, 4L, 6L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 5L, (short)0, 3L, 5L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 4L, (short)0, 2L, 4L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 3L, (short)0, 2L, 3L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 2L, (short)0, 1L, 2L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 1L, (short)0, 1L, 1L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 11L, (short)0, 8L, 11L });

            migrationBuilder.InsertData(
                table: "PrestadorEspecialidades",
                columns: new[] { "Id", "EstaEliminado", "IdEspecialidad", "IdPrestador" },
                values: new object[] { 24L, (short)0, 14L, 24L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 1L, (short)0, 3L, 1L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 22L, (short)0, 3L, 22L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 21L, (short)0, 3L, 21L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 20L, (short)0, 3L, 20L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 19L, (short)0, 3L, 19L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 18L, (short)0, 3L, 18L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 17L, (short)0, 3L, 17L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 16L, (short)0, 3L, 16L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 15L, (short)0, 3L, 15L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 14L, (short)0, 3L, 14L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 13L, (short)0, 3L, 13L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 12L, (short)0, 3L, 12L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 11L, (short)0, 3L, 11L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 10L, (short)0, 3L, 10L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 9L, (short)0, 3L, 9L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 8L, (short)0, 3L, 8L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 7L, (short)0, 3L, 7L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 6L, (short)0, 3L, 6L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 5L, (short)0, 3L, 5L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 4L, (short)0, 3L, 4L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 3L, (short)0, 3L, 3L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 2L, (short)0, 3L, 2L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 23L, (short)0, 3L, 23L });

            migrationBuilder.InsertData(
                table: "PrestadorEstablecimientos",
                columns: new[] { "Id", "EstaEliminado", "IdEstablecimiento", "IdPrestadorEspecialidad" },
                values: new object[] { 24L, (short)0, 3L, 24L });

            migrationBuilder.CreateIndex(
                name: "IX_DiaHorarios_IdDia",
                table: "DiaHorarios",
                column: "IdDia");

            migrationBuilder.CreateIndex(
                name: "IX_DiaHorarios_IdHorarioPrestador",
                table: "DiaHorarios",
                column: "IdHorarioPrestador");

            migrationBuilder.CreateIndex(
                name: "IX_Establecimientos_IdLocalidad",
                table: "Establecimientos",
                column: "IdLocalidad");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPrestadores_IdPrestadorEstablecimiento",
                table: "HorarioPrestadores",
                column: "IdPrestadorEstablecimiento");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorEspecialidades_IdEspecialidad",
                table: "PrestadorEspecialidades",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorEspecialidades_IdPrestador",
                table: "PrestadorEspecialidades",
                column: "IdPrestador");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorEstablecimientos_IdEstablecimiento",
                table: "PrestadorEstablecimientos",
                column: "IdEstablecimiento");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorEstablecimientos_IdPrestadorEspecialidad",
                table: "PrestadorEstablecimientos",
                column: "IdPrestadorEspecialidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaHorarios");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "HorarioPrestadores");

            migrationBuilder.DropTable(
                name: "PrestadorEstablecimientos");

            migrationBuilder.DropTable(
                name: "Establecimientos");

            migrationBuilder.DropTable(
                name: "PrestadorEspecialidades");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Prestadores");
        }
    }
}
