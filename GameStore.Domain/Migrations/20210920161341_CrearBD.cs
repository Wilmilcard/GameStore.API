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
                    { 1, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 3, null, 144266.0 },
                    { 73, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4, null, 69230.0 },
                    { 72, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, null, 98592.0 },
                    { 71, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, null, 131307.0 },
                    { 70, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 4, null, 117748.0 },
                    { 69, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 109009.0 },
                    { 68, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 3, null, 89115.0 },
                    { 67, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 3, null, 47295.0 },
                    { 66, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, null, 25999.0 },
                    { 65, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, null, 131885.0 },
                    { 64, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null, 51576.0 },
                    { 63, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 3, null, 100718.0 },
                    { 62, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, null, 29620.0 },
                    { 61, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, null, 34950.0 },
                    { 60, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4, null, 94581.0 },
                    { 59, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 3, null, 62735.0 },
                    { 58, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 3, null, 103362.0 },
                    { 57, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 4, null, 42133.0 },
                    { 56, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, null, 31750.0 },
                    { 55, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4, null, 94388.0 },
                    { 54, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, null, 81953.0 },
                    { 53, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4, null, 78766.0 },
                    { 74, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4, null, 86318.0 },
                    { 75, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 4, null, 114466.0 },
                    { 76, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, 85521.0 },
                    { 77, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4, null, 93346.0 },
                    { 100, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 4, null, 38628.0 },
                    { 99, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null, 127018.0 },
                    { 98, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 4, null, 42593.0 },
                    { 97, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, null, 75599.0 },
                    { 96, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 3, null, 144110.0 },
                    { 95, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 4, null, 51241.0 },
                    { 94, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 3, null, 143466.0 },
                    { 93, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 4, null, 56111.0 },
                    { 92, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, null, 141635.0 },
                    { 91, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 4, null, 40895.0 },
                    { 52, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, null, 26491.0 },
                    { 90, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4, null, 38233.0 },
                    { 88, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, null, 114995.0 },
                    { 86, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 4, null, 61561.0 },
                    { 85, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3, null, 69248.0 },
                    { 84, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 4, null, 70035.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "Id_Cliente", "Id_Estado", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 83, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null, 57478.0 },
                    { 82, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 4, null, 143539.0 },
                    { 81, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3, null, 81471.0 },
                    { 80, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3, null, 64542.0 },
                    { 79, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3, null, 56602.0 },
                    { 78, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4, null, 80646.0 },
                    { 89, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4, null, 49101.0 },
                    { 51, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4, null, 130630.0 },
                    { 87, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 3, null, 43594.0 },
                    { 49, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, null, 138703.0 },
                    { 22, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3, null, 137516.0 },
                    { 21, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 86838.0 },
                    { 20, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, null, 113196.0 },
                    { 19, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3, null, 122510.0 },
                    { 18, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, null, 132277.0 },
                    { 17, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 4, null, 42437.0 },
                    { 16, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3, null, 76303.0 },
                    { 15, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 4, null, 25776.0 },
                    { 14, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 3, null, 128993.0 },
                    { 13, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4, null, 57604.0 },
                    { 12, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3, null, 69242.0 },
                    { 11, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 4, null, 98361.0 },
                    { 10, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 3, null, 44937.0 },
                    { 9, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 3, null, 76453.0 },
                    { 7, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 4, null, 50801.0 },
                    { 6, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3, null, 88827.0 },
                    { 5, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null, 63564.0 },
                    { 4, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 4, null, 25926.0 },
                    { 3, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null, 149593.0 },
                    { 2, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, null, 56681.0 },
                    { 50, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 91221.0 },
                    { 23, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3, null, 39548.0 },
                    { 24, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 3, null, 71231.0 },
                    { 8, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 4, null, 86974.0 },
                    { 26, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, null, 118983.0 },
                    { 48, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, null, 85338.0 },
                    { 25, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 4, null, 113192.0 },
                    { 47, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 4, null, 62512.0 },
                    { 46, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, null, 73650.0 },
                    { 45, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4, null, 39628.0 },
                    { 43, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 4, null, 69169.0 },
                    { 42, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 3, null, 26317.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "Id", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "Id_Cliente", "Id_Estado", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 41, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4, null, 148731.0 },
                    { 40, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3, null, 61192.0 },
                    { 39, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 3, null, 88046.0 },
                    { 38, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3, null, 93846.0 },
                    { 44, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4, null, 108903.0 },
                    { 36, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, null, 58028.0 },
                    { 37, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 3, null, 94997.0 },
                    { 29, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 3, null, 136257.0 },
                    { 30, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 4, null, 49877.0 },
                    { 28, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3, null, 46180.0 },
                    { 27, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3, null, 78877.0 },
                    { 31, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, null, 63052.0 },
                    { 33, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 3, null, 46947.0 },
                    { 34, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, null, 118490.0 },
                    { 35, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, null, 44984.0 },
                    { 32, null, new DateTime(2021, 9, 20, 11, 13, 41, 336, DateTimeKind.Local).AddTicks(2331), "Juan Leon", null, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 3, null, 97361.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 204, null, 42693, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 38, 1, null, null, 0.0 },
                    { 203, null, 99993, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 85, 48, null, null, 0.0 },
                    { 202, null, 126208, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 7, 10, null, null, 0.0 },
                    { 205, null, 49310, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 16, 26, null, null, 0.0 },
                    { 201, null, 115967, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 41, 34, null, null, 0.0 },
                    { 200, null, 60032, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 49, null, null, 0.0 },
                    { 199, null, 124310, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 84, 6, null, null, 0.0 },
                    { 195, null, 118892, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 37, null, null, 0.0 },
                    { 197, null, 107656, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 92, 16, null, null, 0.0 },
                    { 196, null, 71981, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 75, 10, null, null, 0.0 },
                    { 194, null, 41540, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 54, 41, null, null, 0.0 },
                    { 193, null, 25118, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 15, 4, null, null, 0.0 },
                    { 206, null, 45723, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 59, 5, null, null, 0.0 },
                    { 192, null, 129606, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 80, 14, null, null, 0.0 },
                    { 191, null, 29655, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 21, 45, null, null, 0.0 },
                    { 198, null, 58817, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 48, null, null, 0.0 },
                    { 207, null, 119142, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 17, null, null, 0.0 },
                    { 218, null, 112874, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 60, 26, null, null, 0.0 },
                    { 209, null, 64060, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 23, 32, null, null, 0.0 },
                    { 224, null, 80502, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 31, 28, null, null, 0.0 },
                    { 190, null, 40265, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 18, 1, null, null, 0.0 },
                    { 223, null, 132081, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 14, 31, null, null, 0.0 },
                    { 222, null, 48977, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 67, 34, null, null, 0.0 },
                    { 221, null, 142058, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 70, 25, null, null, 0.0 },
                    { 220, null, 86640, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 8, null, null, 0.0 },
                    { 219, null, 140947, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 84, 30, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 217, null, 127417, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 9, null, null, 0.0 },
                    { 216, null, 70710, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 99, 40, null, null, 0.0 },
                    { 215, null, 87578, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 95, 37, null, null, 0.0 },
                    { 214, null, 130710, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 53, 14, null, null, 0.0 },
                    { 213, null, 76048, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 51, 34, null, null, 0.0 },
                    { 212, null, 143804, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 50, 25, null, null, 0.0 },
                    { 211, null, 30970, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 75, 7, null, null, 0.0 },
                    { 210, null, 43182, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 93, 18, null, null, 0.0 },
                    { 208, null, 64930, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 33, 20, null, null, 0.0 },
                    { 189, null, 143759, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 95, 11, null, null, 0.0 },
                    { 165, null, 87477, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 4, 29, null, null, 0.0 },
                    { 187, null, 132785, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 60, 18, null, null, 0.0 },
                    { 167, null, 50117, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 72, 29, null, null, 0.0 },
                    { 166, null, 124842, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 47, null, null, 0.0 },
                    { 164, null, 122449, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 23, 13, null, null, 0.0 },
                    { 163, null, 142683, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 43, 31, null, null, 0.0 },
                    { 162, null, 143670, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 56, 24, null, null, 0.0 },
                    { 161, null, 68149, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 62, 9, null, null, 0.0 },
                    { 160, null, 148080, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 12, 36, null, null, 0.0 },
                    { 159, null, 44972, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 74, 23, null, null, 0.0 },
                    { 158, null, 132044, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 10, null, null, 0.0 },
                    { 157, null, 149053, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 31, 26, null, null, 0.0 },
                    { 156, null, 110628, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 25, 35, null, null, 0.0 },
                    { 155, null, 90011, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 67, 27, null, null, 0.0 },
                    { 154, null, 32349, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 31, 49, null, null, 0.0 },
                    { 153, null, 101633, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 17, 28, null, null, 0.0 },
                    { 225, null, 67083, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 98, 0, null, null, 0.0 },
                    { 168, null, 125839, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 28, 5, null, null, 0.0 },
                    { 188, null, 26139, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 72, 42, null, null, 0.0 },
                    { 169, null, 95767, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 29, 14, null, null, 0.0 },
                    { 171, null, 43346, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 0, 39, null, null, 0.0 },
                    { 186, null, 25837, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 90, 22, null, null, 0.0 },
                    { 185, null, 131503, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 24, 13, null, null, 0.0 },
                    { 184, null, 54808, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 98, 36, null, null, 0.0 },
                    { 183, null, 41253, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 14, null, null, 0.0 },
                    { 182, null, 147439, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 94, 4, null, null, 0.0 },
                    { 181, null, 85501, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 32, 1, null, null, 0.0 },
                    { 180, null, 64263, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 27, null, null, 0.0 },
                    { 179, null, 80995, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 35, 4, null, null, 0.0 },
                    { 178, null, 30248, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 36, 27, null, null, 0.0 },
                    { 177, null, 104657, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 41, 44, null, null, 0.0 },
                    { 176, null, 71828, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 43, 49, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 175, null, 118289, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 47, 38, null, null, 0.0 },
                    { 174, null, 61703, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 41, 16, null, null, 0.0 },
                    { 173, null, 67506, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 29, 20, null, null, 0.0 },
                    { 172, null, 90995, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 16, null, null, 0.0 },
                    { 170, null, 71738, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 37, null, null, 0.0 },
                    { 226, null, 63741, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 73, 9, null, null, 0.0 },
                    { 276, null, 74202, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 79, 14, null, null, 0.0 },
                    { 228, null, 50965, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 24, 13, null, null, 0.0 },
                    { 281, null, 135184, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 40, 49, null, null, 0.0 },
                    { 280, null, 56231, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 70, 8, null, null, 0.0 },
                    { 279, null, 71208, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 83, 20, null, null, 0.0 },
                    { 278, null, 31505, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 21, 1, null, null, 0.0 },
                    { 277, null, 86898, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 88, 22, null, null, 0.0 },
                    { 152, null, 36648, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 56, 40, null, null, 0.0 },
                    { 275, null, 54944, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 48, 12, null, null, 0.0 },
                    { 274, null, 55168, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 6, null, null, 0.0 },
                    { 273, null, 107376, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 54, 48, null, null, 0.0 },
                    { 272, null, 128857, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 4, 47, null, null, 0.0 },
                    { 271, null, 148266, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 84, 9, null, null, 0.0 },
                    { 270, null, 128285, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 49, 45, null, null, 0.0 },
                    { 269, null, 57414, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 14, 6, null, null, 0.0 },
                    { 268, null, 55085, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 99, 38, null, null, 0.0 },
                    { 267, null, 112865, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 64, 49, null, null, 0.0 },
                    { 282, null, 71468, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 40, 38, null, null, 0.0 },
                    { 266, null, 110131, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 10, null, null, 0.0 },
                    { 283, null, 97004, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 16, 29, null, null, 0.0 },
                    { 285, null, 126743, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 79, 0, null, null, 0.0 },
                    { 300, null, 74164, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 77, 47, null, null, 0.0 },
                    { 299, null, 71565, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 78, 13, null, null, 0.0 },
                    { 298, null, 119327, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 49, 42, null, null, 0.0 },
                    { 297, null, 120736, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 16, null, null, 0.0 },
                    { 296, null, 113519, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 93, 36, null, null, 0.0 },
                    { 295, null, 30931, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 77, 48, null, null, 0.0 },
                    { 294, null, 44929, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 32, 9, null, null, 0.0 },
                    { 293, null, 47950, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 27, 27, null, null, 0.0 },
                    { 292, null, 52954, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 48, 38, null, null, 0.0 },
                    { 291, null, 115167, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 20, 29, null, null, 0.0 },
                    { 290, null, 31306, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 24, null, null, 0.0 },
                    { 289, null, 127988, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 40, null, null, 0.0 },
                    { 288, null, 143270, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 87, 48, null, null, 0.0 },
                    { 287, null, 27969, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 64, 24, null, null, 0.0 },
                    { 286, null, 119391, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 33, 34, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 284, null, 44630, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 72, 10, null, null, 0.0 },
                    { 227, null, 90876, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 19, 24, null, null, 0.0 },
                    { 265, null, 79010, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 3, 3, null, null, 0.0 },
                    { 263, null, 122119, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 14, null, null, 0.0 },
                    { 243, null, 112080, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 1, 40, null, null, 0.0 },
                    { 242, null, 92855, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 29, 47, null, null, 0.0 },
                    { 241, null, 56695, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 48, null, null, 0.0 },
                    { 240, null, 110779, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 36, 44, null, null, 0.0 },
                    { 239, null, 30498, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 47, 40, null, null, 0.0 },
                    { 238, null, 148561, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 66, 12, null, null, 0.0 },
                    { 237, null, 72445, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 38, null, null, 0.0 },
                    { 236, null, 109293, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 56, 31, null, null, 0.0 },
                    { 235, null, 98296, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 74, 40, null, null, 0.0 },
                    { 234, null, 45963, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 74, 35, null, null, 0.0 },
                    { 233, null, 55939, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 53, 38, null, null, 0.0 },
                    { 232, null, 70840, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 20, null, null, 0.0 },
                    { 231, null, 114173, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 44, 5, null, null, 0.0 },
                    { 230, null, 71308, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 68, 8, null, null, 0.0 },
                    { 229, null, 92811, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 17, 28, null, null, 0.0 },
                    { 244, null, 125576, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 61, 43, null, null, 0.0 },
                    { 264, null, 142753, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 70, 48, null, null, 0.0 },
                    { 245, null, 34294, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 94, 16, null, null, 0.0 },
                    { 247, null, 78557, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 92, 13, null, null, 0.0 },
                    { 262, null, 93176, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 76, 20, null, null, 0.0 },
                    { 261, null, 104847, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 15, 43, null, null, 0.0 },
                    { 260, null, 135569, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 38, 36, null, null, 0.0 },
                    { 259, null, 125610, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 80, 6, null, null, 0.0 },
                    { 258, null, 44491, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 78, 23, null, null, 0.0 },
                    { 257, null, 144127, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 20, 39, null, null, 0.0 },
                    { 256, null, 91990, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 79, 18, null, null, 0.0 },
                    { 255, null, 67975, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 83, 49, null, null, 0.0 },
                    { 254, null, 62670, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 95, 21, null, null, 0.0 },
                    { 253, null, 67871, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 44, 5, null, null, 0.0 },
                    { 252, null, 144782, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 8, null, null, 0.0 },
                    { 251, null, 94565, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 88, 30, null, null, 0.0 },
                    { 250, null, 73181, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 16, 18, null, null, 0.0 },
                    { 249, null, 103962, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 13, null, null, 0.0 },
                    { 248, null, 44408, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 73, 29, null, null, 0.0 },
                    { 246, null, 35851, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 34, 14, null, null, 0.0 },
                    { 151, null, 111718, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 73, 46, null, null, 0.0 },
                    { 112, null, 58606, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 0, 48, null, null, 0.0 },
                    { 149, null, 89431, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 27, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 53, null, 60266, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 75, 21, null, null, 0.0 },
                    { 52, null, 44916, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 97, 28, null, null, 0.0 },
                    { 51, null, 46967, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 1, null, null, 0.0 },
                    { 50, null, 34829, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 27, 11, null, null, 0.0 },
                    { 49, null, 130355, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 41, 17, null, null, 0.0 },
                    { 48, null, 57918, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 15, 6, null, null, 0.0 },
                    { 47, null, 94875, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 53, 47, null, null, 0.0 },
                    { 46, null, 79409, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 2, 43, null, null, 0.0 },
                    { 45, null, 99829, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 63, 8, null, null, 0.0 },
                    { 44, null, 40234, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 87, 38, null, null, 0.0 },
                    { 43, null, 147508, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 44, 10, null, null, 0.0 },
                    { 42, null, 51146, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 40, null, null, 0.0 },
                    { 41, null, 104300, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 34, 43, null, null, 0.0 },
                    { 40, null, 37209, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 1, null, null, 0.0 },
                    { 39, null, 110121, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 63, 13, null, null, 0.0 },
                    { 54, null, 56693, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 67, 29, null, null, 0.0 },
                    { 38, null, 36523, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 61, 27, null, null, 0.0 },
                    { 55, null, 56223, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 10, 13, null, null, 0.0 },
                    { 57, null, 83384, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 32, 5, null, null, 0.0 },
                    { 72, null, 110620, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 65, 18, null, null, 0.0 },
                    { 71, null, 149203, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 52, 14, null, null, 0.0 },
                    { 70, null, 80036, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 5, 1, null, null, 0.0 },
                    { 69, null, 135005, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 40, null, null, 0.0 },
                    { 68, null, 53786, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 56, 15, null, null, 0.0 },
                    { 67, null, 32858, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 99, 42, null, null, 0.0 },
                    { 66, null, 37652, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 14, 14, null, null, 0.0 },
                    { 65, null, 148946, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 12, 24, null, null, 0.0 },
                    { 64, null, 147132, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 93, 16, null, null, 0.0 },
                    { 150, null, 67657, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 61, 49, null, null, 0.0 },
                    { 62, null, 56496, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 97, 44, null, null, 0.0 },
                    { 61, null, 139558, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 23, null, null, 0.0 },
                    { 60, null, 120243, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 13, 34, null, null, 0.0 },
                    { 59, null, 94103, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 20, 29, null, null, 0.0 },
                    { 58, null, 55554, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 43, 5, null, null, 0.0 },
                    { 56, null, 119054, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 90, 44, null, null, 0.0 },
                    { 73, null, 95562, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 26, 6, null, null, 0.0 },
                    { 37, null, 42209, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 28, 14, null, null, 0.0 },
                    { 35, null, 38188, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 6, 35, null, null, 0.0 },
                    { 15, null, 38110, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 17, null, null, 0.0 },
                    { 14, null, 148193, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 32, null, null, 0.0 },
                    { 13, null, 71760, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 72, 49, null, null, 0.0 },
                    { 12, null, 111487, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 3, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 11, null, 88404, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 38, 27, null, null, 0.0 },
                    { 10, null, 33867, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 41, 15, null, null, 0.0 },
                    { 9, null, 117487, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 15, 0, null, null, 0.0 },
                    { 8, null, 142449, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 45, null, null, 0.0 },
                    { 7, null, 107261, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 6, 38, null, null, 0.0 },
                    { 6, null, 57038, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 47, 35, null, null, 0.0 },
                    { 5, null, 109915, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 92, 2, null, null, 0.0 },
                    { 4, null, 45954, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 31, null, null, 0.0 },
                    { 3, null, 126330, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 76, 43, null, null, 0.0 },
                    { 2, null, 123398, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 43, null, null, 0.0 },
                    { 1, null, 51354, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 9, 29, null, null, 0.0 },
                    { 16, null, 41412, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 16, 37, null, null, 0.0 },
                    { 36, null, 108074, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 64, 23, null, null, 0.0 },
                    { 17, null, 122143, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 48, 22, null, null, 0.0 },
                    { 19, null, 132328, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 26, 34, null, null, 0.0 },
                    { 34, null, 42973, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 23, 30, null, null, 0.0 },
                    { 33, null, 103629, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 36, null, null, 0.0 },
                    { 32, null, 75752, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 40, 29, null, null, 0.0 },
                    { 31, null, 34921, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 97, 28, null, null, 0.0 },
                    { 30, null, 120356, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 14, 38, null, null, 0.0 },
                    { 29, null, 60076, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 15, 20, null, null, 0.0 },
                    { 28, null, 75765, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 26, null, null, 0.0 },
                    { 27, null, 67480, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 36, null, null, 0.0 },
                    { 26, null, 139672, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 47, null, null, 0.0 },
                    { 25, null, 101852, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 27, 20, null, null, 0.0 },
                    { 24, null, 95775, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 63, 1, null, null, 0.0 },
                    { 23, null, 65013, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 97, 34, null, null, 0.0 },
                    { 22, null, 82301, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 92, 8, null, null, 0.0 },
                    { 21, null, 132406, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 70, 41, null, null, 0.0 },
                    { 20, null, 95324, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 72, 6, null, null, 0.0 },
                    { 18, null, 55683, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 70, 9, null, null, 0.0 },
                    { 74, null, 120118, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 54, 21, null, null, 0.0 },
                    { 63, null, 107372, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 68, 39, null, null, 0.0 },
                    { 76, null, 106260, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 92, 41, null, null, 0.0 },
                    { 129, null, 97466, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 5, 44, null, null, 0.0 },
                    { 128, null, 105685, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 10, 37, null, null, 0.0 },
                    { 127, null, 43199, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 99, 22, null, null, 0.0 },
                    { 126, null, 37547, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 66, 21, null, null, 0.0 },
                    { 125, null, 55346, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 35, 26, null, null, 0.0 },
                    { 75, null, 141025, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 51, 2, null, null, 0.0 },
                    { 123, null, 67036, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 39, 41, null, null, 0.0 },
                    { 122, null, 110923, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 98, 33, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 121, null, 147167, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 2, 49, null, null, 0.0 },
                    { 120, null, 33940, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 26, 1, null, null, 0.0 },
                    { 119, null, 73743, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 63, 21, null, null, 0.0 },
                    { 118, null, 82126, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 30, 8, null, null, 0.0 },
                    { 117, null, 111086, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 35, 49, null, null, 0.0 },
                    { 116, null, 129996, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 75, 38, null, null, 0.0 },
                    { 115, null, 75446, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 58, 48, null, null, 0.0 },
                    { 130, null, 93220, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 55, 20, null, null, 0.0 },
                    { 114, null, 71660, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 22, null, null, 0.0 },
                    { 131, null, 37485, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 6, 42, null, null, 0.0 },
                    { 133, null, 33489, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 4, 20, null, null, 0.0 },
                    { 148, null, 45760, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 96, 9, null, null, 0.0 },
                    { 147, null, 102047, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 86, 42, null, null, 0.0 },
                    { 146, null, 141084, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 12, 36, null, null, 0.0 },
                    { 145, null, 34874, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 88, 27, null, null, 0.0 },
                    { 144, null, 61787, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 77, 45, null, null, 0.0 },
                    { 143, null, 31265, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 31, 15, null, null, 0.0 },
                    { 142, null, 100338, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 9, 2, null, null, 0.0 },
                    { 141, null, 65651, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 3, 43, null, null, 0.0 },
                    { 140, null, 37040, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 58, 1, null, null, 0.0 },
                    { 139, null, 39619, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 50, 17, null, null, 0.0 },
                    { 138, null, 45091, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 77, 27, null, null, 0.0 },
                    { 137, null, 111649, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 12, 0, null, null, 0.0 },
                    { 136, null, 28707, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 36, 4, null, null, 0.0 },
                    { 135, null, 125893, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 3, 27, null, null, 0.0 },
                    { 134, null, 83769, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 22, null, null, 0.0 },
                    { 132, null, 84418, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 51, 22, null, null, 0.0 },
                    { 113, null, 59608, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 84, 20, null, null, 0.0 },
                    { 124, null, 90870, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 29, null, null, 0.0 },
                    { 111, null, 59260, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 53, 24, null, null, 0.0 },
                    { 91, null, 49689, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 24, 25, null, null, 0.0 },
                    { 90, null, 69134, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 63, 27, null, null, 0.0 },
                    { 89, null, 136751, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 81, 30, null, null, 0.0 },
                    { 88, null, 71935, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 16, 28, null, null, 0.0 },
                    { 87, null, 40486, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 53, 5, null, null, 0.0 },
                    { 86, null, 140006, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 22, 19, null, null, 0.0 },
                    { 92, null, 136655, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 3, null, null, 0.0 },
                    { 85, null, 98388, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 55, 5, null, null, 0.0 },
                    { 83, null, 95410, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 11, 30, null, null, 0.0 },
                    { 81, null, 69796, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 49, 17, null, null, 0.0 },
                    { 80, null, 47443, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 87, 48, null, null, 0.0 },
                    { 79, null, 145946, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 5, 3, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "Id", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "Id_Alquiler", "Id_Juego", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 78, null, 49778, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 37, 49, null, null, 0.0 },
                    { 77, null, 84794, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 20, 29, null, null, 0.0 },
                    { 84, null, 50246, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 89, 23, null, null, 0.0 },
                    { 93, null, 92420, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 56, 15, null, null, 0.0 },
                    { 82, null, 34562, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 30, null, null, 0.0 },
                    { 95, null, 47652, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 46, 28, null, null, 0.0 },
                    { 94, null, 139878, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 8, 20, null, null, 0.0 },
                    { 110, null, 99963, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 4, 40, null, null, 0.0 },
                    { 109, null, 65669, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 51, 19, null, null, 0.0 },
                    { 108, null, 90148, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 73, 49, null, null, 0.0 },
                    { 106, null, 86348, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 17, 22, null, null, 0.0 },
                    { 105, null, 35627, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 42, 40, null, null, 0.0 },
                    { 104, null, 75319, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 29, 4, null, null, 0.0 },
                    { 107, null, 99354, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 44, 16, null, null, 0.0 },
                    { 102, null, 66089, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 87, 20, null, null, 0.0 },
                    { 101, null, 71550, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 24, 3, null, null, 0.0 },
                    { 100, null, 87177, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 24, 32, null, null, 0.0 },
                    { 99, null, 41289, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 82, 2, null, null, 0.0 },
                    { 98, null, 25375, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 52, 9, null, null, 0.0 },
                    { 97, null, 93774, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 93, 4, null, null, 0.0 },
                    { 103, null, 72913, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 81, 26, null, null, 0.0 },
                    { 96, null, 72804, new DateTime(2021, 9, 20, 11, 13, 41, 347, DateTimeKind.Local).AddTicks(2950), "Juan Leon", 26, 40, null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 36, "Yundt", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Willie.Yundt79@yahoo.com", new DateTime(1983, 10, 8, 1, 19, 10, 257, DateTimeKind.Local).AddTicks(1399), "570059630", "Willie", "Willie Yundt", "(430) 963-3884 x927", null },
                    { 35, "Heidenreich", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jill7@hotmail.com", new DateTime(1985, 3, 12, 23, 14, 25, 851, DateTimeKind.Local).AddTicks(9932), "545571626", "Jill", "Jill Heidenreich", "(397) 492-8048 x396", null },
                    { 34, "Daniel", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Kristi_Daniel96@yahoo.com", new DateTime(1996, 11, 15, 4, 0, 55, 344, DateTimeKind.Local).AddTicks(3298), "489304214", "Kristi", "Kristi Daniel", "960.767.0446 x911", null },
                    { 33, "Denesik", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Gladys.Denesik75@yahoo.com", new DateTime(1966, 9, 30, 13, 50, 52, 553, DateTimeKind.Local).AddTicks(4358), "697528683", "Gladys", "Gladys Denesik", "(254) 622-8723 x459", null },
                    { 30, "Beahan", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Alexander33@gmail.com", new DateTime(1984, 12, 15, 2, 58, 6, 371, DateTimeKind.Local).AddTicks(4790), "248023855", "Alexander", "Alexander Beahan", "(573) 769-9357 x8732", null },
                    { 31, "Harber", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Janice_Harber90@yahoo.com", new DateTime(1977, 11, 16, 11, 51, 11, 160, DateTimeKind.Local).AddTicks(9157), "335792857", "Janice", "Janice Harber", "(760) 296-2986 x22186", null },
                    { 29, "Sawayn", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Shannon.Sawayn@hotmail.com", new DateTime(1980, 2, 4, 10, 2, 27, 82, DateTimeKind.Local).AddTicks(4338), "116878392", "Shannon", "Shannon Sawayn", "538-489-2033 x158", null },
                    { 37, "Howell", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Andre79@hotmail.com", new DateTime(1955, 12, 7, 2, 14, 23, 728, DateTimeKind.Local).AddTicks(2931), "258847562", "Andre", "Andre Howell", "742-395-7231 x96949", null },
                    { 28, "Swaniawski", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Roberta_Swaniawski@yahoo.com", new DateTime(1982, 8, 18, 11, 16, 37, 735, DateTimeKind.Local).AddTicks(2911), "605219443", "Roberta", "Roberta Swaniawski", "868-773-2659 x366", null },
                    { 32, "Kertzmann", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Mona_Kertzmann56@yahoo.com", new DateTime(1953, 11, 28, 10, 28, 48, 945, DateTimeKind.Local).AddTicks(4779), "284793484", "Mona", "Mona Kertzmann", "961-720-4407 x6390", null },
                    { 38, "Quitzon", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jody95@yahoo.com", new DateTime(1987, 10, 23, 11, 57, 17, 362, DateTimeKind.Local).AddTicks(2884), "433095210", "Jody", "Jody Quitzon", "(843) 627-9897", null },
                    { 47, "Nikolaus", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Joanne_Nikolaus46@yahoo.com", new DateTime(1976, 9, 20, 11, 5, 4, 939, DateTimeKind.Local).AddTicks(2149), "746247275", "Joanne", "Joanne Nikolaus", "1-480-883-9218 x728", null },
                    { 40, "Johnston", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Owen34@yahoo.com", new DateTime(1979, 12, 10, 0, 52, 51, 937, DateTimeKind.Local).AddTicks(5951), "649941685", "Owen", "Owen Johnston", "1-702-869-3701 x09547", null },
                    { 41, "Stoltenberg", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Ginger.Stoltenberg@yahoo.com", new DateTime(1969, 8, 2, 17, 3, 13, 82, DateTimeKind.Local).AddTicks(6447), "568524902", "Ginger", "Ginger Stoltenberg", "(494) 670-4066 x042", null },
                    { 42, "Price", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Julie_Price12@hotmail.com", new DateTime(1994, 2, 26, 10, 27, 46, 596, DateTimeKind.Local).AddTicks(3636), "943731049", "Julie", "Julie Price", "(446) 805-3857 x7084", null },
                    { 44, "Mosciski", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Debra9@hotmail.com", new DateTime(1986, 8, 26, 12, 9, 7, 61, DateTimeKind.Local).AddTicks(5141), "979907005", "Debra", "Debra Mosciski", "946.920.0374", null },
                    { 45, "Pfannerstill", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Vincent40@hotmail.com", new DateTime(1997, 10, 29, 8, 1, 20, 40, DateTimeKind.Local).AddTicks(3664), "878896737", "Vincent", "Vincent Pfannerstill", "(429) 753-2397", null },
                    { 46, "Hilll", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Bert.Hilll91@gmail.com", new DateTime(1971, 12, 2, 22, 11, 50, 73, DateTimeKind.Local).AddTicks(4383), "808478244", "Bert", "Bert Hilll", "744-346-9899 x6155", null },
                    { 48, "Langworth", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jan.Langworth@yahoo.com", new DateTime(1970, 8, 11, 10, 15, 53, 186, DateTimeKind.Local).AddTicks(1411), "111289392", "Jan", "Jan Langworth", "(399) 947-3164 x647", null },
                    { 49, "Gutmann", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Daniel.Gutmann@hotmail.com", new DateTime(1997, 1, 24, 8, 31, 58, 655, DateTimeKind.Local).AddTicks(2040), "939065201", "Daniel", "Daniel Gutmann", "616-738-0118", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 50, "Rippin", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Ian_Rippin71@yahoo.com", new DateTime(1998, 11, 24, 18, 3, 33, 897, DateTimeKind.Local).AddTicks(9328), "144830285", "Ian", "Ian Rippin", "857-387-7539 x99821", null },
                    { 27, "Tromp", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jenna_Tromp@gmail.com", new DateTime(1953, 6, 8, 3, 20, 49, 739, DateTimeKind.Local).AddTicks(8489), "898079754", "Jenna", "Jenna Tromp", "576-869-2145", null },
                    { 39, "Dickens", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Michael_Dickens@yahoo.com", new DateTime(1995, 9, 15, 7, 45, 37, 175, DateTimeKind.Local).AddTicks(5215), "366904457", "Michael", "Michael Dickens", "1-799-583-2840 x295", null },
                    { 26, "Wintheiser", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Edmund19@hotmail.com", new DateTime(1996, 1, 13, 16, 25, 46, 724, DateTimeKind.Local).AddTicks(7220), "180671971", "Edmund", "Edmund Wintheiser", "1-720-857-0903 x30755", null },
                    { 43, "White", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Ian.White86@gmail.com", new DateTime(1975, 5, 23, 19, 22, 10, 441, DateTimeKind.Local).AddTicks(2757), "866933789", "Ian", "Ian White", "888.448.8772 x3579", null },
                    { 24, "Stoltenberg", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jeanette71@gmail.com", new DateTime(1972, 8, 11, 0, 48, 35, 752, DateTimeKind.Local).AddTicks(7290), "599528544", "Jeanette", "Jeanette Stoltenberg", "221-435-4782", null },
                    { 1, "Feeney", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Ginger.Feeney85@gmail.com", new DateTime(1962, 5, 14, 19, 6, 25, 138, DateTimeKind.Local).AddTicks(2266), "633619044", "Ginger", "Ginger Feeney", "233-284-1387 x990", null },
                    { 2, "Kling", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Marcia73@yahoo.com", new DateTime(1969, 3, 10, 7, 3, 55, 696, DateTimeKind.Local).AddTicks(9445), "718841825", "Marcia", "Marcia Kling", "1-308-406-9698 x34717", null },
                    { 3, "Wuckert", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Lauren.Wuckert12@gmail.com", new DateTime(1973, 3, 15, 14, 23, 54, 660, DateTimeKind.Local).AddTicks(7104), "698090939", "Lauren", "Lauren Wuckert", "836-609-1742 x85807", null },
                    { 4, "Steuber", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Randal.Steuber@hotmail.com", new DateTime(1992, 9, 23, 12, 3, 18, 128, DateTimeKind.Local).AddTicks(8905), "957561560", "Randal", "Randal Steuber", "568.206.6494 x9776", null },
                    { 5, "Halvorson", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Velma65@gmail.com", new DateTime(1973, 8, 6, 1, 12, 59, 26, DateTimeKind.Local).AddTicks(230), "113664525", "Velma", "Velma Halvorson", "261.530.8684", null },
                    { 6, "Kiehn", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Richard_Kiehn43@hotmail.com", new DateTime(1987, 4, 26, 8, 40, 8, 5, DateTimeKind.Local).AddTicks(8089), "519334960", "Richard", "Richard Kiehn", "(337) 926-5466", null },
                    { 7, "Lesch", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Glenn30@gmail.com", new DateTime(1986, 8, 25, 20, 22, 21, 389, DateTimeKind.Local).AddTicks(9010), "855955091", "Glenn", "Glenn Lesch", "519-497-3623 x081", null },
                    { 8, "Price", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Delbert_Price59@hotmail.com", new DateTime(1980, 8, 20, 12, 27, 33, 351, DateTimeKind.Local).AddTicks(999), "683697451", "Delbert", "Delbert Price", "832.590.5021 x35083", null },
                    { 9, "Prosacco", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Danielle.Prosacco57@yahoo.com", new DateTime(1994, 11, 21, 4, 17, 5, 967, DateTimeKind.Local).AddTicks(1265), "578216170", "Danielle", "Danielle Prosacco", "425-668-3875 x97414", null },
                    { 10, "Hessel", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Melinda.Hessel44@gmail.com", new DateTime(1967, 9, 17, 12, 50, 16, 183, DateTimeKind.Local).AddTicks(8921), "286052139", "Melinda", "Melinda Hessel", "(977) 321-8240 x184", null },
                    { 11, "Little", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Lamar.Little@gmail.com", new DateTime(1978, 11, 13, 11, 28, 53, 348, DateTimeKind.Local).AddTicks(9457), "974339467", "Lamar", "Lamar Little", "714.355.2847 x72093", null },
                    { 25, "Ortiz", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Connie.Ortiz23@yahoo.com", new DateTime(1995, 8, 29, 19, 6, 53, 448, DateTimeKind.Local).AddTicks(4718), "251088558", "Connie", "Connie Ortiz", "(388) 945-8556 x060", null },
                    { 13, "Renner", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Elias.Renner@yahoo.com", new DateTime(1972, 8, 24, 7, 6, 34, 303, DateTimeKind.Local).AddTicks(4556), "386998002", "Elias", "Elias Renner", "935-554-8840 x401", null },
                    { 23, "Hilll", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Jaime87@gmail.com", new DateTime(1974, 7, 26, 19, 0, 16, 313, DateTimeKind.Local).AddTicks(700), "632367112", "Jaime", "Jaime Hilll", "1-571-894-9261", null },
                    { 12, "Mayert", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Brittany88@gmail.com", new DateTime(1979, 4, 24, 14, 15, 10, 604, DateTimeKind.Local).AddTicks(8493), "144660200", "Brittany", "Brittany Mayert", "386-762-8386", null },
                    { 21, "Goyette", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Marianne.Goyette@hotmail.com", new DateTime(1957, 4, 17, 19, 33, 44, 658, DateTimeKind.Local).AddTicks(8425), "174465199", "Marianne", "Marianne Goyette", "404.913.4156", null },
                    { 20, "Stracke", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Latoya43@hotmail.com", new DateTime(1962, 10, 19, 1, 20, 32, 236, DateTimeKind.Local).AddTicks(9535), "851300526", "Latoya", "Latoya Stracke", "218.417.2001", null },
                    { 19, "Schoen", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Charlotte_Schoen@hotmail.com", new DateTime(1984, 10, 17, 20, 43, 51, 149, DateTimeKind.Local).AddTicks(7574), "698516314", "Charlotte", "Charlotte Schoen", "1-275-692-7118 x6716", null },
                    { 22, "Borer", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Raul28@hotmail.com", new DateTime(1990, 12, 25, 1, 43, 25, 753, DateTimeKind.Local).AddTicks(1477), "196188923", "Raul", "Raul Borer", "848.295.8666 x2368", null },
                    { 17, "Goodwin", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Abraham_Goodwin@yahoo.com", new DateTime(1997, 5, 11, 16, 20, 27, 69, DateTimeKind.Local).AddTicks(1228), "774007005", "Abraham", "Abraham Goodwin", "889-577-4854 x7477", null },
                    { 16, "Kozey", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Mona_Kozey@hotmail.com", new DateTime(1972, 7, 7, 8, 21, 37, 516, DateTimeKind.Local).AddTicks(2645), "379615379", "Mona", "Mona Kozey", "489-412-9767", null },
                    { 15, "Stokes", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Pam.Stokes@yahoo.com", new DateTime(1989, 12, 6, 9, 34, 5, 13, DateTimeKind.Local).AddTicks(1444), "235260280", "Pam", "Pam Stokes", "1-349-588-0859 x5029", null },
                    { 14, "Lowe", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Christian28@yahoo.com", new DateTime(1985, 9, 30, 21, 31, 52, 485, DateTimeKind.Local).AddTicks(2925), "655661510", "Christian", "Christian Lowe", "1-219-244-9327 x5064", null },
                    { 18, "Boehm", new DateTime(2021, 9, 20, 11, 13, 41, 289, DateTimeKind.Local).AddTicks(7059), "Juan Leon", "Beulah.Boehm53@yahoo.com", new DateTime(1960, 1, 24, 16, 26, 45, 749, DateTimeKind.Local).AddTicks(2787), "261164954", "Beulah", "Beulah Boehm", "(421) 833-0570", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Marca", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7539), "Juan Leon", 2, null, "Michel Ancel", null },
                    { 22, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7553), "Juan Leon", 3, null, "Hironobu Sakaguchi", null },
                    { 21, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7551), "Juan Leon", 1, null, "Keiji Inafune", null },
                    { 20, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7550), "Juan Leon", 6, null, "John Carmack", null },
                    { 19, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7548), "Juan Leon", 2, null, "Sid Meier", null },
                    { 18, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7547), "Juan Leon", 6, null, "Yuji Naka", null },
                    { 17, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7545), "Juan Leon", 3, null, "Yuji Horii", null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7544), "Juan Leon", 0, null, "John Romero", null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7542), "Juan Leon", 4, null, "Warren Spector", null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7537), "Juan Leon", 4, null, "Amy Hennig", null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7540), "Juan Leon", 7, null, "Goichi Suda", null },
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7534), "Juan Leon", 7, null, "Yoko Taro", null }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Marca", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7533), "Juan Leon", 6, null, "Tom Howard", null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7536), "Juan Leon", 1, null, "Shigeru Miyamoto", null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7531), "Juan Leon", 7, null, "Gabe Newell", null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7529), "Juan Leon", 1, null, "Yves Guillemot", null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7528), "Juan Leon", 0, null, "Fumito Ueda", null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7526), "Juan Leon", 6, null, "Ken Levine", null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7524), "Juan Leon", 5, null, "Tim Schafer", null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7522), "Juan Leon", 7, null, "Hidetaka Miyazaki", null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(7517), "Juan Leon", 1, null, "Will Wriths", null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(6908), "Juan Leon", 8, null, "Hideo Kojima", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 253, DateTimeKind.Local).AddTicks(6765), "Juan Leon", "Error", null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 253, DateTimeKind.Local).AddTicks(6763), "Juan Leon", "Prestamo", null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 253, DateTimeKind.Local).AddTicks(6762), "Juan Leon", "Devuelto", null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 253, DateTimeKind.Local).AddTicks(6757), "Juan Leon", "Inactivo", null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 253, DateTimeKind.Local).AddTicks(6232), "Juan Leon", "Activo", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DirectorId", "Id_Director", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9580), "Juan Leon", null, 12, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 0.0, 0, null },
                    { 30, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9582), "Juan Leon", null, 13, new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 0.0, 0, null },
                    { 31, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9584), "Juan Leon", null, 15, new DateTime(1998, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 0.0, 0, null },
                    { 32, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9586), "Juan Leon", null, 17, new DateTime(1997, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 0.0, 0, null },
                    { 28, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9536), "Juan Leon", null, 10, new DateTime(2009, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 0.0, 0, null },
                    { 33, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9588), "Juan Leon", null, 2, new DateTime(1999, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 0.0, 0, null },
                    { 34, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9590), "Juan Leon", null, 6, new DateTime(2002, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 0.0, 0, null },
                    { 35, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9592), "Juan Leon", null, 9, new DateTime(2008, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 0.0, 0, null },
                    { 36, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9594), "Juan Leon", null, 11, new DateTime(2007, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 0.0, 0, null },
                    { 37, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9596), "Juan Leon", null, 17, new DateTime(2018, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 0.0, 0, null },
                    { 38, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9597), "Juan Leon", null, 21, new DateTime(2006, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 0.0, 0, null },
                    { 46, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9612), "Juan Leon", null, 8, new DateTime(2018, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 0.0, 0, null },
                    { 40, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9601), "Juan Leon", null, 18, new DateTime(2017, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 0.0, 0, null },
                    { 41, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9602), "Juan Leon", null, 23, new DateTime(2018, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 0.0, 0, null },
                    { 42, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9604), "Juan Leon", null, 10, new DateTime(2006, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 0.0, 0, null },
                    { 43, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9606), "Juan Leon", null, 23, new DateTime(1999, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 0.0, 0, null },
                    { 44, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9607), "Juan Leon", null, 1, new DateTime(1997, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 0.0, 0, null },
                    { 45, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9609), "Juan Leon", null, 2, new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 0.0, 0, null },
                    { 47, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9613), "Juan Leon", null, 16, new DateTime(2012, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 0.0, 0, null },
                    { 48, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9615), "Juan Leon", null, 13, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 0.0, 0, null },
                    { 49, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9617), "Juan Leon", null, 12, new DateTime(1996, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 0.0, 0, null },
                    { 50, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9621), "Juan Leon", null, 17, new DateTime(1998, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 0.0, 0, null },
                    { 27, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9535), "Juan Leon", null, 2, new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 0.0, 0, null },
                    { 39, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9599), "Juan Leon", null, 21, new DateTime(2002, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 0.0, 0, null },
                    { 26, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9533), "Juan Leon", null, 1, new DateTime(2001, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 0.0, 0, null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9499), "Juan Leon", null, 2, new DateTime(2001, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 0.0, 0, null },
                    { 24, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9530), "Juan Leon", null, 8, new DateTime(2018, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 0.0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DirectorId", "Id_Director", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9006), "Juan Leon", null, 1, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 0.0, 0, null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9488), "Juan Leon", null, 2, new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 0.0, 0, null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9492), "Juan Leon", null, 3, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 0.0, 0, null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9494), "Juan Leon", null, 5, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 0.0, 0, null },
                    { 25, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9531), "Juan Leon", null, 23, new DateTime(2010, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 0.0, 0, null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9497), "Juan Leon", null, 14, new DateTime(2000, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 0.0, 0, null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9500), "Juan Leon", null, 22, new DateTime(2006, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 0.0, 0, null },
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9502), "Juan Leon", null, 20, new DateTime(2010, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 0.0, 0, null },
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9504), "Juan Leon", null, 16, new DateTime(2015, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 0.0, 0, null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9506), "Juan Leon", null, 19, new DateTime(2020, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 0.0, 0, null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9508), "Juan Leon", null, 18, new DateTime(2010, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 0.0, 0, null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9495), "Juan Leon", null, 4, new DateTime(2007, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 0.0, 0, null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9512), "Juan Leon", null, 4, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 0.0, 0, null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9514), "Juan Leon", null, 8, new DateTime(2006, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 0.0, 0, null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9515), "Juan Leon", null, 7, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 0.0, 0, null },
                    { 17, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9517), "Juan Leon", null, 7, new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 0.0, 0, null },
                    { 18, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9519), "Juan Leon", null, 7, new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 0.0, 0, null },
                    { 19, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9520), "Juan Leon", null, 6, new DateTime(1998, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 0.0, 0, null },
                    { 20, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9522), "Juan Leon", null, 4, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 0.0, 0, null },
                    { 21, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9524), "Juan Leon", null, 11, new DateTime(1996, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 0.0, 0, null },
                    { 22, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9526), "Juan Leon", null, 12, new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 0.0, 0, null },
                    { 23, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9528), "Juan Leon", null, 12, new DateTime(2011, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 0.0, 0, null },
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 337, DateTimeKind.Local).AddTicks(9510), "Juan Leon", null, 3, new DateTime(2011, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 0.0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8292), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8291), "Juan Leon", "Rockstar", null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8290), "Juan Leon", "Nintendo", null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8236), "Juan Leon", "Activision", null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8232), "Juan Leon", "EA", null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8233), "Juan Leon", "Ubisoft", null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8228), "Juan Leon", "Sony", null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(7684), "Juan Leon", "Microsoft", null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(8235), "Juan Leon", "Rovio", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9629), "Juan Leon", "PlayStation 4", null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9637), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9636), "Juan Leon", "Android", null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9634), "Juan Leon", "Nintendo Switch", null },
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9633), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9632), "Juan Leon", "Nintendo 64", null },
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9628), "Juan Leon", "PlayStation 3", null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9631), "Juan Leon", "PlayStation 5", null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9626), "Juan Leon", "PlayStation", null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9154), "Juan Leon", "PC", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9617), "Juan Leon", "Xbox", null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9621), "Juan Leon", "Xbox 360", null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9627), "Juan Leon", "PlayStation 2", null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9623), "Juan Leon", "Xbox X", null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9625), "Juan Leon", "PSP Vita", null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(9622), "Juan Leon", "Xbox ONE", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 74, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 39, 2, null, null, null },
                    { 66, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 49, 15, null, null, null },
                    { 73, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 23, 9, null, null, null },
                    { 72, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 44, 14, null, null, null },
                    { 71, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 10, 1, null, null, null },
                    { 70, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 34, 12, null, null, null },
                    { 69, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 19, 7, null, null, null },
                    { 68, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 0, 3, null, null, null },
                    { 67, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 39, 7, null, null, null },
                    { 65, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 40, 12, null, null, null },
                    { 61, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 7, 12, null, null, null },
                    { 63, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 12, 11, null, null, null },
                    { 62, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 44, 0, null, null, null },
                    { 75, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 32, 12, null, null, null },
                    { 60, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 33, 6, null, null, null },
                    { 59, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 27, 4, null, null, null },
                    { 58, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 47, 7, null, null, null },
                    { 57, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 17, 10, null, null, null },
                    { 56, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 31, 0, null, null, null },
                    { 55, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 26, 13, null, null, null },
                    { 53, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 26, 7, null, null, null },
                    { 64, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 8, 9, null, null, null },
                    { 76, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 12, 0, null, null, null },
                    { 79, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 25, 3, null, null, null },
                    { 78, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 43, 2, null, null, null },
                    { 100, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 1, 12, null, null, null },
                    { 99, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 18, 2, null, null, null },
                    { 98, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 26, 12, null, null, null },
                    { 97, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 4, 14, null, null, null },
                    { 96, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 34, 2, null, null, null },
                    { 95, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 30, 13, null, null, null },
                    { 94, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 36, 13, null, null, null },
                    { 93, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 26, 15, null, null, null },
                    { 92, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 48, 0, null, null, null },
                    { 91, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 47, 0, null, null, null },
                    { 77, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 11, 15, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 90, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 28, 10, null, null, null },
                    { 88, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 8, 0, null, null, null },
                    { 87, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 28, 13, null, null, null },
                    { 86, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 3, 1, null, null, null },
                    { 85, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 32, 11, null, null, null },
                    { 84, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 13, 13, null, null, null },
                    { 83, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 42, 10, null, null, null },
                    { 82, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 36, 11, null, null, null },
                    { 81, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 13, 7, null, null, null },
                    { 80, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 17, 12, null, null, null },
                    { 52, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 13, 9, null, null, null },
                    { 89, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 45, 15, null, null, null },
                    { 51, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 47, 6, null, null, null },
                    { 54, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 3, 8, null, null, null },
                    { 49, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 14, 14, null, null, null },
                    { 22, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 41, 0, null, null, null },
                    { 21, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 19, 12, null, null, null },
                    { 20, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 6, 5, null, null, null },
                    { 19, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 48, 6, null, null, null },
                    { 18, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 30, 12, null, null, null },
                    { 50, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 17, 0, null, null, null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 28, 3, null, null, null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 31, 11, null, null, null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 3, 7, null, null, null },
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 5, 9, null, null, null },
                    { 23, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 40, 2, null, null, null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 7, 4, null, null, null },
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 18, 15, null, null, null },
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 21, 5, null, null, null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 32, 13, null, null, null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 22, 12, null, null, null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 1, 11, null, null, null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 30, 4, null, null, null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 4, 1, null, null, null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 6, 2, null, null, null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 6, 11, null, null, null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 10, 5, null, null, null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 2, 11, null, null, null },
                    { 24, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 0, 6, null, null, null },
                    { 17, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 24, 13, null, null, null },
                    { 26, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 22, 4, null, null, null },
                    { 48, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 11, 12, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Plataforma", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 47, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 40, 9, null, null, null },
                    { 46, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 30, 2, null, null, null },
                    { 25, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 22, 6, null, null, null },
                    { 44, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 32, 6, null, null, null },
                    { 43, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 12, 4, null, null, null },
                    { 42, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 1, 3, null, null, null },
                    { 41, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 29, 10, null, null, null },
                    { 40, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 24, 15, null, null, null },
                    { 39, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 43, 2, null, null, null },
                    { 38, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 28, 4, null, null, null },
                    { 45, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 36, 1, null, null, null },
                    { 36, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 43, 15, null, null, null },
                    { 37, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 10, 0, null, null, null },
                    { 27, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 29, 1, null, null, null },
                    { 29, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 9, 13, null, null, null },
                    { 30, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 30, 8, null, null, null },
                    { 28, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 5, 8, null, null, null },
                    { 32, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 24, 14, null, null, null },
                    { 33, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 33, 12, null, null, null },
                    { 34, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 10, 9, null, null, null },
                    { 35, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 7, 13, null, null, null },
                    { 31, new DateTime(2021, 9, 20, 11, 13, 41, 340, DateTimeKind.Local).AddTicks(8918), "Juan Leon", 5, 9, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 25, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6763), "Juan Leon", "Faith", null },
                    { 20, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6755), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6757), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6758), "Juan Leon", "Geralt de Rivia", null },
                    { 23, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6759), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6761), "Juan Leon", "Ellie", null },
                    { 26, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6764), "Juan Leon", "Bayonetta", null },
                    { 33, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6773), "Juan Leon", "Lara Croft", null },
                    { 28, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6766), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6768), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6769), "Juan Leon", "Leon S. Kennedy", null },
                    { 31, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6770), "Juan Leon", "Agente 47", null },
                    { 32, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6771), "Juan Leon", "Haytham Kenway", null },
                    { 19, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6754), "Juan Leon", "Link", null },
                    { 27, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6765), "Juan Leon", "Tracer", null },
                    { 18, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6752), "Juan Leon", "Zelda", null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6733), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6750), "Juan Leon", "Joel", null },
                    { 17, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6751), "Juan Leon", "Jill Valentine", null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6137), "Juan Leon", "Mario Bross", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6727), "Juan Leon", "Tommy Vercetti", null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6736), "Juan Leon", "Crash Bandicoot", null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6737), "Juan Leon", "Samus Aran", null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6738), "Juan Leon", "John-117", null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6740), "Juan Leon", "Aiden Perce", null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6735), "Juan Leon", "Natan Drake", null },
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6742), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6743), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6745), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6746), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6747), "Juan Leon", "Vass", null },
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6741), "Juan Leon", "Carl Jhonson", null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 254, DateTimeKind.Local).AddTicks(6749), "Juan Leon", "Gordon Freeman", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 134, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 20, 10, null, null, null },
                    { 133, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 14, null, null, null },
                    { 132, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 5, 29, null, null, null },
                    { 129, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 11, 6, null, null, null },
                    { 130, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 31, 16, null, null, null },
                    { 128, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 43, 28, null, null, null },
                    { 127, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 44, 7, null, null, null },
                    { 135, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 12, null, null, null },
                    { 131, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 49, 11, null, null, null },
                    { 136, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 5, null, null, null },
                    { 143, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 17, 0, null, null, null },
                    { 138, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 11, 21, null, null, null },
                    { 139, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 21, null, null, null },
                    { 140, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 5, null, null, null },
                    { 141, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 35, 28, null, null, null },
                    { 142, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 15, null, null, null },
                    { 126, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 19, null, null, null },
                    { 144, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 43, 22, null, null, null },
                    { 145, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 17, null, null, null },
                    { 146, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 4, 8, null, null, null },
                    { 147, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 26, null, null, null },
                    { 137, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 17, 15, null, null, null },
                    { 125, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 29, null, null, null },
                    { 117, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 46, 12, null, null, null },
                    { 123, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 9, 20, null, null, null },
                    { 102, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 14, null, null, null },
                    { 103, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 18, null, null, null },
                    { 104, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 43, 15, null, null, null },
                    { 105, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 38, 24, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 106, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 9, 10, null, null, null },
                    { 107, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 21, null, null, null },
                    { 108, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 35, 23, null, null, null },
                    { 109, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 21, null, null, null },
                    { 110, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 1, 7, null, null, null },
                    { 111, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 32, null, null, null },
                    { 112, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 10, null, null, null },
                    { 113, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 39, 2, null, null, null },
                    { 114, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 29, 17, null, null, null },
                    { 115, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 29, null, null, null },
                    { 116, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 29, 25, null, null, null },
                    { 148, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 27, 21, null, null, null },
                    { 118, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 20, 10, null, null, null },
                    { 119, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 2, null, null, null },
                    { 120, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 14, 17, null, null, null },
                    { 121, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 0, 26, null, null, null },
                    { 122, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 30, 20, null, null, null },
                    { 124, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 23, null, null, null },
                    { 149, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 23, null, null, null },
                    { 156, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 24, 19, null, null, null },
                    { 151, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 1, null, null, null },
                    { 178, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 8, 16, null, null, null },
                    { 179, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 24, null, null, null },
                    { 180, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 21, null, null, null },
                    { 181, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 32, 23, null, null, null },
                    { 182, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 24, 13, null, null, null },
                    { 183, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 27, null, null, null },
                    { 184, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 20, 21, null, null, null },
                    { 185, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 4, null, null, null },
                    { 186, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 23, null, null, null },
                    { 187, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 40, 18, null, null, null },
                    { 188, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 19, 4, null, null, null },
                    { 189, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 1, 17, null, null, null },
                    { 190, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 33, 26, null, null, null },
                    { 191, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 38, 24, null, null, null },
                    { 192, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 27, 15, null, null, null },
                    { 193, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 0, 30, null, null, null },
                    { 194, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 28, null, null, null },
                    { 195, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 14, null, null, null },
                    { 196, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 20, 23, null, null, null },
                    { 197, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 40, 5, null, null, null },
                    { 198, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 16, 1, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 177, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 9, 10, null, null, null },
                    { 176, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 1, null, null, null },
                    { 175, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 0, 14, null, null, null },
                    { 174, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 11, 32, null, null, null },
                    { 152, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 28, null, null, null },
                    { 153, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 32, 12, null, null, null },
                    { 154, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 13, null, null, null },
                    { 155, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 49, 7, null, null, null },
                    { 101, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 41, 16, null, null, null },
                    { 157, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 1, 15, null, null, null },
                    { 158, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 39, 3, null, null, null },
                    { 159, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 4, 21, null, null, null },
                    { 160, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 4, null, null, null },
                    { 161, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 23, null, null, null },
                    { 150, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 23, 24, null, null, null },
                    { 162, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 40, 23, null, null, null },
                    { 164, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 35, 18, null, null, null },
                    { 165, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 46, 19, null, null, null },
                    { 166, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 48, 21, null, null, null },
                    { 167, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 8, 13, null, null, null },
                    { 168, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 47, 21, null, null, null },
                    { 169, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 21, 12, null, null, null },
                    { 170, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 41, 32, null, null, null },
                    { 171, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 37, 14, null, null, null },
                    { 172, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 9, null, null, null },
                    { 173, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 2, 16, null, null, null },
                    { 163, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 15, 32, null, null, null },
                    { 100, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 23, 10, null, null, null },
                    { 92, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 28, null, null, null },
                    { 98, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 29, 25, null, null, null },
                    { 25, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 4, 9, null, null, null },
                    { 26, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 14, 23, null, null, null },
                    { 27, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 46, 4, null, null, null },
                    { 28, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 43, 28, null, null, null },
                    { 29, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 33, 24, null, null, null },
                    { 30, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 42, 25, null, null, null },
                    { 31, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 6, 25, null, null, null },
                    { 32, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 1, 12, null, null, null },
                    { 33, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 14, null, null, null },
                    { 34, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 27, 28, null, null, null },
                    { 35, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 14, 26, null, null, null },
                    { 36, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 37, 13, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 37, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 14, 27, null, null, null },
                    { 38, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 18, null, null, null },
                    { 39, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 19, 15, null, null, null },
                    { 40, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 28, null, null, null },
                    { 41, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 17, 19, null, null, null },
                    { 42, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 1, null, null, null },
                    { 43, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 6, 31, null, null, null },
                    { 44, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 42, 27, null, null, null },
                    { 45, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 44, 17, null, null, null },
                    { 24, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 27, 14, null, null, null },
                    { 46, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 25, null, null, null },
                    { 23, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 31, 5, null, null, null },
                    { 21, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 12, null, null, null },
                    { 199, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 48, 9, null, null, null },
                    { 1, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 14, 30, null, null, null },
                    { 2, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 29, null, null, null },
                    { 3, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 4, null, null, null },
                    { 4, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 11, null, null, null },
                    { 5, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 39, 27, null, null, null },
                    { 6, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 11, 17, null, null, null },
                    { 7, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 31, 22, null, null, null },
                    { 8, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 41, 8, null, null, null },
                    { 9, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 23, 21, null, null, null },
                    { 10, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 29, null, null, null },
                    { 11, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 46, 14, null, null, null },
                    { 12, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 25, null, null, null },
                    { 13, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 2, 29, null, null, null },
                    { 14, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 0, 21, null, null, null },
                    { 15, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 16, 13, null, null, null },
                    { 16, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 33, 25, null, null, null },
                    { 17, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 47, 25, null, null, null },
                    { 18, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 19, 1, null, null, null },
                    { 19, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 24, 2, null, null, null },
                    { 20, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 19, 12, null, null, null },
                    { 22, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 2, 26, null, null, null },
                    { 47, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 19, null, null, null },
                    { 48, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 24, null, null, null },
                    { 49, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 17, 22, null, null, null },
                    { 76, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 11, null, null, null },
                    { 77, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 14, null, null, null },
                    { 78, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 29, 28, null, null, null },
                    { 79, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 35, 12, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 80, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 44, 17, null, null, null },
                    { 81, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 33, 24, null, null, null },
                    { 82, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 4, null, null, null },
                    { 83, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 5, 24, null, null, null },
                    { 84, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 17, 21, null, null, null },
                    { 85, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 35, 24, null, null, null },
                    { 86, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 6, 31, null, null, null },
                    { 87, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 24, 31, null, null, null },
                    { 88, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 33, 27, null, null, null },
                    { 89, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 12, null, null, null },
                    { 90, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 34, 7, null, null, null },
                    { 91, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 41, 31, null, null, null },
                    { 93, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 5, 28, null, null, null },
                    { 94, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 12, null, null, null },
                    { 95, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 12, null, null, null },
                    { 96, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 47, 1, null, null, null },
                    { 97, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 18, 31, null, null, null },
                    { 75, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 8, 23, null, null, null },
                    { 74, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 7, null, null, null },
                    { 73, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 3, 6, null, null, null },
                    { 72, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 2, 18, null, null, null },
                    { 50, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 31, 6, null, null, null },
                    { 51, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 30, 22, null, null, null },
                    { 52, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 7, 10, null, null, null },
                    { 53, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 28, null, null, null },
                    { 54, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 21, 3, null, null, null },
                    { 55, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 38, 10, null, null, null },
                    { 56, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 22, 6, null, null, null },
                    { 57, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 29, 32, null, null, null },
                    { 58, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 21, 18, null, null, null },
                    { 59, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 32, null, null, null },
                    { 99, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 12, 30, null, null, null },
                    { 60, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 11, 6, null, null, null },
                    { 62, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 48, 25, null, null, null },
                    { 63, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 20, 32, null, null, null },
                    { 64, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 22, null, null, null },
                    { 65, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 28, 20, null, null, null },
                    { 66, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 10, 23, null, null, null },
                    { 67, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 41, 31, null, null, null },
                    { 68, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 13, 22, null, null, null },
                    { 69, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 21, 8, null, null, null },
                    { 70, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 25, 8, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 71, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 26, 25, null, null, null });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 61, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 30, 24, null, null, null });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Id_Juego", "Id_Protagonista", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[] { 200, new DateTime(2021, 9, 20, 11, 13, 41, 344, DateTimeKind.Local).AddTicks(1067), "Juan Leon", 2, 6, null, null, null });

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
