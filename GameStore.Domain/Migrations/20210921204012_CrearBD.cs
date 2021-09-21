using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Domain.Migrations
{
    public partial class CrearBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    Apellido = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: true),
                    NombreCompleto = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Nit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Protagonista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false),
                    Id_Estado = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reservacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Devolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Valor_Total = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alquiler_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Marca = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    MarcaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Director_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Juego",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Lanzamiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id_Director = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juego", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Juego_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler_Dets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Id_Alquiler = table.Column<int>(type: "int", nullable: false),
                    Id_Juego = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    AlquilerId = table.Column<int>(type: "int", nullable: true),
                    JuegoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler_Dets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alquiler_Dets_Alquiler_AlquilerId",
                        column: x => x.AlquilerId,
                        principalTable: "Alquiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alquiler_Dets_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma_Juego",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Juego = table.Column<int>(type: "int", nullable: false),
                    Id_Plataforma = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    PlataformaId = table.Column<int>(type: "int", nullable: true),
                    JuegoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma_Juego", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Protagonista_Juego",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Juego = table.Column<int>(type: "int", nullable: false),
                    Id_Protagonista = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    JuegoId = table.Column<int>(type: "int", nullable: true),
                    ProtagonistaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista_Juego", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Protagonista_ProtagonistaId",
                        column: x => x.ProtagonistaId,
                        principalTable: "Protagonista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "Id_Cliente", "Id_Estado", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3, null, 62916.0 },
                    { 73, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null, 106199.0 },
                    { 72, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 3, null, 53035.0 },
                    { 71, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null, 29313.0 },
                    { 70, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4, null, 115132.0 },
                    { 69, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 3, null, 30243.0 },
                    { 68, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 80822.0 },
                    { 67, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 3, null, 118368.0 },
                    { 66, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, null, 26768.0 },
                    { 65, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, null, 145763.0 },
                    { 64, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 4, null, 38936.0 },
                    { 63, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, null, 60930.0 },
                    { 62, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4, null, 78271.0 },
                    { 61, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 3, null, 149988.0 },
                    { 60, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 4, null, 73718.0 },
                    { 59, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, null, 59161.0 },
                    { 58, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, null, 136442.0 },
                    { 57, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3, null, 98362.0 },
                    { 56, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 4, null, 91690.0 },
                    { 55, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 3, null, 138440.0 },
                    { 54, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, null, 73136.0 },
                    { 53, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 3, null, 59436.0 },
                    { 74, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3, null, 34312.0 },
                    { 75, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 4, null, 133233.0 },
                    { 76, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 4, null, 61905.0 },
                    { 77, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 4, null, 49490.0 },
                    { 100, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, null, 51440.0 },
                    { 99, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4, null, 93289.0 },
                    { 98, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, null, 82799.0 },
                    { 97, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 84843.0 },
                    { 96, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 4, null, 142071.0 },
                    { 95, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 4, null, 79753.0 },
                    { 94, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 4, null, 95842.0 },
                    { 93, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, null, 26886.0 },
                    { 92, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, 61156.0 },
                    { 91, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, null, 101516.0 },
                    { 52, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 4, null, 148549.0 },
                    { 90, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4, null, 73216.0 },
                    { 88, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 4, null, 124020.0 },
                    { 86, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 3, null, 37334.0 },
                    { 85, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, null, 53582.0 },
                    { 84, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3, null, 85790.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "Id_Cliente", "Id_Estado", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 83, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4, null, 145939.0 },
                    { 82, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 3, null, 146445.0 },
                    { 81, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 4, null, 114377.0 },
                    { 80, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 4, null, 112834.0 },
                    { 79, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4, null, 83577.0 },
                    { 78, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, null, 87113.0 },
                    { 89, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4, null, 73459.0 },
                    { 51, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 103745.0 },
                    { 87, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 48446.0 },
                    { 49, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 3, null, 98117.0 },
                    { 22, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 4, null, 121226.0 },
                    { 21, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 32677.0 },
                    { 20, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 53574.0 },
                    { 19, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, null, 89053.0 },
                    { 18, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, null, 100759.0 },
                    { 17, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, null, 89083.0 },
                    { 16, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4, null, 51911.0 },
                    { 15, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, null, 140011.0 },
                    { 14, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3, null, 145151.0 },
                    { 13, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 4, null, 117721.0 },
                    { 12, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, null, 140524.0 },
                    { 11, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4, null, 84650.0 },
                    { 10, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4, null, 31645.0 },
                    { 9, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, null, 146264.0 },
                    { 7, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, null, 147327.0 },
                    { 6, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 4, null, 44163.0 },
                    { 5, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null, 29501.0 },
                    { 4, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, null, 101398.0 },
                    { 3, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, null, 98227.0 },
                    { 2, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, 99527.0 },
                    { 50, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, null, 55389.0 },
                    { 23, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null, 26164.0 },
                    { 24, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 3, null, 111785.0 },
                    { 8, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 27109.0 },
                    { 26, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4, null, 105783.0 },
                    { 48, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, null, 47731.0 },
                    { 25, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 4, null, 67236.0 },
                    { 47, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 3, null, 141407.0 },
                    { 46, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, null, 104403.0 },
                    { 45, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, null, 53208.0 },
                    { 43, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 4, null, 96735.0 },
                    { 42, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, null, 120773.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "Id_Cliente", "Id_Estado", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 41, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3, null, 70341.0 },
                    { 40, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 4, null, 79740.0 },
                    { 39, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null, 144560.0 },
                    { 38, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null, 61048.0 },
                    { 44, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, 89052.0 },
                    { 36, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null, 49878.0 },
                    { 37, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 3, null, 47598.0 },
                    { 29, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 3, null, 116179.0 },
                    { 30, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, null, 132327.0 },
                    { 28, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, null, 94055.0 },
                    { 27, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 4, null, 44175.0 },
                    { 31, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 3, null, 35883.0 },
                    { 33, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 4, null, 47155.0 },
                    { 34, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3, null, 61899.0 },
                    { 35, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 3, null, 139907.0 },
                    { 32, null, new DateTime(2021, 9, 21, 15, 40, 12, 220, DateTimeKind.Local).AddTicks(4427), "Juan Leon", null, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, null, 82882.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 204, null, 127992, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 43, null, null, 0.0 },
                    { 203, null, 52054, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 14, 15, null, null, 0.0 },
                    { 202, null, 120107, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 56, 42, null, null, 0.0 },
                    { 205, null, 129925, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 58, 18, null, null, 0.0 },
                    { 201, null, 127986, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 74, 35, null, null, 0.0 },
                    { 200, null, 72061, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 76, 45, null, null, 0.0 },
                    { 199, null, 50025, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 57, 19, null, null, 0.0 },
                    { 195, null, 51504, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 47, null, null, 0.0 },
                    { 197, null, 93497, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 30, 18, null, null, 0.0 },
                    { 196, null, 92431, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 84, 22, null, null, 0.0 },
                    { 194, null, 106190, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 80, 17, null, null, 0.0 },
                    { 193, null, 141931, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 83, 38, null, null, 0.0 },
                    { 206, null, 39623, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 15, 5, null, null, 0.0 },
                    { 192, null, 57948, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 90, 8, null, null, 0.0 },
                    { 191, null, 121445, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 10, 47, null, null, 0.0 },
                    { 198, null, 116573, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 26, 31, null, null, 0.0 },
                    { 207, null, 120058, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 16, null, null, 0.0 },
                    { 218, null, 130954, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 44, 19, null, null, 0.0 },
                    { 209, null, 106303, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 26, 49, null, null, 0.0 },
                    { 224, null, 59378, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 48, null, null, 0.0 },
                    { 190, null, 111133, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 27, 9, null, null, 0.0 },
                    { 223, null, 92685, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 36, null, null, 0.0 },
                    { 222, null, 132153, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 75, 8, null, null, 0.0 },
                    { 221, null, 124799, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 13, 46, null, null, 0.0 },
                    { 220, null, 124179, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 3, 26, null, null, 0.0 },
                    { 219, null, 125376, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 39, 2, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 217, null, 145765, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 18, null, null, 0.0 },
                    { 216, null, 61330, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 83, 19, null, null, 0.0 },
                    { 215, null, 148500, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 64, 18, null, null, 0.0 },
                    { 214, null, 128781, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 97, 25, null, null, 0.0 },
                    { 213, null, 95853, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 16, 7, null, null, 0.0 },
                    { 212, null, 80049, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 48, 12, null, null, 0.0 },
                    { 211, null, 68454, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 37, 41, null, null, 0.0 },
                    { 210, null, 47271, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 68, 1, null, null, 0.0 },
                    { 208, null, 116808, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 41, 36, null, null, 0.0 },
                    { 189, null, 46258, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 77, 34, null, null, 0.0 },
                    { 165, null, 40875, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 93, 21, null, null, 0.0 },
                    { 187, null, 81799, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 88, 45, null, null, 0.0 },
                    { 167, null, 129800, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 16, null, null, 0.0 },
                    { 166, null, 56597, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 27, 29, null, null, 0.0 },
                    { 164, null, 145970, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 71, 38, null, null, 0.0 },
                    { 163, null, 35788, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 11, 42, null, null, 0.0 },
                    { 162, null, 80649, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 18, null, null, 0.0 },
                    { 161, null, 39561, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 15, 34, null, null, 0.0 },
                    { 160, null, 70536, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 86, 39, null, null, 0.0 },
                    { 159, null, 125974, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 10, 39, null, null, 0.0 },
                    { 158, null, 126612, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 66, 0, null, null, 0.0 },
                    { 157, null, 75856, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 36, 3, null, null, 0.0 },
                    { 156, null, 89376, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 77, 4, null, null, 0.0 },
                    { 155, null, 149247, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 94, 3, null, null, 0.0 },
                    { 154, null, 65337, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 95, 5, null, null, 0.0 },
                    { 153, null, 93058, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 37, 20, null, null, 0.0 },
                    { 225, null, 104307, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 96, 26, null, null, 0.0 },
                    { 168, null, 113944, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 87, 32, null, null, 0.0 },
                    { 188, null, 147648, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 99, 20, null, null, 0.0 },
                    { 169, null, 145511, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 40, 41, null, null, 0.0 },
                    { 171, null, 69413, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 79, 37, null, null, 0.0 },
                    { 186, null, 66697, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 14, null, null, 0.0 },
                    { 185, null, 45594, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 18, 0, null, null, 0.0 },
                    { 184, null, 54835, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 18, 1, null, null, 0.0 },
                    { 183, null, 84885, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 9, null, null, 0.0 },
                    { 182, null, 128232, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 16, 25, null, null, 0.0 },
                    { 181, null, 72037, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 68, 8, null, null, 0.0 },
                    { 180, null, 147193, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 51, 26, null, null, 0.0 },
                    { 179, null, 55759, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 79, 47, null, null, 0.0 },
                    { 178, null, 145807, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 46, null, null, 0.0 },
                    { 177, null, 45922, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 28, null, null, 0.0 },
                    { 176, null, 126975, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 59, 25, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 175, null, 109035, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 86, 37, null, null, 0.0 },
                    { 174, null, 126251, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 74, 37, null, null, 0.0 },
                    { 173, null, 65487, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 8, 46, null, null, 0.0 },
                    { 172, null, 65232, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 27, null, null, 0.0 },
                    { 170, null, 75752, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 90, 47, null, null, 0.0 },
                    { 226, null, 36464, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 35, 29, null, null, 0.0 },
                    { 276, null, 34807, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 41, 28, null, null, 0.0 },
                    { 228, null, 109298, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 52, 45, null, null, 0.0 },
                    { 281, null, 74369, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 30, 35, null, null, 0.0 },
                    { 280, null, 62912, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 10, 46, null, null, 0.0 },
                    { 279, null, 141700, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 2, 36, null, null, 0.0 },
                    { 278, null, 93698, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 26, null, null, 0.0 },
                    { 277, null, 90808, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 34, 16, null, null, 0.0 },
                    { 152, null, 35544, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 30, 31, null, null, 0.0 },
                    { 275, null, 52539, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 42, 43, null, null, 0.0 },
                    { 274, null, 119406, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 20, 6, null, null, 0.0 },
                    { 273, null, 81042, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 70, 12, null, null, 0.0 },
                    { 272, null, 63871, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 37, null, null, 0.0 },
                    { 271, null, 110152, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 62, 6, null, null, 0.0 },
                    { 270, null, 71570, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 43, null, null, 0.0 },
                    { 269, null, 109574, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 29, null, null, 0.0 },
                    { 268, null, 112154, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 44, null, null, 0.0 },
                    { 267, null, 109269, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 22, null, null, 0.0 },
                    { 282, null, 60151, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 59, 47, null, null, 0.0 },
                    { 266, null, 139105, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 75, 26, null, null, 0.0 },
                    { 283, null, 26607, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 14, null, null, 0.0 },
                    { 285, null, 94938, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 34, 36, null, null, 0.0 },
                    { 300, null, 78573, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 42, 20, null, null, 0.0 },
                    { 299, null, 35194, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 52, 19, null, null, 0.0 },
                    { 298, null, 126645, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 56, 45, null, null, 0.0 },
                    { 297, null, 97929, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 48, 48, null, null, 0.0 },
                    { 296, null, 85880, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 86, 9, null, null, 0.0 },
                    { 295, null, 64648, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 52, 18, null, null, 0.0 },
                    { 294, null, 106451, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 19, 16, null, null, 0.0 },
                    { 293, null, 83209, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 47, 9, null, null, 0.0 },
                    { 292, null, 108502, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 49, 4, null, null, 0.0 },
                    { 291, null, 74508, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 5, 35, null, null, 0.0 },
                    { 290, null, 48372, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 65, 29, null, null, 0.0 },
                    { 289, null, 61436, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 35, null, null, 0.0 },
                    { 288, null, 69934, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 48, null, null, 0.0 },
                    { 287, null, 88153, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 16, null, null, 0.0 },
                    { 286, null, 95934, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 41, 0, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 284, null, 109571, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 24, 20, null, null, 0.0 },
                    { 227, null, 73301, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 70, 36, null, null, 0.0 },
                    { 265, null, 138794, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 95, 44, null, null, 0.0 },
                    { 263, null, 42062, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 84, 13, null, null, 0.0 },
                    { 243, null, 66344, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 1, 12, null, null, 0.0 },
                    { 242, null, 114991, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 53, 5, null, null, 0.0 },
                    { 241, null, 96640, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 37, 0, null, null, 0.0 },
                    { 240, null, 30970, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 45, 21, null, null, 0.0 },
                    { 239, null, 74911, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 8, 15, null, null, 0.0 },
                    { 238, null, 106893, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 22, null, null, 0.0 },
                    { 237, null, 101178, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 95, 7, null, null, 0.0 },
                    { 236, null, 101930, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 10, null, null, 0.0 },
                    { 235, null, 44206, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 0, null, null, 0.0 },
                    { 234, null, 133699, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 19, 15, null, null, 0.0 },
                    { 233, null, 120781, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 38, null, null, 0.0 },
                    { 232, null, 79350, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 10, null, null, 0.0 },
                    { 231, null, 58478, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 6, null, null, 0.0 },
                    { 230, null, 41603, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 68, 49, null, null, 0.0 },
                    { 229, null, 99746, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 22, 16, null, null, 0.0 },
                    { 244, null, 148988, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 9, null, null, 0.0 },
                    { 264, null, 89699, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 83, 45, null, null, 0.0 },
                    { 245, null, 67678, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 83, 26, null, null, 0.0 },
                    { 247, null, 112096, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 37, 2, null, null, 0.0 },
                    { 262, null, 35760, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 46, 17, null, null, 0.0 },
                    { 261, null, 116323, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 9, 0, null, null, 0.0 },
                    { 260, null, 118460, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 20, 14, null, null, 0.0 },
                    { 259, null, 48684, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 58, 6, null, null, 0.0 },
                    { 258, null, 142677, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 16, null, null, 0.0 },
                    { 257, null, 52422, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 86, 12, null, null, 0.0 },
                    { 256, null, 145834, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 82, 46, null, null, 0.0 },
                    { 255, null, 97262, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 84, 4, null, null, 0.0 },
                    { 254, null, 75847, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 62, 27, null, null, 0.0 },
                    { 253, null, 141197, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 20, 7, null, null, 0.0 },
                    { 252, null, 112544, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 8, 47, null, null, 0.0 },
                    { 251, null, 96666, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 53, 24, null, null, 0.0 },
                    { 250, null, 140175, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 0, null, null, 0.0 },
                    { 249, null, 107690, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 69, 27, null, null, 0.0 },
                    { 248, null, 38150, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 19, 0, null, null, 0.0 },
                    { 246, null, 66395, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 16, 3, null, null, 0.0 },
                    { 151, null, 79856, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 1, null, null, 0.0 },
                    { 112, null, 42784, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 18, 10, null, null, 0.0 },
                    { 149, null, 53743, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 29, 32, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 53, null, 97444, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 66, 28, null, null, 0.0 },
                    { 52, null, 109704, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 29, 41, null, null, 0.0 },
                    { 51, null, 84738, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 66, 11, null, null, 0.0 },
                    { 50, null, 76209, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 1, 47, null, null, 0.0 },
                    { 49, null, 136501, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 16, null, null, 0.0 },
                    { 48, null, 80559, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 21, null, null, 0.0 },
                    { 47, null, 133292, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 36, 15, null, null, 0.0 },
                    { 46, null, 90266, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 27, 19, null, null, 0.0 },
                    { 45, null, 31016, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 72, 41, null, null, 0.0 },
                    { 44, null, 121925, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 30, null, null, 0.0 },
                    { 43, null, 59116, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 38, null, null, 0.0 },
                    { 42, null, 148323, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 58, 22, null, null, 0.0 },
                    { 41, null, 119985, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 76, 11, null, null, 0.0 },
                    { 40, null, 127872, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 46, 28, null, null, 0.0 },
                    { 39, null, 59714, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 68, 2, null, null, 0.0 },
                    { 54, null, 109862, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 50, 10, null, null, 0.0 },
                    { 38, null, 37953, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 70, 48, null, null, 0.0 },
                    { 55, null, 73118, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 93, 40, null, null, 0.0 },
                    { 57, null, 78222, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 17, 35, null, null, 0.0 },
                    { 72, null, 69380, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 46, null, null, 0.0 },
                    { 71, null, 49585, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 27, 21, null, null, 0.0 },
                    { 70, null, 80549, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 17, null, null, 0.0 },
                    { 69, null, 119530, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 92, 37, null, null, 0.0 },
                    { 68, null, 45727, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 91, 26, null, null, 0.0 },
                    { 67, null, 42425, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 4, 25, null, null, 0.0 },
                    { 66, null, 100509, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 35, 17, null, null, 0.0 },
                    { 65, null, 124473, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 13, null, null, 0.0 },
                    { 64, null, 98741, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 25, 2, null, null, 0.0 },
                    { 150, null, 49337, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 36, 46, null, null, 0.0 },
                    { 62, null, 56992, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 18, null, null, 0.0 },
                    { 61, null, 49562, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 90, 16, null, null, 0.0 },
                    { 60, null, 82918, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 0, 19, null, null, 0.0 },
                    { 59, null, 119369, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 60, 15, null, null, 0.0 },
                    { 58, null, 85459, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 82, 23, null, null, 0.0 },
                    { 56, null, 141687, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 30, 29, null, null, 0.0 },
                    { 73, null, 90425, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 52, 34, null, null, 0.0 },
                    { 37, null, 128958, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 36, 7, null, null, 0.0 },
                    { 35, null, 126799, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 19, 49, null, null, 0.0 },
                    { 15, null, 109341, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 69, 4, null, null, 0.0 },
                    { 14, null, 96328, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 71, 20, null, null, 0.0 },
                    { 13, null, 77864, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 17, 2, null, null, 0.0 },
                    { 12, null, 36249, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 22, 47, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 11, null, 67200, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 33, 46, null, null, 0.0 },
                    { 10, null, 101535, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 76, 16, null, null, 0.0 },
                    { 9, null, 89903, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 25, 13, null, null, 0.0 },
                    { 8, null, 50123, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 29, null, null, 0.0 },
                    { 7, null, 67349, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 55, 1, null, null, 0.0 },
                    { 6, null, 75710, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 53, 8, null, null, 0.0 },
                    { 5, null, 51075, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 1, 39, null, null, 0.0 },
                    { 4, null, 132986, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 60, 23, null, null, 0.0 },
                    { 3, null, 42487, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 20, null, null, 0.0 },
                    { 2, null, 85584, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 58, 22, null, null, 0.0 },
                    { 1, null, 136035, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 92, 43, null, null, 0.0 },
                    { 16, null, 28543, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 49, null, null, 0.0 },
                    { 36, null, 53792, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 57, 30, null, null, 0.0 },
                    { 17, null, 82333, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 24, null, null, 0.0 },
                    { 19, null, 135355, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 2, 32, null, null, 0.0 },
                    { 34, null, 57137, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 94, 2, null, null, 0.0 },
                    { 33, null, 143824, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 15, 27, null, null, 0.0 },
                    { 32, null, 116692, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 76, 46, null, null, 0.0 },
                    { 31, null, 127062, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 69, 9, null, null, 0.0 },
                    { 30, null, 141163, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 28, 29, null, null, 0.0 },
                    { 29, null, 104560, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 63, 31, null, null, 0.0 },
                    { 28, null, 35356, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 77, 49, null, null, 0.0 },
                    { 27, null, 51148, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 35, 31, null, null, 0.0 },
                    { 26, null, 118157, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 17, 43, null, null, 0.0 },
                    { 25, null, 38616, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 82, 12, null, null, 0.0 },
                    { 24, null, 107028, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 28, 24, null, null, 0.0 },
                    { 23, null, 32362, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 49, 30, null, null, 0.0 },
                    { 22, null, 144349, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 25, 8, null, null, 0.0 },
                    { 21, null, 128323, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 18, null, null, 0.0 },
                    { 20, null, 133428, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 90, 30, null, null, 0.0 },
                    { 18, null, 125140, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 82, 45, null, null, 0.0 },
                    { 74, null, 32482, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 22, 32, null, null, 0.0 },
                    { 63, null, 95564, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 71, 9, null, null, 0.0 },
                    { 76, null, 130000, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 81, 15, null, null, 0.0 },
                    { 129, null, 79173, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 37, 32, null, null, 0.0 },
                    { 128, null, 113629, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 64, 0, null, null, 0.0 },
                    { 127, null, 25796, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 81, 3, null, null, 0.0 },
                    { 126, null, 131088, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 92, 13, null, null, 0.0 },
                    { 125, null, 104979, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 76, 16, null, null, 0.0 },
                    { 75, null, 38442, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 48, 22, null, null, 0.0 },
                    { 123, null, 61708, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 93, 7, null, null, 0.0 },
                    { 122, null, 133465, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 88, 45, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 121, null, 81261, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 26, 17, null, null, 0.0 },
                    { 120, null, 107115, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 87, 24, null, null, 0.0 },
                    { 119, null, 42317, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 74, 18, null, null, 0.0 },
                    { 118, null, 67213, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 87, 19, null, null, 0.0 },
                    { 117, null, 33136, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 93, 12, null, null, 0.0 },
                    { 116, null, 78973, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 1, 32, null, null, 0.0 },
                    { 115, null, 98053, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 14, null, null, 0.0 },
                    { 130, null, 100450, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 17, null, null, 0.0 },
                    { 114, null, 46019, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 23, 11, null, null, 0.0 },
                    { 131, null, 77242, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 72, 28, null, null, 0.0 },
                    { 133, null, 62985, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 49, null, null, 0.0 },
                    { 148, null, 47564, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 77, 35, null, null, 0.0 },
                    { 147, null, 84050, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 81, 26, null, null, 0.0 },
                    { 146, null, 107786, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 2, 5, null, null, 0.0 },
                    { 145, null, 103658, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 61, 42, null, null, 0.0 },
                    { 144, null, 65901, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 84, 42, null, null, 0.0 },
                    { 143, null, 112542, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 36, 37, null, null, 0.0 },
                    { 142, null, 104286, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 45, 13, null, null, 0.0 },
                    { 141, null, 148081, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 67, 35, null, null, 0.0 },
                    { 140, null, 66066, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 27, 24, null, null, 0.0 },
                    { 139, null, 26726, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 24, 13, null, null, 0.0 },
                    { 138, null, 117905, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 12, 28, null, null, 0.0 },
                    { 137, null, 34560, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 31, 35, null, null, 0.0 },
                    { 136, null, 47301, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 95, 26, null, null, 0.0 },
                    { 135, null, 50509, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 22, 6, null, null, 0.0 },
                    { 134, null, 45504, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 42, null, null, 0.0 },
                    { 132, null, 149858, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 5, 11, null, null, 0.0 },
                    { 113, null, 134448, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 64, 27, null, null, 0.0 },
                    { 124, null, 134418, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 87, 26, null, null, 0.0 },
                    { 111, null, 56454, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 93, 6, null, null, 0.0 },
                    { 91, null, 125571, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 95, 30, null, null, 0.0 },
                    { 90, null, 135113, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 83, 1, null, null, 0.0 },
                    { 89, null, 134020, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 66, 20, null, null, 0.0 },
                    { 88, null, 58961, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 11, 23, null, null, 0.0 },
                    { 87, null, 44247, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 51, 32, null, null, 0.0 },
                    { 86, null, 42358, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 43, null, null, 0.0 },
                    { 92, null, 68498, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 56, 39, null, null, 0.0 },
                    { 85, null, 81424, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 80, 14, null, null, 0.0 },
                    { 83, null, 48856, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 44, 47, null, null, 0.0 },
                    { 81, null, 134866, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 30, 22, null, null, 0.0 },
                    { 80, null, 98350, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 12, 24, null, null, 0.0 },
                    { 79, null, 101012, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 46, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 78, null, 60437, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 4, 16, null, null, 0.0 },
                    { 77, null, 110232, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 32, 31, null, null, 0.0 },
                    { 84, null, 53350, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 54, 32, null, null, 0.0 },
                    { 93, null, 68584, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 45, 2, null, null, 0.0 },
                    { 82, null, 120589, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 97, 32, null, null, 0.0 },
                    { 95, null, 103310, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 47, 29, null, null, 0.0 },
                    { 94, null, 126797, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 2, 20, null, null, 0.0 },
                    { 110, null, 93118, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 20, 19, null, null, 0.0 },
                    { 109, null, 96420, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 89, 9, null, null, 0.0 },
                    { 108, null, 89961, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 53, 35, null, null, 0.0 },
                    { 106, null, 40357, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 65, 24, null, null, 0.0 },
                    { 105, null, 51624, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 52, 28, null, null, 0.0 },
                    { 104, null, 80952, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 78, 33, null, null, 0.0 },
                    { 107, null, 44278, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 10, 4, null, null, 0.0 },
                    { 102, null, 112565, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 85, 9, null, null, 0.0 },
                    { 101, null, 72840, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 14, 28, null, null, 0.0 },
                    { 100, null, 80507, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 47, 28, null, null, 0.0 },
                    { 99, null, 147453, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 45, 0, null, null, 0.0 },
                    { 98, null, 110375, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 4, 40, null, null, 0.0 },
                    { 97, null, 77758, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 62, 14, null, null, 0.0 },
                    { 103, null, 111029, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 90, 47, null, null, 0.0 },
                    { 96, null, 87992, new DateTime(2021, 9, 21, 15, 40, 12, 229, DateTimeKind.Local).AddTicks(7156), "Juan Leon", 64, 49, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 36, "Morissette", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Cathy.Morissette@gmail.com", new DateTime(1962, 4, 29, 3, 0, 32, 582, DateTimeKind.Local).AddTicks(94), "586416266", "Cathy", "Cathy Morissette", "632-618-6981 x21800", null },
                    { 35, "Stiedemann", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Andrew.Stiedemann50@hotmail.com", new DateTime(1971, 11, 26, 16, 13, 14, 988, DateTimeKind.Local).AddTicks(1843), "165227382", "Andrew", "Andrew Stiedemann", "905-534-8559 x940", null },
                    { 34, "Rippin", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Willis.Rippin@gmail.com", new DateTime(1957, 1, 29, 4, 38, 19, 498, DateTimeKind.Local).AddTicks(4886), "824580204", "Willis", "Willis Rippin", "(419) 930-6220", null },
                    { 33, "Breitenberg", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Kurt_Breitenberg47@yahoo.com", new DateTime(1984, 8, 30, 9, 31, 6, 970, DateTimeKind.Local).AddTicks(8637), "755436862", "Kurt", "Kurt Breitenberg", "229-524-6486", null },
                    { 30, "Anderson", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Lynne_Anderson83@yahoo.com", new DateTime(1989, 3, 27, 3, 52, 54, 33, DateTimeKind.Local).AddTicks(2156), "235019084", "Lynne", "Lynne Anderson", "(884) 537-4691 x215", null },
                    { 31, "Reinger", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Tonya_Reinger@hotmail.com", new DateTime(1963, 11, 27, 3, 44, 13, 789, DateTimeKind.Local).AddTicks(1605), "733479495", "Tonya", "Tonya Reinger", "1-281-992-5609", null },
                    { 29, "Gaylord", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Nora.Gaylord92@gmail.com", new DateTime(1990, 8, 16, 4, 42, 25, 991, DateTimeKind.Local).AddTicks(5925), "481159066", "Nora", "Nora Gaylord", "(685) 994-0608", null },
                    { 37, "Klocko", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Donna_Klocko@hotmail.com", new DateTime(1983, 11, 23, 8, 56, 58, 412, DateTimeKind.Local).AddTicks(5534), "785264540", "Donna", "Donna Klocko", "703-875-8460 x316", null },
                    { 28, "Hackett", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Harold6@gmail.com", new DateTime(1968, 9, 28, 18, 42, 57, 134, DateTimeKind.Local).AddTicks(9670), "928935558", "Harold", "Harold Hackett", "566-666-5008 x2867", null },
                    { 32, "Kovacek", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Byron_Kovacek26@hotmail.com", new DateTime(1987, 7, 21, 10, 43, 50, 647, DateTimeKind.Local).AddTicks(2208), "606355350", "Byron", "Byron Kovacek", "765-862-9490", null },
                    { 38, "Lesch", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Heidi.Lesch@gmail.com", new DateTime(1998, 10, 29, 16, 21, 59, 982, DateTimeKind.Local).AddTicks(7964), "430956040", "Heidi", "Heidi Lesch", "1-219-668-8971", null },
                    { 47, "Marvin", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Aubrey33@gmail.com", new DateTime(1966, 8, 18, 18, 32, 51, 734, DateTimeKind.Local).AddTicks(381), "414912778", "Aubrey", "Aubrey Marvin", "(342) 599-6284", null },
                    { 40, "Hauck", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Jennie62@yahoo.com", new DateTime(1989, 12, 3, 1, 12, 30, 865, DateTimeKind.Local).AddTicks(3178), "112084652", "Jennie", "Jennie Hauck", "1-213-511-7243", null },
                    { 41, "Gleason", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Mark_Gleason@gmail.com", new DateTime(1980, 5, 5, 19, 14, 11, 25, DateTimeKind.Local).AddTicks(8936), "560267639", "Mark", "Mark Gleason", "830.584.5389", null },
                    { 42, "Tremblay", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Bernadette48@yahoo.com", new DateTime(1970, 9, 14, 20, 59, 5, 80, DateTimeKind.Local).AddTicks(6297), "139488217", "Bernadette", "Bernadette Tremblay", "1-576-752-4468", null },
                    { 44, "Abernathy", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Rolando.Abernathy@yahoo.com", new DateTime(1988, 5, 29, 22, 44, 13, 617, DateTimeKind.Local).AddTicks(8478), "916886541", "Rolando", "Rolando Abernathy", "904-217-1889 x77259", null },
                    { 45, "Kemmer", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Lena.Kemmer@gmail.com", new DateTime(1982, 1, 13, 9, 18, 26, 80, DateTimeKind.Local).AddTicks(564), "882534385", "Lena", "Lena Kemmer", "(770) 222-2509 x671", null },
                    { 46, "Waters", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Charlie_Waters@hotmail.com", new DateTime(1968, 6, 8, 6, 47, 11, 265, DateTimeKind.Local).AddTicks(5876), "903792550", "Charlie", "Charlie Waters", "545-879-4019 x92779", null },
                    { 48, "Swift", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Timmy25@yahoo.com", new DateTime(1972, 1, 23, 16, 46, 28, 854, DateTimeKind.Local).AddTicks(259), "815637339", "Timmy", "Timmy Swift", "423.889.8104 x6460", null },
                    { 49, "Powlowski", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Gail63@yahoo.com", new DateTime(1995, 3, 24, 14, 27, 32, 107, DateTimeKind.Local).AddTicks(8090), "600491711", "Gail", "Gail Powlowski", "(791) 898-8881 x9626", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 50, "Wiza", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Theresa.Wiza34@hotmail.com", new DateTime(1975, 12, 16, 1, 38, 32, 145, DateTimeKind.Local).AddTicks(9380), "972042923", "Theresa", "Theresa Wiza", "675.457.5615 x41576", null },
                    { 27, "Gleichner", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Adam29@hotmail.com", new DateTime(1990, 4, 27, 11, 37, 6, 296, DateTimeKind.Local).AddTicks(2373), "647479810", "Adam", "Adam Gleichner", "670.341.4713 x26105", null },
                    { 39, "Kuhn", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Bradford_Kuhn91@gmail.com", new DateTime(1972, 8, 18, 22, 18, 4, 491, DateTimeKind.Local).AddTicks(9068), "296762302", "Bradford", "Bradford Kuhn", "(691) 331-4336 x904", null },
                    { 26, "Mante", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Tanya86@hotmail.com", new DateTime(1988, 10, 5, 7, 16, 17, 764, DateTimeKind.Local).AddTicks(918), "483965819", "Tanya", "Tanya Mante", "(872) 302-3034", null },
                    { 43, "Konopelski", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Raymond44@yahoo.com", new DateTime(1983, 2, 16, 6, 20, 48, 840, DateTimeKind.Local).AddTicks(560), "458507001", "Raymond", "Raymond Konopelski", "796.547.4060", null },
                    { 24, "Bayer", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Kristie.Bayer31@yahoo.com", new DateTime(1963, 10, 29, 21, 9, 37, 149, DateTimeKind.Local).AddTicks(9809), "455296164", "Kristie", "Kristie Bayer", "711-859-2590 x0834", null },
                    { 1, "Carter", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Marsha.Carter@gmail.com", new DateTime(1983, 11, 14, 9, 1, 50, 240, DateTimeKind.Local).AddTicks(6708), "870185972", "Marsha", "Marsha Carter", "574-925-4958 x14610", null },
                    { 2, "Dibbert", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Kristy8@hotmail.com", new DateTime(1998, 4, 2, 2, 22, 31, 749, DateTimeKind.Local).AddTicks(7617), "157234852", "Kristy", "Kristy Dibbert", "374-959-5223", null },
                    { 3, "Cronin", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Corey_Cronin71@yahoo.com", new DateTime(1987, 4, 26, 11, 30, 32, 43, DateTimeKind.Local).AddTicks(9322), "951351445", "Corey", "Corey Cronin", "1-527-440-4324 x51677", null },
                    { 4, "Goyette", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Ben_Goyette@hotmail.com", new DateTime(1957, 11, 11, 5, 36, 18, 17, DateTimeKind.Local).AddTicks(9985), "911068439", "Ben", "Ben Goyette", "796-719-4626 x206", null },
                    { 5, "Swift", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Samantha_Swift@gmail.com", new DateTime(1967, 9, 25, 17, 13, 27, 183, DateTimeKind.Local).AddTicks(136), "879827282", "Samantha", "Samantha Swift", "749.808.3497 x09149", null },
                    { 6, "Wolff", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Byron13@gmail.com", new DateTime(1995, 7, 27, 5, 1, 4, 176, DateTimeKind.Local).AddTicks(5250), "830401910", "Byron", "Byron Wolff", "(760) 631-3100 x081", null },
                    { 7, "O'Reilly", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Shawna42@yahoo.com", new DateTime(1979, 1, 11, 16, 13, 40, 935, DateTimeKind.Local).AddTicks(5122), "730959450", "Shawna", "Shawna O'Reilly", "846-535-9913 x972", null },
                    { 8, "Boehm", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Bessie13@yahoo.com", new DateTime(1998, 2, 27, 11, 37, 49, 955, DateTimeKind.Local).AddTicks(8093), "817999275", "Bessie", "Bessie Boehm", "261-991-0769 x473", null },
                    { 9, "Kunde", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Gilbert.Kunde54@hotmail.com", new DateTime(1963, 10, 12, 14, 4, 52, 705, DateTimeKind.Local).AddTicks(7556), "131779351", "Gilbert", "Gilbert Kunde", "844.760.7853", null },
                    { 10, "Hilll", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Caroline.Hilll75@hotmail.com", new DateTime(1992, 8, 20, 11, 50, 52, 378, DateTimeKind.Local).AddTicks(5740), "635625218", "Caroline", "Caroline Hilll", "315-435-0398", null },
                    { 11, "Moore", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Jeff.Moore@yahoo.com", new DateTime(1993, 3, 3, 13, 11, 24, 702, DateTimeKind.Local).AddTicks(1615), "429449281", "Jeff", "Jeff Moore", "403.790.8463 x7280", null },
                    { 25, "Mayert", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Kathryn45@hotmail.com", new DateTime(1964, 4, 18, 10, 28, 27, 742, DateTimeKind.Local).AddTicks(2799), "626565371", "Kathryn", "Kathryn Mayert", "(645) 432-2104", null },
                    { 13, "Ortiz", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Luz.Ortiz92@gmail.com", new DateTime(1991, 1, 19, 16, 41, 14, 551, DateTimeKind.Local).AddTicks(1575), "448310139", "Luz", "Luz Ortiz", "841-572-3832 x21321", null },
                    { 23, "Watsica", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Tim57@gmail.com", new DateTime(1959, 5, 30, 0, 21, 35, 896, DateTimeKind.Local).AddTicks(6816), "905183967", "Tim", "Tim Watsica", "719-300-4789 x234", null },
                    { 12, "Stiedemann", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Terri79@yahoo.com", new DateTime(1965, 10, 19, 23, 55, 57, 876, DateTimeKind.Local).AddTicks(5231), "340229075", "Terri", "Terri Stiedemann", "291.281.0619", null },
                    { 21, "Schroeder", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Tom.Schroeder16@gmail.com", new DateTime(1964, 3, 13, 3, 18, 25, 841, DateTimeKind.Local).AddTicks(1049), "565321005", "Tom", "Tom Schroeder", "(615) 529-4017 x24550", null },
                    { 20, "Rolfson", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Candace81@hotmail.com", new DateTime(1971, 7, 17, 4, 30, 43, 800, DateTimeKind.Local).AddTicks(6772), "458027394", "Candace", "Candace Rolfson", "773-618-2678 x9100", null },
                    { 19, "Quitzon", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Raymond49@hotmail.com", new DateTime(1977, 9, 28, 0, 32, 58, 223, DateTimeKind.Local).AddTicks(871), "906560475", "Raymond", "Raymond Quitzon", "1-846-797-5205 x361", null },
                    { 22, "Watsica", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Marilyn_Watsica@yahoo.com", new DateTime(1994, 5, 10, 6, 33, 23, 960, DateTimeKind.Local).AddTicks(7238), "196668331", "Marilyn", "Marilyn Watsica", "(294) 513-6917 x342", null },
                    { 17, "MacGyver", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Betty.MacGyver@hotmail.com", new DateTime(1959, 1, 23, 13, 2, 52, 45, DateTimeKind.Local).AddTicks(6837), "707913001", "Betty", "Betty MacGyver", "382.387.3654", null },
                    { 16, "Huel", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Marshall98@yahoo.com", new DateTime(2000, 8, 18, 0, 12, 55, 601, DateTimeKind.Local).AddTicks(6861), "175325557", "Marshall", "Marshall Huel", "(515) 455-1301", null },
                    { 15, "Nicolas", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Joe44@yahoo.com", new DateTime(1981, 7, 9, 22, 3, 8, 88, DateTimeKind.Local).AddTicks(2175), "854428392", "Joe", "Joe Nicolas", "478.993.2235 x4662", null },
                    { 14, "Reilly", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Jana.Reilly@yahoo.com", new DateTime(2000, 11, 6, 19, 37, 24, 58, DateTimeKind.Local).AddTicks(7150), "332069663", "Jana", "Jana Reilly", "1-320-885-0328", null },
                    { 18, "Jenkins", new DateTime(2021, 9, 21, 15, 40, 12, 176, DateTimeKind.Local).AddTicks(8136), "Juan Leon", "Gwen.Jenkins@gmail.com", new DateTime(1976, 7, 29, 14, 27, 35, 235, DateTimeKind.Local).AddTicks(4533), "376369521", "Gwen", "Gwen Jenkins", "(851) 627-8747", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Marca", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7408), "Juan Leon", 2, null, "Michel Ancel", null },
                    { 22, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7422), "Juan Leon", 8, null, "Hironobu Sakaguchi", null },
                    { 21, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7420), "Juan Leon", 7, null, "Keiji Inafune", null },
                    { 20, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7419), "Juan Leon", 0, null, "John Carmack", null },
                    { 19, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7417), "Juan Leon", 6, null, "Sid Meier", null },
                    { 18, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7416), "Juan Leon", 4, null, "Yuji Naka", null },
                    { 17, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7414), "Juan Leon", 6, null, "Yuji Horii", null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7413), "Juan Leon", 2, null, "John Romero", null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7411), "Juan Leon", 7, null, "Warren Spector", null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7407), "Juan Leon", 8, null, "Amy Hennig", null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7410), "Juan Leon", 5, null, "Goichi Suda", null },
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7404), "Juan Leon", 3, null, "Yoko Taro", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Marca", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7402), "Juan Leon", 4, null, "Tom Howard", null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7405), "Juan Leon", 6, null, "Shigeru Miyamoto", null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7400), "Juan Leon", 5, null, "Gabe Newell", null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7399), "Juan Leon", 4, null, "Yves Guillemot", null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7397), "Juan Leon", 0, null, "Fumito Ueda", null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7396), "Juan Leon", 7, null, "Ken Levine", null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7394), "Juan Leon", 0, null, "Tim Schafer", null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7392), "Juan Leon", 7, null, "Hidetaka Miyazaki", null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(7387), "Juan Leon", 0, null, "Will Wriths", null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(6922), "Juan Leon", 2, null, "Hideo Kojima", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 142, DateTimeKind.Local).AddTicks(7304), "Juan Leon", "Error", null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 142, DateTimeKind.Local).AddTicks(7303), "Juan Leon", "Prestamo", null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 142, DateTimeKind.Local).AddTicks(7301), "Juan Leon", "Devuelto", null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 142, DateTimeKind.Local).AddTicks(7297), "Juan Leon", "Inactivo", null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 142, DateTimeKind.Local).AddTicks(6786), "Juan Leon", "Activo", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DirectorId", "Id_Director", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9741), "Juan Leon", null, 18, new DateTime(2017, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 21148.0, 12, null },
                    { 30, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9744), "Juan Leon", null, 17, new DateTime(2010, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 20352.0, 13, null },
                    { 31, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9747), "Juan Leon", null, 12, new DateTime(1995, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 17497.0, 11, null },
                    { 32, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9749), "Juan Leon", null, 21, new DateTime(2014, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 23371.0, 3, null },
                    { 28, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9735), "Juan Leon", null, 10, new DateTime(1999, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 20706.0, 12, null },
                    { 33, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9751), "Juan Leon", null, 11, new DateTime(2002, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 24077.0, 8, null },
                    { 34, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9754), "Juan Leon", null, 15, new DateTime(2018, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 24890.0, 5, null },
                    { 35, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9756), "Juan Leon", null, 3, new DateTime(2015, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 23220.0, 9, null },
                    { 36, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9759), "Juan Leon", null, 15, new DateTime(1996, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 17418.0, 13, null },
                    { 37, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9762), "Juan Leon", null, 11, new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 22592.0, 9, null },
                    { 38, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9765), "Juan Leon", null, 10, new DateTime(2004, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 17745.0, 9, null },
                    { 46, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9785), "Juan Leon", null, 5, new DateTime(2000, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 16816.0, 5, null },
                    { 40, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9770), "Juan Leon", null, 6, new DateTime(2011, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 21269.0, 2, null },
                    { 41, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9772), "Juan Leon", null, 2, new DateTime(2009, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 22784.0, 6, null },
                    { 42, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9774), "Juan Leon", null, 2, new DateTime(2017, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 20167.0, 8, null },
                    { 43, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9777), "Juan Leon", null, 8, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 24281.0, 11, null },
                    { 44, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9780), "Juan Leon", null, 21, new DateTime(2003, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 15808.0, 13, null },
                    { 45, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9783), "Juan Leon", null, 8, new DateTime(2000, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 21547.0, 8, null },
                    { 47, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9788), "Juan Leon", null, 7, new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 16435.0, 5, null },
                    { 48, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9790), "Juan Leon", null, 11, new DateTime(2007, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 22439.0, 10, null },
                    { 49, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9792), "Juan Leon", null, 16, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 24203.0, 11, null },
                    { 50, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9795), "Juan Leon", null, 19, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 18493.0, 2, null },
                    { 27, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9733), "Juan Leon", null, 10, new DateTime(2017, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 17065.0, 8, null },
                    { 39, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9767), "Juan Leon", null, 1, new DateTime(2008, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 21834.0, 8, null },
                    { 26, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9730), "Juan Leon", null, 16, new DateTime(1995, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 24897.0, 10, null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9643), "Juan Leon", null, 7, new DateTime(2015, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 17290.0, 11, null },
                    { 24, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9726), "Juan Leon", null, 12, new DateTime(2005, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 17859.0, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DirectorId", "Id_Director", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9121), "Juan Leon", null, 2, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 20407.0, 14, null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9628), "Juan Leon", null, 20, new DateTime(2001, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 18682.0, 7, null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9633), "Juan Leon", null, 15, new DateTime(2011, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 19122.0, 3, null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9636), "Juan Leon", null, 21, new DateTime(2008, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 21268.0, 14, null },
                    { 25, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9728), "Juan Leon", null, 19, new DateTime(1996, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 24058.0, 5, null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9641), "Juan Leon", null, 18, new DateTime(2013, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 24416.0, 14, null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9646), "Juan Leon", null, 15, new DateTime(2008, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 23691.0, 10, null },
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9649), "Juan Leon", null, 2, new DateTime(1996, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 21078.0, 5, null },
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9651), "Juan Leon", null, 6, new DateTime(2014, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 16723.0, 14, null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9654), "Juan Leon", null, 2, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 19245.0, 11, null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9656), "Juan Leon", null, 14, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 18195.0, 6, null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9639), "Juan Leon", null, 18, new DateTime(2004, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 24703.0, 5, null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9664), "Juan Leon", null, 9, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 22347.0, 14, null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9667), "Juan Leon", null, 3, new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 23483.0, 10, null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9670), "Juan Leon", null, 13, new DateTime(2017, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 21598.0, 8, null },
                    { 17, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9672), "Juan Leon", null, 16, new DateTime(2004, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 21201.0, 9, null },
                    { 18, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9710), "Juan Leon", null, 7, new DateTime(2013, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 23937.0, 5, null },
                    { 19, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9713), "Juan Leon", null, 1, new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 20907.0, 5, null },
                    { 20, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9715), "Juan Leon", null, 5, new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 24457.0, 2, null },
                    { 21, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9718), "Juan Leon", null, 19, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 22699.0, 13, null },
                    { 22, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9720), "Juan Leon", null, 21, new DateTime(2003, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 16738.0, 2, null },
                    { 23, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9723), "Juan Leon", null, 14, new DateTime(2006, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 17988.0, 14, null },
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 221, DateTimeKind.Local).AddTicks(9662), "Juan Leon", null, 20, new DateTime(2008, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 22104.0, 13, null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8361), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8359), "Juan Leon", "Rockstar", null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8358), "Juan Leon", "Nintendo", null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8357), "Juan Leon", "Activision", null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8353), "Juan Leon", "EA", null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8354), "Juan Leon", "Ubisoft", null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8349), "Juan Leon", "Sony", null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(7886), "Juan Leon", "Microsoft", null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(8355), "Juan Leon", "Rovio", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9723), "Juan Leon", "PlayStation 4", null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9730), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9729), "Juan Leon", "Android", null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9728), "Juan Leon", "Nintendo Switch", null },
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9727), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9725), "Juan Leon", "Nintendo 64", null },
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9722), "Juan Leon", "PlayStation 3", null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9724), "Juan Leon", "PlayStation 5", null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9719), "Juan Leon", "PlayStation", null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9258), "Juan Leon", "PC", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9710), "Juan Leon", "Xbox", null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9714), "Juan Leon", "Xbox 360", null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9720), "Juan Leon", "PlayStation 2", null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9717), "Juan Leon", "Xbox X", null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9718), "Juan Leon", "PSP Vita", null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(9715), "Juan Leon", "Xbox ONE", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 74, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 35, 8, null, null, null },
                    { 66, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 15, 13, null, null, null },
                    { 73, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 27, 9, null, null, null },
                    { 72, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 32, 2, null, null, null },
                    { 71, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 18, 3, null, null, null },
                    { 70, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 4, 1, null, null, null },
                    { 69, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 14, null, null, null },
                    { 68, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 12, 15, null, null, null },
                    { 67, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 23, 8, null, null, null },
                    { 65, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 5, 10, null, null, null },
                    { 61, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 11, 6, null, null, null },
                    { 63, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 44, 10, null, null, null },
                    { 62, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 33, 13, null, null, null },
                    { 75, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 44, 5, null, null, null },
                    { 60, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 9, 1, null, null, null },
                    { 59, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 37, 15, null, null, null },
                    { 58, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 22, 0, null, null, null },
                    { 57, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 46, 14, null, null, null },
                    { 56, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 27, 6, null, null, null },
                    { 55, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 46, 11, null, null, null },
                    { 53, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 24, 8, null, null, null },
                    { 64, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 2, null, null, null },
                    { 76, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 37, 11, null, null, null },
                    { 79, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 9, 2, null, null, null },
                    { 78, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 13, 10, null, null, null },
                    { 100, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 38, 13, null, null, null },
                    { 99, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 31, 5, null, null, null },
                    { 98, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 48, 3, null, null, null },
                    { 97, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 8, 3, null, null, null },
                    { 96, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 39, 3, null, null, null },
                    { 95, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 12, 9, null, null, null },
                    { 94, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 30, 0, null, null, null },
                    { 93, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 45, 9, null, null, null },
                    { 92, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 11, 12, null, null, null },
                    { 91, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 45, 13, null, null, null },
                    { 77, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 11, 6, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 90, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 13, 4, null, null, null },
                    { 88, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 37, 0, null, null, null },
                    { 87, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 44, 1, null, null, null },
                    { 86, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 32, 13, null, null, null },
                    { 85, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 34, 7, null, null, null },
                    { 84, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 47, 6, null, null, null },
                    { 83, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 11, null, null, null },
                    { 82, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 28, 4, null, null, null },
                    { 81, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 6, 2, null, null, null },
                    { 80, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 36, 13, null, null, null },
                    { 52, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 47, 10, null, null, null },
                    { 89, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 36, 8, null, null, null },
                    { 51, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 2, 13, null, null, null },
                    { 54, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 13, 10, null, null, null },
                    { 49, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 34, 6, null, null, null },
                    { 22, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 10, 5, null, null, null },
                    { 21, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 39, 4, null, null, null },
                    { 20, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 32, 11, null, null, null },
                    { 19, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 30, 11, null, null, null },
                    { 18, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 46, 7, null, null, null },
                    { 50, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 27, 7, null, null, null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 20, 0, null, null, null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 15, null, null, null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 11, 1, null, null, null },
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 15, 3, null, null, null },
                    { 23, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 30, 0, null, null, null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 16, 9, null, null, null },
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 10, 14, null, null, null },
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 26, 2, null, null, null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 14, null, null, null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 4, 13, null, null, null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 6, 9, null, null, null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 39, 2, null, null, null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 18, 15, null, null, null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 27, 9, null, null, null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 28, 8, null, null, null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 14, 12, null, null, null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 13, 7, null, null, null },
                    { 24, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 19, 14, null, null, null },
                    { 17, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 32, 8, null, null, null },
                    { 26, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 18, 12, null, null, null },
                    { 48, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 18, 7, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 47, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 22, 5, null, null, null },
                    { 46, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 1, 10, null, null, null },
                    { 25, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 26, 12, null, null, null },
                    { 44, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 43, 9, null, null, null },
                    { 43, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 31, 10, null, null, null },
                    { 42, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 26, 9, null, null, null },
                    { 41, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 42, 5, null, null, null },
                    { 40, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 0, 4, null, null, null },
                    { 39, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 12, 0, null, null, null },
                    { 38, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 7, 0, null, null, null },
                    { 45, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 42, 1, null, null, null },
                    { 36, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 14, 13, null, null, null },
                    { 37, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 23, 7, null, null, null },
                    { 27, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 7, 1, null, null, null },
                    { 29, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 21, 15, null, null, null },
                    { 30, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 11, 4, null, null, null },
                    { 28, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 35, 12, null, null, null },
                    { 32, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 28, 12, null, null, null },
                    { 33, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 38, 1, null, null, null },
                    { 34, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 47, 8, null, null, null },
                    { 35, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 46, 14, null, null, null },
                    { 31, new DateTime(2021, 9, 21, 15, 40, 12, 224, DateTimeKind.Local).AddTicks(210), "Juan Leon", 18, 4, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 25, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6955), "Juan Leon", "Faith", null },
                    { 20, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6949), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6950), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6951), "Juan Leon", "Geralt de Rivia", null },
                    { 23, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6953), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6954), "Juan Leon", "Ellie", null },
                    { 26, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6956), "Juan Leon", "Bayonetta", null },
                    { 33, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6965), "Juan Leon", "Lara Croft", null },
                    { 28, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6959), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6960), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6961), "Juan Leon", "Leon S. Kennedy", null },
                    { 31, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6962), "Juan Leon", "Agente 47", null },
                    { 32, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6964), "Juan Leon", "Haytham Kenway", null },
                    { 19, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6947), "Juan Leon", "Link", null },
                    { 27, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6957), "Juan Leon", "Tracer", null },
                    { 18, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6946), "Juan Leon", "Zelda", null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6927), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6944), "Juan Leon", "Joel", null },
                    { 17, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6945), "Juan Leon", "Jill Valentine", null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6415), "Juan Leon", "Mario Bross", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6923), "Juan Leon", "Tommy Vercetti", null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6930), "Juan Leon", "Crash Bandicoot", null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6931), "Juan Leon", "Samus Aran", null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6933), "Juan Leon", "John-117", null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6934), "Juan Leon", "Aiden Perce", null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6929), "Juan Leon", "Natan Drake", null },
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6936), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6938), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6939), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6940), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6941), "Juan Leon", "Vass", null },
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6935), "Juan Leon", "Carl Jhonson", null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 143, DateTimeKind.Local).AddTicks(6943), "Juan Leon", "Gordon Freeman", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 134, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 16, 23, null, null, null },
                    { 133, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 49, 15, null, null, null },
                    { 132, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 1, null, null, null },
                    { 129, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 31, 16, null, null, null },
                    { 130, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 10, null, null, null },
                    { 128, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 14, null, null, null },
                    { 127, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 17, 8, null, null, null },
                    { 135, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 31, null, null, null },
                    { 131, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 13, null, null, null },
                    { 136, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 13, null, null, null },
                    { 143, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 22, 22, null, null, null },
                    { 138, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 40, 7, null, null, null },
                    { 139, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 21, 21, null, null, null },
                    { 140, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 10, null, null, null },
                    { 141, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 10, 2, null, null, null },
                    { 142, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 45, 28, null, null, null },
                    { 126, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 40, 30, null, null, null },
                    { 144, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 11, null, null, null },
                    { 145, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 9, null, null, null },
                    { 146, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 25, null, null, null },
                    { 147, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 11, 17, null, null, null },
                    { 137, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 1, 16, null, null, null },
                    { 125, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 2, null, null, null },
                    { 117, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 24, null, null, null },
                    { 123, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 36, 32, null, null, null },
                    { 102, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 49, 9, null, null, null },
                    { 103, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 14, 9, null, null, null },
                    { 104, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 12, null, null, null },
                    { 105, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 15, 18, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 106, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 31, 30, null, null, null },
                    { 107, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 22, 30, null, null, null },
                    { 108, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 35, 28, null, null, null },
                    { 109, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 30, 28, null, null, null },
                    { 110, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 44, 12, null, null, null },
                    { 111, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 45, 2, null, null, null },
                    { 112, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 24, 16, null, null, null },
                    { 113, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 15, 32, null, null, null },
                    { 114, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 15, 16, null, null, null },
                    { 115, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 8, null, null, null },
                    { 116, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 4, null, null, null },
                    { 148, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 21, 5, null, null, null },
                    { 118, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 36, 24, null, null, null },
                    { 119, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 12, 6, null, null, null },
                    { 120, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 41, 12, null, null, null },
                    { 121, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 28, 22, null, null, null },
                    { 122, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 32, 27, null, null, null },
                    { 124, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 8, null, null, null },
                    { 149, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 13, 19, null, null, null },
                    { 156, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 32, null, null, null },
                    { 151, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 32, 1, null, null, null },
                    { 178, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 27, 21, null, null, null },
                    { 179, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 18, 5, null, null, null },
                    { 180, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 21, null, null, null },
                    { 181, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 10, 11, null, null, null },
                    { 182, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 25, null, null, null },
                    { 183, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 27, 5, null, null, null },
                    { 184, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 6, null, null, null },
                    { 185, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 49, 31, null, null, null },
                    { 186, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 44, 7, null, null, null },
                    { 187, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 6, 17, null, null, null },
                    { 188, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 26, 25, null, null, null },
                    { 189, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 6, null, null, null },
                    { 190, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 30, 24, null, null, null },
                    { 191, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 20, null, null, null },
                    { 192, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 17, null, null, null },
                    { 193, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 7, null, null, null },
                    { 194, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 41, 8, null, null, null },
                    { 195, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 0, null, null, null },
                    { 196, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 27, null, null, null },
                    { 197, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 25, 23, null, null, null },
                    { 198, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 42, 14, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 177, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 17, null, null, null },
                    { 176, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 32, 24, null, null, null },
                    { 175, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 17, null, null, null },
                    { 174, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 2, 18, null, null, null },
                    { 152, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 2, 20, null, null, null },
                    { 153, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 24, 13, null, null, null },
                    { 154, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 43, 28, null, null, null },
                    { 155, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 21, 16, null, null, null },
                    { 101, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 26, 4, null, null, null },
                    { 157, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 35, 21, null, null, null },
                    { 158, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 29, null, null, null },
                    { 159, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 25, 17, null, null, null },
                    { 160, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 10, null, null, null },
                    { 161, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 34, 0, null, null, null },
                    { 150, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 42, 8, null, null, null },
                    { 162, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 34, 29, null, null, null },
                    { 164, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 17, null, null, null },
                    { 165, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 3, 21, null, null, null },
                    { 166, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 27, null, null, null },
                    { 167, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 17, null, null, null },
                    { 168, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 4, null, null, null },
                    { 169, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 9, null, null, null },
                    { 170, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 19, 1, null, null, null },
                    { 171, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 30, null, null, null },
                    { 172, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 44, 16, null, null, null },
                    { 173, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 14, 3, null, null, null },
                    { 163, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 42, 27, null, null, null },
                    { 100, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 32, 21, null, null, null },
                    { 92, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 24, 4, null, null, null },
                    { 98, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 14, null, null, null },
                    { 25, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 15, 23, null, null, null },
                    { 26, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 15, 26, null, null, null },
                    { 27, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 49, 32, null, null, null },
                    { 28, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 25, null, null, null },
                    { 29, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 23, null, null, null },
                    { 30, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 9, null, null, null },
                    { 31, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 11, 5, null, null, null },
                    { 32, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 2, 5, null, null, null },
                    { 33, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 40, 18, null, null, null },
                    { 34, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 14, null, null, null },
                    { 35, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 42, 10, null, null, null },
                    { 36, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 11, 4, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 37, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 12, null, null, null },
                    { 38, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 20, null, null, null },
                    { 39, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 25, 5, null, null, null },
                    { 40, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 22, 18, null, null, null },
                    { 41, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 31, null, null, null },
                    { 42, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 17, 12, null, null, null },
                    { 43, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 10, 19, null, null, null },
                    { 44, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 19, 25, null, null, null },
                    { 45, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 27, null, null, null },
                    { 24, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 19, 23, null, null, null },
                    { 46, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 25, 10, null, null, null },
                    { 23, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 32, 4, null, null, null },
                    { 21, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 15, null, null, null },
                    { 199, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 6, 3, null, null, null },
                    { 1, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 9, null, null, null },
                    { 2, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 41, 14, null, null, null },
                    { 3, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 34, 29, null, null, null },
                    { 4, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 41, 5, null, null, null },
                    { 5, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 34, 7, null, null, null },
                    { 6, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 22, null, null, null },
                    { 7, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 43, 15, null, null, null },
                    { 8, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 8, null, null, null },
                    { 9, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 46, 26, null, null, null },
                    { 10, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 18, 26, null, null, null },
                    { 11, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 4, 29, null, null, null },
                    { 12, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 8, 3, null, null, null },
                    { 13, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 13, null, null, null },
                    { 14, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 21, null, null, null },
                    { 15, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 4, 17, null, null, null },
                    { 16, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 12, null, null, null },
                    { 17, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 13, null, null, null },
                    { 18, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 30, 20, null, null, null },
                    { 19, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 1, 26, null, null, null },
                    { 20, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 3, 0, null, null, null },
                    { 22, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 18, 0, null, null, null },
                    { 47, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 2, 25, null, null, null },
                    { 48, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 19, null, null, null },
                    { 49, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 6, null, null, null },
                    { 76, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 37, 23, null, null, null },
                    { 77, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 13, 32, null, null, null },
                    { 78, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 47, 0, null, null, null },
                    { 79, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 8, 28, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 80, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 19, null, null, null },
                    { 81, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 5, 3, null, null, null },
                    { 82, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 0, 18, null, null, null },
                    { 83, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 44, 31, null, null, null },
                    { 84, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 1, 30, null, null, null },
                    { 85, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 42, 6, null, null, null },
                    { 86, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 15, null, null, null },
                    { 87, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 29, null, null, null },
                    { 88, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 34, 12, null, null, null },
                    { 89, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 19, 7, null, null, null },
                    { 90, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 8, null, null, null },
                    { 91, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 43, 8, null, null, null },
                    { 93, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 33, 16, null, null, null },
                    { 94, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 1, 31, null, null, null },
                    { 95, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 20, 11, null, null, null },
                    { 96, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 45, 7, null, null, null },
                    { 97, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 8, 9, null, null, null },
                    { 75, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 24, 15, null, null, null },
                    { 74, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 2, 27, null, null, null },
                    { 73, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 29, 17, null, null, null },
                    { 72, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 17, null, null, null },
                    { 50, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 10, 3, null, null, null },
                    { 51, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 9, 31, null, null, null },
                    { 52, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 43, 32, null, null, null },
                    { 53, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 24, 5, null, null, null },
                    { 54, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 3, 20, null, null, null },
                    { 55, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 48, 4, null, null, null },
                    { 56, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 12, 31, null, null, null },
                    { 57, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 13, 6, null, null, null },
                    { 58, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 14, 9, null, null, null },
                    { 59, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 41, 22, null, null, null },
                    { 99, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 39, 7, null, null, null },
                    { 60, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 47, 7, null, null, null },
                    { 62, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 38, 0, null, null, null },
                    { 63, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 40, 30, null, null, null },
                    { 64, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 3, 32, null, null, null },
                    { 65, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 30, 13, null, null, null },
                    { 66, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 11, 10, null, null, null },
                    { 67, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 47, 11, null, null, null },
                    { 68, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 18, 2, null, null, null },
                    { 69, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 4, 11, null, null, null },
                    { 70, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 44, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 26, 25, null, null, null });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 7, 5, null, null, null });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 200, new DateTime(2021, 9, 21, 15, 40, 12, 226, DateTimeKind.Local).AddTicks(8499), "Juan Leon", 47, 3, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ClienteId",
                table: "Alquiler",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_EstadoId",
                table: "Alquiler",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Dets_AlquilerId",
                table: "Alquiler_Dets",
                column: "AlquilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_Dets_JuegoId",
                table: "Alquiler_Dets",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_MarcaId",
                table: "Director",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Juego_DirectorId",
                table: "Juego",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Plataforma_Juego_JuegoId",
                table: "Plataforma_Juego",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plataforma_Juego_PlataformaId",
                table: "Plataforma_Juego",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_Protagonista_Juego_JuegoId",
                table: "Protagonista_Juego",
                column: "JuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Protagonista_Juego_ProtagonistaId",
                table: "Protagonista_Juego",
                column: "ProtagonistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquiler_Dets");

            migrationBuilder.DropTable(
                name: "Plataforma_Juego");

            migrationBuilder.DropTable(
                name: "Protagonista_Juego");

            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Plataforma");

            migrationBuilder.DropTable(
                name: "Juego");

            migrationBuilder.DropTable(
                name: "Protagonista");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
