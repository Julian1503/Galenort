using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Galenort.Infraestructura.Migrations
{
    public partial class firstmigration0607 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
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
                name: "Dias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.Id);
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
                    Calle = table.Column<string>(maxLength: 150, nullable: false),
                    Numero = table.Column<string>(maxLength: 100, nullable: false),
                    Localidad = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establecimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    HoraInicio = table.Column<TimeSpan>(type: "Time", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "Time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
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
                name: "DiaHorarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EstaEliminado = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    IdDia = table.Column<long>(nullable: false),
                    IdHorario = table.Column<long>(nullable: false)
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
                        name: "FK_Horario_DiaHorarios",
                        column: x => x.IdHorario,
                        principalTable: "Horarios",
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
                    IdPrestador = table.Column<long>(nullable: false),
                    IdHorario = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioPrestadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horario_HorarioPrestadores",
                        column: x => x.IdHorario,
                        principalTable: "Horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prestador_HorarioPrestadores",
                        column: x => x.IdPrestador,
                        principalTable: "Prestadores",
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
                    IdPrestador = table.Column<long>(nullable: false),
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
                        column: x => x.IdPrestador,
                        principalTable: "Prestadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 1L, "Lunes", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 2L, "Martes", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 3L, "Miercoles", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 4L, "Jueves", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 5L, "Viernes", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 6L, "Sabado", (short)0 });

            migrationBuilder.InsertData(
                table: "Dias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado" },
                values: new object[] { 7L, "Domingo", (short)0 });

            migrationBuilder.CreateIndex(
                name: "IX_DiaHorarios_IdDia",
                table: "DiaHorarios",
                column: "IdDia");

            migrationBuilder.CreateIndex(
                name: "IX_DiaHorarios_IdHorario",
                table: "DiaHorarios",
                column: "IdHorario");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPrestadores_IdEspecialidad",
                table: "HorarioPrestadores",
                column: "IdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPrestadores_IdEstablecimiento",
                table: "HorarioPrestadores",
                column: "IdEstablecimiento");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPrestadores_IdHorario",
                table: "HorarioPrestadores",
                column: "IdHorario");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPrestadores_IdPrestador",
                table: "HorarioPrestadores",
                column: "IdPrestador");

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
                name: "IX_PrestadorEstablecimientos_IdPrestador",
                table: "PrestadorEstablecimientos",
                column: "IdPrestador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaHorarios");

            migrationBuilder.DropTable(
                name: "HorarioPrestadores");

            migrationBuilder.DropTable(
                name: "PrestadorEspecialidades");

            migrationBuilder.DropTable(
                name: "PrestadorEstablecimientos");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Establecimientos");

            migrationBuilder.DropTable(
                name: "Prestadores");
        }
    }
}
