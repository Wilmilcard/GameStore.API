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
                    ClienteId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    PlataformaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.PlataformaId);
                });

            migrationBuilder.CreateTable(
                name: "Protagonista",
                columns: table => new
                {
                    ProtagonistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista", x => x.ProtagonistaId);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    AlquilerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Reservacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Devolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Valor_Total = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.AlquilerId);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.DirectorId);
                    table.ForeignKey(
                        name: "FK_Director_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Juego",
                columns: table => new
                {
                    JuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Lanzamiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juego", x => x.JuegoId);
                    table.ForeignKey(
                        name: "FK_Juego_Director_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler_Dets",
                columns: table => new
                {
                    AlquilerDetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    AlquilerId = table.Column<int>(type: "int", nullable: false),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler_Dets", x => x.AlquilerDetId);
                    table.ForeignKey(
                        name: "FK_Alquiler_Dets_Alquiler_AlquilerId",
                        column: x => x.AlquilerId,
                        principalTable: "Alquiler",
                        principalColumn: "AlquilerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Dets_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma_Juego",
                columns: table => new
                {
                    PlataformaJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    PlataformaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma_Juego", x => x.PlataformaJuegoId);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plataforma_Juego_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "PlataformaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Protagonista_Juego",
                columns: table => new
                {
                    ProtagonistaJuegoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JuegoId = table.Column<int>(type: "int", nullable: false),
                    ProtagonistaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protagonista_Juego", x => x.ProtagonistaJuegoId);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Juego_JuegoId",
                        column: x => x.JuegoId,
                        principalTable: "Juego",
                        principalColumn: "JuegoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protagonista_Juego_Protagonista_ProtagonistaId",
                        column: x => x.ProtagonistaId,
                        principalTable: "Protagonista",
                        principalColumn: "ProtagonistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Schulist", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Elmer.Schulist51@gmail.com", new DateTime(2001, 7, 4, 11, 54, 20, 808, DateTimeKind.Local).AddTicks(7337), "639969426", "Elmer", "Elmer Schulist", "(594) 997-4898 x11035", null },
                    { 28, "Zieme", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Rodney.Zieme50@yahoo.com", new DateTime(1994, 3, 8, 2, 21, 28, 66, DateTimeKind.Local).AddTicks(7568), "548884792", "Rodney", "Rodney Zieme", "(281) 937-5452 x745", null },
                    { 29, "Witting", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Gail.Witting75@hotmail.com", new DateTime(1996, 6, 8, 6, 53, 19, 47, DateTimeKind.Local).AddTicks(8543), "224127410", "Gail", "Gail Witting", "(257) 858-0179 x24718", null },
                    { 31, "O'Reilly", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Diane41@yahoo.com", new DateTime(1964, 7, 3, 22, 51, 18, 479, DateTimeKind.Local).AddTicks(9368), "308753917", "Diane", "Diane O'Reilly", "672-392-7965 x5193", null },
                    { 32, "Kiehn", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Everett.Kiehn65@hotmail.com", new DateTime(1965, 1, 13, 21, 54, 53, 472, DateTimeKind.Local).AddTicks(8117), "614748420", "Everett", "Everett Kiehn", "1-664-203-8031 x4347", null },
                    { 33, "Smith", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Morris_Smith38@yahoo.com", new DateTime(1984, 1, 28, 3, 39, 2, 528, DateTimeKind.Local).AddTicks(3257), "985348206", "Morris", "Morris Smith", "(680) 384-9637 x60208", null },
                    { 34, "O'Conner", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Carroll.OConner5@gmail.com", new DateTime(1967, 3, 9, 13, 0, 28, 88, DateTimeKind.Local).AddTicks(8336), "207201938", "Carroll", "Carroll O'Conner", "892-782-2966 x9693", null },
                    { 35, "Fritsch", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Ryan.Fritsch16@gmail.com", new DateTime(1975, 3, 16, 12, 0, 11, 785, DateTimeKind.Local).AddTicks(607), "422716697", "Ryan", "Ryan Fritsch", "1-472-910-6153 x83432", null },
                    { 36, "Pouros", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Louis54@gmail.com", new DateTime(1979, 8, 26, 20, 44, 18, 604, DateTimeKind.Local).AddTicks(9787), "686322639", "Louis", "Louis Pouros", "398-345-6914 x2924", null },
                    { 37, "Crist", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Doris.Crist46@hotmail.com", new DateTime(1959, 6, 28, 14, 49, 1, 599, DateTimeKind.Local).AddTicks(9790), "660210061", "Doris", "Doris Crist", "1-244-930-5356", null },
                    { 38, "Bernier", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Gregory21@gmail.com", new DateTime(1974, 9, 14, 3, 12, 37, 929, DateTimeKind.Local).AddTicks(7443), "261048939", "Gregory", "Gregory Bernier", "1-725-246-5735", null },
                    { 27, "Hammes", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Erma_Hammes91@gmail.com", new DateTime(1966, 12, 18, 15, 10, 57, 657, DateTimeKind.Local).AddTicks(6272), "890100621", "Erma", "Erma Hammes", "271-382-6874 x86190", null },
                    { 39, "Rosenbaum", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Gwendolyn32@gmail.com", new DateTime(1958, 2, 13, 4, 29, 39, 672, DateTimeKind.Local).AddTicks(904), "800251329", "Gwendolyn", "Gwendolyn Rosenbaum", "(794) 398-6773", null },
                    { 41, "Halvorson", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Daryl.Halvorson@gmail.com", new DateTime(1985, 2, 21, 0, 35, 16, 569, DateTimeKind.Local).AddTicks(4220), "277501008", "Daryl", "Daryl Halvorson", "(495) 695-1085 x099", null },
                    { 42, "Lubowitz", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Jeffrey.Lubowitz@hotmail.com", new DateTime(1991, 11, 17, 2, 47, 43, 13, DateTimeKind.Local).AddTicks(5977), "306134247", "Jeffrey", "Jeffrey Lubowitz", "(836) 468-7874 x57269", null },
                    { 43, "Block", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Tiffany34@gmail.com", new DateTime(1977, 8, 10, 21, 15, 20, 594, DateTimeKind.Local).AddTicks(5450), "276869251", "Tiffany", "Tiffany Block", "(937) 894-3168 x8210", null },
                    { 44, "Nolan", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Hugo_Nolan17@gmail.com", new DateTime(1961, 6, 25, 19, 49, 35, 466, DateTimeKind.Local).AddTicks(668), "892978668", "Hugo", "Hugo Nolan", "1-566-273-5046", null },
                    { 45, "Ratke", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Della_Ratke@hotmail.com", new DateTime(1962, 4, 13, 13, 9, 35, 902, DateTimeKind.Local).AddTicks(4921), "421094323", "Della", "Della Ratke", "1-549-628-4507", null },
                    { 46, "Marks", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Bessie20@hotmail.com", new DateTime(1967, 5, 28, 4, 30, 36, 998, DateTimeKind.Local).AddTicks(4786), "799674685", "Bessie", "Bessie Marks", "948.210.4569", null },
                    { 47, "Powlowski", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Bonnie.Powlowski23@hotmail.com", new DateTime(1979, 7, 5, 4, 31, 41, 806, DateTimeKind.Local).AddTicks(9804), "529537614", "Bonnie", "Bonnie Powlowski", "(425) 962-3660 x22539", null },
                    { 48, "Bechtelar", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Leroy.Bechtelar74@gmail.com", new DateTime(1982, 9, 12, 9, 18, 21, 9, DateTimeKind.Local).AddTicks(3763), "160843452", "Leroy", "Leroy Bechtelar", "437-681-1026 x609", null },
                    { 49, "Toy", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Brooke.Toy@yahoo.com", new DateTime(1965, 12, 5, 7, 58, 15, 702, DateTimeKind.Local).AddTicks(6730), "996805105", "Brooke", "Brooke Toy", "972-242-8399", null },
                    { 50, "Oberbrunner", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Jessie.Oberbrunner3@gmail.com", new DateTime(1959, 3, 19, 17, 55, 11, 860, DateTimeKind.Local).AddTicks(4289), "187036519", "Jessie", "Jessie Oberbrunner", "710-638-2668 x8581", null },
                    { 40, "Kuhlman", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Gerardo_Kuhlman0@yahoo.com", new DateTime(1975, 12, 22, 3, 15, 29, 496, DateTimeKind.Local).AddTicks(3516), "718374349", "Gerardo", "Gerardo Kuhlman", "(348) 846-4702 x025", null },
                    { 26, "Hessel", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Clark_Hessel91@yahoo.com", new DateTime(1998, 5, 21, 7, 13, 23, 728, DateTimeKind.Local).AddTicks(3389), "858804237", "Clark", "Clark Hessel", "589.813.9179 x7310", null },
                    { 30, "Hansen", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Tom_Hansen@yahoo.com", new DateTime(1992, 6, 21, 12, 10, 12, 746, DateTimeKind.Local).AddTicks(3868), "216685958", "Tom", "Tom Hansen", "1-931-956-8274", null },
                    { 24, "Kulas", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Olga.Kulas@hotmail.com", new DateTime(1961, 3, 2, 10, 6, 52, 754, DateTimeKind.Local).AddTicks(5182), "301629617", "Olga", "Olga Kulas", "258-577-0528", null },
                    { 2, "Bashirian", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Guy_Bashirian47@hotmail.com", new DateTime(1954, 9, 15, 5, 31, 24, 358, DateTimeKind.Local).AddTicks(9125), "887873299", "Guy", "Guy Bashirian", "838-225-0283 x6898", null },
                    { 3, "MacGyver", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Guillermo45@gmail.com", new DateTime(1963, 12, 20, 3, 0, 44, 852, DateTimeKind.Local).AddTicks(116), "144424169", "Guillermo", "Guillermo MacGyver", "1-375-723-0737", null },
                    { 4, "Klein", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Sue_Klein@yahoo.com", new DateTime(1988, 2, 23, 22, 46, 25, 111, DateTimeKind.Local).AddTicks(2773), "520142342", "Sue", "Sue Klein", "348-833-7784", null },
                    { 5, "Dach", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Velma61@yahoo.com", new DateTime(1984, 11, 4, 6, 26, 27, 669, DateTimeKind.Local).AddTicks(9158), "934540414", "Velma", "Velma Dach", "1-480-379-1080 x64410", null },
                    { 6, "Schmitt", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Eula81@hotmail.com", new DateTime(1967, 8, 25, 8, 23, 14, 604, DateTimeKind.Local).AddTicks(2275), "837817820", "Eula", "Eula Schmitt", "231.499.1476 x0701", null },
                    { 7, "Schaden", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Tami_Schaden97@hotmail.com", new DateTime(1961, 9, 28, 18, 42, 20, 966, DateTimeKind.Local).AddTicks(7697), "711373359", "Tami", "Tami Schaden", "1-622-557-7404 x511", null },
                    { 8, "Beahan", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Adrienne.Beahan44@gmail.com", new DateTime(1998, 6, 25, 23, 41, 2, 686, DateTimeKind.Local).AddTicks(4882), "808080703", "Adrienne", "Adrienne Beahan", "245.826.8329 x2580", null },
                    { 25, "Schoen", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Erick39@hotmail.com", new DateTime(1973, 10, 26, 16, 16, 1, 84, DateTimeKind.Local).AddTicks(7714), "891655351", "Erick", "Erick Schoen", "(432) 818-3676", null },
                    { 10, "Donnelly", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Jordan29@gmail.com", new DateTime(1969, 2, 28, 6, 51, 40, 806, DateTimeKind.Local).AddTicks(8405), "516997463", "Jordan", "Jordan Donnelly", "717.962.7918", null },
                    { 11, "Champlin", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Rodolfo.Champlin2@hotmail.com", new DateTime(1979, 9, 5, 12, 26, 38, 876, DateTimeKind.Local).AddTicks(6488), "277912766", "Rodolfo", "Rodolfo Champlin", "823-303-1320 x733", null },
                    { 12, "Wintheiser", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Mack_Wintheiser@hotmail.com", new DateTime(1985, 9, 6, 5, 23, 3, 421, DateTimeKind.Local).AddTicks(2562), "981109291", "Mack", "Mack Wintheiser", "(708) 230-5872 x1181", null },
                    { 9, "Hackett", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "James_Hackett@hotmail.com", new DateTime(1955, 6, 7, 23, 0, 2, 72, DateTimeKind.Local).AddTicks(8539), "192674168", "James", "James Hackett", "363-893-2130 x56842", null },
                    { 14, "Donnelly", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Nichole_Donnelly28@hotmail.com", new DateTime(1962, 9, 8, 7, 53, 46, 477, DateTimeKind.Local).AddTicks(415), "886134557", "Nichole", "Nichole Donnelly", "521-260-0847 x106", null },
                    { 23, "Jaskolski", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Mitchell_Jaskolski63@hotmail.com", new DateTime(1976, 6, 16, 3, 46, 19, 632, DateTimeKind.Local).AddTicks(2506), "533887343", "Mitchell", "Mitchell Jaskolski", "1-455-324-2415", null },
                    { 13, "Kertzmann", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Travis62@gmail.com", new DateTime(1974, 11, 1, 9, 32, 31, 707, DateTimeKind.Local).AddTicks(8569), "740102683", "Travis", "Travis Kertzmann", "535.888.7524 x6203", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "Runte", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Sonja3@gmail.com", new DateTime(1959, 10, 20, 14, 55, 57, 685, DateTimeKind.Local).AddTicks(5396), "908990305", "Sonja", "Sonja Runte", "797.990.2238", null },
                    { 20, "Hane", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Betsy_Hane99@hotmail.com", new DateTime(1956, 4, 7, 13, 10, 18, 234, DateTimeKind.Local).AddTicks(9469), "832647082", "Betsy", "Betsy Hane", "1-847-638-1396 x900", null },
                    { 22, "Emmerich", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Karla44@gmail.com", new DateTime(1958, 12, 23, 16, 12, 56, 890, DateTimeKind.Local).AddTicks(253), "323636517", "Karla", "Karla Emmerich", "753-415-1254", null },
                    { 18, "Becker", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Lillie65@yahoo.com", new DateTime(1991, 4, 25, 12, 19, 14, 914, DateTimeKind.Local).AddTicks(6048), "671426402", "Lillie", "Lillie Becker", "283-873-1252 x7014", null },
                    { 17, "Schaefer", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Leona17@gmail.com", new DateTime(1970, 2, 9, 3, 38, 54, 321, DateTimeKind.Local).AddTicks(66), "375425729", "Leona", "Leona Schaefer", "356.493.3660 x347", null },
                    { 16, "Durgan", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Ellen.Durgan15@gmail.com", new DateTime(1966, 10, 9, 10, 47, 21, 92, DateTimeKind.Local).AddTicks(7826), "232646440", "Ellen", "Ellen Durgan", "1-497-341-6424 x01712", null },
                    { 15, "Keeling", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Dana65@gmail.com", new DateTime(1954, 3, 15, 23, 0, 55, 607, DateTimeKind.Local).AddTicks(7127), "431348762", "Dana", "Dana Keeling", "(944) 491-5287 x449", null },
                    { 19, "Cremin", new DateTime(2021, 9, 30, 16, 44, 44, 761, DateTimeKind.Local).AddTicks(8722), "Juan Leon", "Hector32@gmail.com", new DateTime(1988, 1, 24, 10, 19, 58, 422, DateTimeKind.Local).AddTicks(603), "660247694", "Hector", "Hector Cremin", "618.225.3747", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 721, DateTimeKind.Local).AddTicks(8155), "Juan Leon", "Activo", null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 721, DateTimeKind.Local).AddTicks(8682), "Juan Leon", "Inactivo", null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 721, DateTimeKind.Local).AddTicks(8686), "Juan Leon", "Devuelto", null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 721, DateTimeKind.Local).AddTicks(8691), "Juan Leon", "Prestamo", null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 721, DateTimeKind.Local).AddTicks(8692), "Juan Leon", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(83), "Juan Leon", "Nintendo", null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(86), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(84), "Juan Leon", "Rockstar", null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(82), "Juan Leon", "Activision", null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(74), "Juan Leon", "Sony", null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(79), "Juan Leon", "Ubisoft", null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(77), "Juan Leon", "EA", null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(80), "Juan Leon", "Rovio", null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(9603), "Juan Leon", "Microsoft", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1555), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1554), "Juan Leon", "Android", null },
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1551), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1550), "Juan Leon", "Nintendo 64", null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1549), "Juan Leon", "PlayStation 5", null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1547), "Juan Leon", "PlayStation 4", null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1546), "Juan Leon", "PlayStation 3", null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1553), "Juan Leon", "Nintendo Switch", null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1543), "Juan Leon", "PlayStation", null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1541), "Juan Leon", "PSP Vita", null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1540), "Juan Leon", "Xbox X", null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1539), "Juan Leon", "Xbox ONE", null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1537), "Juan Leon", "Xbox 360", null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1533), "Juan Leon", "Xbox", null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1020), "Juan Leon", "PC", null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 723, DateTimeKind.Local).AddTicks(1544), "Juan Leon", "PlayStation 2", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8609), "Juan Leon", "Link", null },
                    { 20, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8616), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8617), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8619), "Juan Leon", "Geralt de Rivia", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8620), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8622), "Juan Leon", "Ellie", null },
                    { 27, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8626), "Juan Leon", "Tracer", null },
                    { 25, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8623), "Juan Leon", "Faith", null },
                    { 26, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Bayonetta", null },
                    { 28, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8628), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8629), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8631), "Juan Leon", "Leon S. Kennedy", null },
                    { 18, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8607), "Juan Leon", "Zelda", null },
                    { 31, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8633), "Juan Leon", "Agente 47", null },
                    { 17, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8606), "Juan Leon", "Jill Valentine", null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8590), "Juan Leon", "John-117", null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8602), "Juan Leon", "Gordon Freeman", null },
                    { 32, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8634), "Juan Leon", "Haytham Kenway", null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8060), "Juan Leon", "Mario Bross", null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8580), "Juan Leon", "Tommy Vercetti", null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8584), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8586), "Juan Leon", "Natan Drake", null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8588), "Juan Leon", "Crash Bandicoot", null },
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8604), "Juan Leon", "Joel", null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8589), "Juan Leon", "Samus Aran", null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8593), "Juan Leon", "Carl Jhonson", null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8595), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8596), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8598), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8599), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8601), "Juan Leon", "Vass", null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8592), "Juan Leon", "Aiden Perce", null },
                    { 33, new DateTime(2021, 9, 30, 16, 44, 44, 722, DateTimeKind.Local).AddTicks(8636), "Juan Leon", "Lara Croft", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 2, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 57254.0 },
                    { 52, 18, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25440.0 },
                    { 51, 17, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85284.0 },
                    { 49, 21, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98742.0 },
                    { 42, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39004.0 },
                    { 41, 48, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73854.0 },
                    { 40, 35, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 149858.0 },
                    { 39, 29, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28121.0 },
                    { 36, 19, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71948.0 },
                    { 35, 5, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94446.0 },
                    { 34, 46, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48964.0 },
                    { 33, 28, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53059.0 },
                    { 31, 46, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36467.0 },
                    { 30, 1, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131846.0 },
                    { 25, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44288.0 },
                    { 24, 49, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39636.0 },
                    { 22, 8, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 149280.0 },
                    { 21, 15, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115322.0 },
                    { 19, 32, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 118037.0 },
                    { 18, 17, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88468.0 },
                    { 16, 39, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 55393.0 },
                    { 14, 2, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45257.0 },
                    { 54, 30, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 129249.0 },
                    { 56, 9, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 89403.0 },
                    { 58, 11, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 143810.0 },
                    { 60, 6, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92628.0 },
                    { 100, 4, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64186.0 },
                    { 99, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 140302.0 },
                    { 98, 2, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43593.0 },
                    { 97, 32, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105069.0 },
                    { 95, 33, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 114309.0 },
                    { 94, 23, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85494.0 },
                    { 92, 7, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33467.0 },
                    { 91, 3, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36157.0 },
                    { 88, 48, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73810.0 },
                    { 85, 34, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71561.0 },
                    { 8, 49, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78137.0 },
                    { 83, 35, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 110607.0 },
                    { 75, 30, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 134488.0 },
                    { 74, 46, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 118180.0 },
                    { 72, 39, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95220.0 },
                    { 71, 22, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53116.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 69, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100811.0 },
                    { 67, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34491.0 },
                    { 65, 31, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25188.0 },
                    { 64, 9, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36195.0 },
                    { 62, 49, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33941.0 },
                    { 61, 2, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60549.0 },
                    { 80, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 102730.0 },
                    { 7, 6, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68289.0 },
                    { 29, 15, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144201.0 },
                    { 4, 4, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54752.0 },
                    { 47, 30, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 114813.0 },
                    { 46, 49, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91559.0 },
                    { 45, 7, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77434.0 },
                    { 44, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 140491.0 },
                    { 43, 11, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54789.0 },
                    { 38, 36, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125928.0 },
                    { 37, 18, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27277.0 },
                    { 32, 44, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 124142.0 },
                    { 5, 34, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68682.0 },
                    { 27, 22, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65447.0 },
                    { 48, 18, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83441.0 },
                    { 26, 28, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 126055.0 },
                    { 20, 28, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58341.0 },
                    { 17, 25, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71148.0 },
                    { 15, 13, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35767.0 },
                    { 13, 28, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97229.0 },
                    { 12, 44, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 62550.0 },
                    { 11, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 137389.0 },
                    { 10, 27, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36655.0 },
                    { 9, 9, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 143042.0 },
                    { 6, 24, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100996.0 },
                    { 3, 10, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33446.0 },
                    { 23, 49, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 146464.0 },
                    { 50, 25, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96209.0 },
                    { 28, 6, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 59348.0 },
                    { 55, 1, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71767.0 },
                    { 53, 13, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36944.0 },
                    { 96, 48, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64913.0 },
                    { 93, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115465.0 },
                    { 90, 45, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30043.0 },
                    { 89, 46, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 127198.0 },
                    { 87, 32, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112197.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 86, 28, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36026.0 },
                    { 84, 40, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72992.0 },
                    { 82, 5, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 132006.0 },
                    { 81, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36241.0 },
                    { 1, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 4, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88683.0 },
                    { 78, 3, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30973.0 },
                    { 79, 42, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112203.0 },
                    { 59, 38, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35463.0 },
                    { 63, 34, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83936.0 },
                    { 66, 4, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38247.0 },
                    { 68, 32, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73264.0 },
                    { 57, 16, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60790.0 },
                    { 73, 38, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85347.0 },
                    { 76, 48, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 101317.0 },
                    { 77, 47, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119491.0 },
                    { 70, 44, new DateTime(2021, 9, 30, 16, 44, 44, 814, DateTimeKind.Local).AddTicks(3037), "Juan Leon", 3, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 113820.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7566), "Juan Leon", 7, "Keiji Inafune", null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7551), "Juan Leon", 6, "Shigeru Miyamoto", null },
                    { 20, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7565), "Juan Leon", 7, "John Carmack", null },
                    { 19, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7563), "Juan Leon", 7, "Sid Meier", null },
                    { 17, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7560), "Juan Leon", 7, "Yuji Horii", null },
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7558), "Juan Leon", 7, "John Romero", null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7041), "Juan Leon", 7, "Hideo Kojima", null },
                    { 18, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7561), "Juan Leon", 6, "Yuji Naka", null },
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7553), "Juan Leon", 6, "Michel Ancel", null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7547), "Juan Leon", 6, "Tom Howard", null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7545), "Juan Leon", 4, "Gabe Newell", null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7537), "Juan Leon", 5, "Hidetaka Miyazaki", null },
                    { 22, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7568), "Juan Leon", 4, "Hironobu Sakaguchi", null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7557), "Juan Leon", 4, "Warren Spector", null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7544), "Juan Leon", 3, "Yves Guillemot", null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7542), "Juan Leon", 2, "Fumito Ueda", null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7552), "Juan Leon", 1, "Amy Hennig", null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7539), "Juan Leon", 1, "Tim Schafer", null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7532), "Juan Leon", 1, "Will Wriths", null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7548), "Juan Leon", 8, "Yoko Taro", null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7541), "Juan Leon", 6, "Ken Levine", null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(7555), "Juan Leon", 8, "Goichi Suda", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 24, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9925), "Juan Leon", 2, new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 21403.0, 4, null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9895), "Juan Leon", 18, new DateTime(2010, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 17307.0, 2, null },
                    { 50, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9996), "Juan Leon", 1, new DateTime(2004, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 22250.0, 3, null },
                    { 45, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9980), "Juan Leon", 16, new DateTime(2005, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 22377.0, 14, null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9869), "Juan Leon", 17, new DateTime(2012, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 24548.0, 2, null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9872), "Juan Leon", 17, new DateTime(1995, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 23689.0, 10, null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9884), "Juan Leon", 17, new DateTime(1997, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 15419.0, 8, null },
                    { 33, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9949), "Juan Leon", 17, new DateTime(2007, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 22268.0, 2, null },
                    { 37, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9959), "Juan Leon", 17, new DateTime(2007, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 22578.0, 6, null },
                    { 39, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9964), "Juan Leon", 17, new DateTime(1997, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 21516.0, 2, null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9898), "Juan Leon", 19, new DateTime(2017, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 22508.0, 14, null },
                    { 17, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9904), "Juan Leon", 19, new DateTime(2010, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 24359.0, 5, null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9887), "Juan Leon", 20, new DateTime(2013, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 17804.0, 4, null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9890), "Juan Leon", 20, new DateTime(1999, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 20927.0, 13, null },
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9901), "Juan Leon", 20, new DateTime(2020, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 24012.0, 12, null },
                    { 31, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9944), "Juan Leon", 20, new DateTime(2015, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 17511.0, 6, null },
                    { 40, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9967), "Juan Leon", 20, new DateTime(2017, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 24431.0, 5, null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9875), "Juan Leon", 21, new DateTime(2009, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 19075.0, 4, null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9817), "Juan Leon", 10, new DateTime(2007, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 18025.0, 12, null },
                    { 18, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9906), "Juan Leon", 10, new DateTime(2014, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 22878.0, 11, null },
                    { 19, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9909), "Juan Leon", 10, new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 24463.0, 11, null },
                    { 25, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9928), "Juan Leon", 10, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 17256.0, 12, null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9866), "Juan Leon", 18, new DateTime(2008, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 22781.0, 5, null },
                    { 41, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9970), "Juan Leon", 13, new DateTime(2015, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 18779.0, 3, null },
                    { 30, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9941), "Juan Leon", 13, new DateTime(1998, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 22602.0, 7, null },
                    { 27, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9933), "Juan Leon", 13, new DateTime(2018, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 17599.0, 4, null },
                    { 48, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9988), "Juan Leon", 2, new DateTime(2004, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 24362.0, 6, null },
                    { 32, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9947), "Juan Leon", 4, new DateTime(2017, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 22248.0, 10, null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9334), "Juan Leon", 12, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 22629.0, 14, null },
                    { 21, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9917), "Juan Leon", 12, new DateTime(1996, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 15218.0, 6, null },
                    { 22, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9920), "Juan Leon", 12, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 22357.0, 2, null },
                    { 42, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9972), "Juan Leon", 12, new DateTime(2009, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 19354.0, 10, null },
                    { 43, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9975), "Juan Leon", 12, new DateTime(2013, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 15377.0, 9, null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9811), "Juan Leon", 6, new DateTime(2000, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 16287.0, 7, null },
                    { 44, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9978), "Juan Leon", 6, new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 16546.0, 10, null },
                    { 35, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9954), "Juan Leon", 7, new DateTime(2002, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 23825.0, 8, null },
                    { 29, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9938), "Juan Leon", 14, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 20991.0, 5, null },
                    { 47, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9985), "Juan Leon", 7, new DateTime(2009, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 18465.0, 10, null },
                    { 38, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9962), "Juan Leon", 8, new DateTime(2013, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 17556.0, 7, null },
                    { 46, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9983), "Juan Leon", 8, new DateTime(2009, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 17118.0, 8, null },
                    { 20, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9911), "Juan Leon", 15, new DateTime(2005, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 24944.0, 3, null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9882), "Juan Leon", 5, new DateTime(2007, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 17760.0, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9892), "Juan Leon", 5, new DateTime(2013, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 18309.0, 14, null },
                    { 23, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9923), "Juan Leon", 5, new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 22084.0, 10, null },
                    { 34, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9952), "Juan Leon", 5, new DateTime(2001, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 16189.0, 2, null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9878), "Juan Leon", 9, new DateTime(2017, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 20168.0, 7, null },
                    { 28, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9935), "Juan Leon", 11, new DateTime(2018, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 20684.0, 13, null },
                    { 36, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9957), "Juan Leon", 11, new DateTime(2012, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 16290.0, 8, null },
                    { 26, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9930), "Juan Leon", 8, new DateTime(2006, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 17836.0, 11, null },
                    { 49, new DateTime(2021, 9, 30, 16, 44, 44, 815, DateTimeKind.Local).AddTicks(9994), "Juan Leon", 14, new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 21184.0, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 3, 22, 132631, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 233, 72, 141408, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 36, null, 0.0 },
                    { 218, 71, 54834, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 36, null, 0.0 },
                    { 183, 34, 48783, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 36, null, 0.0 },
                    { 36, 68, 119693, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 226, 14, 68424, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 28, null, 0.0 },
                    { 125, 58, 112483, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 28, null, 0.0 },
                    { 112, 26, 56163, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 113, 79, 26225, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 262, 56, 132764, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 36, null, 0.0 },
                    { 150, 13, 132906, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 264, 14, 94939, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 254, 54, 98837, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 248, 95, 62902, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 240, 11, 56313, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 232, 77, 81746, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 195, 83, 144363, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 28, 28, 149853, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 25, 72, 102662, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 295, 71, 104051, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 8, null, 0.0 },
                    { 296, 75, 143101, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 36, null, 0.0 },
                    { 300, 55, 69101, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 245, 32, 36946, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 33, 56, 40671, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 5, 28, 68092, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 185, 38, 126343, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 182, 28, 146738, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 145, 36, 134523, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 50, 94, 60764, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 46, 52, 131342, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 24, 11, 95768, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 11, 66, 119913, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 30, null, 0.0 },
                    { 13, 48, 56607, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 38, 37, 125685, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 149, 23, 25802, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 202, 59, 129583, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 },
                    { 284, 72, 142368, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 27, null, 0.0 },
                    { 121, 40, 147078, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 27, null, 0.0 },
                    { 54, 8, 26140, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 27, null, 0.0 },
                    { 53, 46, 78959, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 27, null, 0.0 },
                    { 26, 68, 44649, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 27, null, 0.0 },
                    { 217, 95, 39713, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 40, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 155, 92, 44039, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 96, 96, 30691, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 159, 12, 104932, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 249, 9, 112000, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 135, 68, 29123, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 106, 82, 68928, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 93, 34, 93426, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 61, 94, 35308, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 7, 19, 90094, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 71, 64, 79169, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 144, 91, 104367, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 201, 18, 118656, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 167, 67, 149392, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 229, 59, 93763, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 181, 91, 30369, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 178, 42, 119342, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 142, 59, 26115, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 114, 7, 85939, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 109, 57, 107911, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 250, 8, 101396, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 20, null, 0.0 },
                    { 215, 80, 34570, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 20, null, 0.0 },
                    { 82, 49, 97024, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 20, null, 0.0 },
                    { 271, 22, 146901, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 9, null, 0.0 },
                    { 179, 35, 28270, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 227, 99, 142767, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 258, 60, 80394, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 263, 83, 49780, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 287, 82, 139530, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 279, 34, 33330, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 130, 80, 62538, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 126, 41, 116656, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 100, 39, 41116, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 66, 78, 44015, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 37, 47, 149376, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 34, null, 0.0 },
                    { 8, 83, 68765, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 47, 72, 126861, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 69, 93, 62070, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 141, 25, 139041, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 143, 81, 81620, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 253, 47, 92217, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 293, 96, 110629, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 122, 48, 149613, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 23, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 34, 37, 73016, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 48, 63, 57731, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 18, null, 0.0 },
                    { 272, 73, 85597, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 13, null, 0.0 },
                    { 214, 69, 110497, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 7, null, 0.0 },
                    { 35, 53, 45662, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 20, null, 0.0 },
                    { 101, 96, 117198, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 168, 33, 131705, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 156, 11, 117585, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 146, 8, 118048, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 139, 20, 136511, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 108, 90, 45822, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 84, 5, 118106, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 10, 20, 120450, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 243, 26, 143871, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 37, null, 0.0 },
                    { 213, 13, 29595, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 37, null, 0.0 },
                    { 192, 44, 93497, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 203, 33, 100671, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 37, null, 0.0 },
                    { 132, 31, 52772, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 33, null, 0.0 },
                    { 111, 54, 89753, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 33, null, 0.0 },
                    { 86, 94, 77123, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 33, null, 0.0 },
                    { 49, 3, 29107, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 33, null, 0.0 },
                    { 292, 87, 140672, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 10, null, 0.0 },
                    { 231, 5, 53722, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 10, null, 0.0 },
                    { 116, 72, 88284, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 10, null, 0.0 },
                    { 67, 47, 39144, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 10, null, 0.0 },
                    { 75, 35, 68229, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 37, null, 0.0 },
                    { 200, 89, 97542, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 222, 29, 103089, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 241, 97, 125864, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 280, 14, 96442, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 171, 4, 136921, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 165, 30, 126432, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 120, 50, 72078, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 99, 86, 57547, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 91, 47, 149211, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 78, 66, 89319, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 17, null, 0.0 },
                    { 289, 12, 49066, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 15, null, 0.0 },
                    { 173, 50, 110278, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 15, null, 0.0 },
                    { 160, 86, 39939, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 15, null, 0.0 },
                    { 128, 14, 49586, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 15, null, 0.0 },
                    { 4, 16, 134922, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 15, null, 0.0 },
                    { 12, 91, 54816, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 11, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 115, 73, 130655, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 11, null, 0.0 },
                    { 129, 57, 136947, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 11, null, 0.0 },
                    { 269, 40, 84718, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 11, null, 0.0 },
                    { 270, 24, 133784, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 11, null, 0.0 },
                    { 294, 62, 80495, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 286, 86, 116317, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 39, null, 0.0 },
                    { 6, 95, 140064, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 12, null, 0.0 },
                    { 147, 68, 111287, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 172, 44, 141166, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 12, null, 0.0 },
                    { 212, 76, 125220, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 12, null, 0.0 },
                    { 152, 34, 81749, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 153, 77, 56668, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 216, 32, 67967, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 290, 83, 35211, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 211, 29, 49591, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 14, null, 0.0 },
                    { 169, 70, 81815, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 14, null, 0.0 },
                    { 133, 34, 56772, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 31, null, 0.0 },
                    { 283, 70, 51708, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 224, 76, 45277, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 45, null, 0.0 },
                    { 259, 2, 143488, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 105, 89, 131596, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 87, 65, 46938, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 74, 61, 58136, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 31, 88, 146249, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 197, 15, 117240, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 31, null, 0.0 },
                    { 256, 92, 40567, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 31, null, 0.0 },
                    { 298, 31, 73932, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 177, 95, 92993, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 41, null, 0.0 },
                    { 162, 9, 63496, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 4, null, 0.0 },
                    { 228, 49, 138708, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 45, null, 0.0 },
                    { 297, 9, 27780, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 45, null, 0.0 },
                    { 92, 8, 112513, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 288, 75, 67570, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 12, null, 0.0 },
                    { 277, 24, 109218, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 265, 89, 144356, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 83, 69, 145746, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 79, 97, 60637, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 44, 89, 31748, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 16, 26, 78544, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 6, null, 0.0 },
                    { 268, 73, 98867, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 236, 63, 50787, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 225, 93, 101179, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 176, 58, 145962, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 140, 38, 59067, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 136, 79, 74518, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 77, 12, 56632, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 72, 72, 97650, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 63, 87, 64894, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 14, 60, 82733, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 5, null, 0.0 },
                    { 42, 37, 68431, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 52, 7, 94125, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 16, null, 0.0 },
                    { 207, 68, 121471, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 12, null, 0.0 },
                    { 30, 17, 94574, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 20, null, 0.0 },
                    { 255, 97, 56663, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 3, null, 0.0 },
                    { 219, 85, 94030, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 64, 42, 75188, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 21, null, 0.0 },
                    { 45, 56, 60131, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 32, 83, 100897, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 39, 36, 29900, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 21, null, 0.0 },
                    { 104, 86, 67414, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 2, null, 0.0 },
                    { 205, 56, 145986, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 2, null, 0.0 },
                    { 276, 15, 38317, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 220, 46, 54097, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 163, 19, 58875, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 138, 3, 103331, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 124, 87, 137794, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 73, 78, 31043, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 19, 37, 114634, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 58, 70, 61862, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 278, 99, 28818, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 158, 42, 32866, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 247, 95, 88901, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 251, 42, 85831, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 65, 6, 124201, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 41, 70, 95932, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 1, null, 0.0 },
                    { 107, 94, 88082, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 210, 84, 48077, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 118, 89, 96788, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 15, 47, 81386, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 43, 2, 79048, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 81, 13, 67788, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 89, 52, 84882, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 123, 76, 73709, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 131, 93, 29083, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 137, 67, 101364, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 190, 58, 61538, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 44, null, 0.0 },
                    { 148, 41, 32486, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 299, 91, 133050, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 43, null, 0.0 },
                    { 198, 57, 36246, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 43, null, 0.0 },
                    { 1, 75, 82067, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 17, 87, 73335, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 60, 55, 48443, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 164, 41, 70373, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 161, 71, 64704, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 186, 19, 97335, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 189, 15, 25481, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 184, 12, 29041, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 204, 33, 94667, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 274, 25, 62716, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 194, 43, 121571, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 238, 28, 104117, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 199, 6, 127935, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 221, 37, 65878, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 234, 55, 80729, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 43, null, 0.0 },
                    { 237, 4, 71066, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 266, 35, 117846, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 282, 26, 104864, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 196, 47, 100544, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 191, 8, 129957, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 102, 35, 143271, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 151, 76, 86195, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 134, 94, 44521, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 110, 5, 130515, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 18, 73, 35943, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 22, null, 0.0 },
                    { 230, 68, 132493, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 95, 53, 71189, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 88, 21, 39531, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 21, 43, 76051, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 43, null, 0.0 },
                    { 90, 17, 74276, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 43, null, 0.0 },
                    { 261, 41, 102263, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 42, null, 0.0 },
                    { 157, 83, 94562, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 154, 1, 135469, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 29, null, 0.0 },
                    { 242, 19, 52560, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 40, 79, 81498, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 9, 4, 144762, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 46, null, 0.0 },
                    { 94, 57, 131458, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 166, 78, 61981, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 },
                    { 23, 43, 96067, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 180, 13, 144436, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 38, null, 0.0 },
                    { 85, 72, 102995, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 38, null, 0.0 },
                    { 51, 59, 141579, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 38, null, 0.0 },
                    { 29, 92, 28870, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 38, null, 0.0 },
                    { 27, 23, 129756, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 38, null, 0.0 },
                    { 76, 66, 32620, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 187, 75, 146104, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 },
                    { 188, 27, 71303, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 },
                    { 193, 74, 148400, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 281, 90, 129524, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 },
                    { 174, 94, 88126, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 223, 13, 131223, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 285, 79, 71662, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 273, 87, 46777, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 235, 52, 50779, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 239, 98, 33056, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 252, 39, 87406, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 260, 89, 102561, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 48, null, 0.0 },
                    { 175, 41, 83037, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 208, 69, 118543, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 257, 25, 148360, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 26, null, 0.0 },
                    { 98, 35, 28860, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 49, null, 0.0 },
                    { 244, 32, 127405, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 267, 89, 133812, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 275, 28, 78234, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 291, 89, 52427, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 35, null, 0.0 },
                    { 246, 13, 29737, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 209, 73, 77432, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 55, 40, 138135, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 80, 45, 121321, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 19, null, 0.0 },
                    { 70, 86, 111694, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 57, 98, 120482, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 2, 99, 66549, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 32, null, 0.0 },
                    { 97, 60, 28536, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 119, 99, 122193, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 206, 4, 95029, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 117, 32, 94496, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 59, 70, 57259, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 62, 79, 90241, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 47, null, 0.0 },
                    { 68, 92, 133591, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 47, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 170, 39, 81136, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 24, null, 0.0 },
                    { 127, 28, 29224, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 47, null, 0.0 },
                    { 56, 79, 121386, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 22, 25, 110681, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 20, 45, 139162, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 25, null, 0.0 },
                    { 103, 80, 145661, new DateTime(2021, 9, 30, 16, 44, 44, 828, DateTimeKind.Local).AddTicks(7355), "Juan Leon", 49, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 66, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 45, 10, null },
                    { 71, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 24, 6, null },
                    { 84, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 17, 8, null },
                    { 60, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 17, 4, null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 24, 8, null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 21, 10, null },
                    { 79, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 29, 1, null },
                    { 78, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 37, 12, null },
                    { 88, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 37, 3, null },
                    { 100, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 11, 4, null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 33, 11, null },
                    { 51, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 32, 15, null },
                    { 91, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 10, 11, null },
                    { 59, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 10, 15, null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 49, 13, null },
                    { 45, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 49, 6, null },
                    { 72, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 1, 3, null },
                    { 94, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 1, 5, null },
                    { 95, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 1, 2, null },
                    { 52, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 3, null },
                    { 53, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 9, null },
                    { 43, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 11, 5, null },
                    { 76, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 48, 13, null },
                    { 57, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 2, null },
                    { 85, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 12, null },
                    { 97, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 6, 11, null },
                    { 25, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 6, 5, null },
                    { 48, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 48, 3, null },
                    { 54, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 39, 6, null },
                    { 86, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 11, 12, null },
                    { 81, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 21, 8, null },
                    { 90, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 6, null },
                    { 98, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 12, 15, null },
                    { 93, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 5, 2, null },
                    { 69, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 5, 7, null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 5, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 5, 13, null },
                    { 73, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 48, 7, null },
                    { 63, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 41, 1, null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 17, 3, null },
                    { 19, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 16, 3, null },
                    { 92, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 23, 4, null },
                    { 56, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 19, 11, null },
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 34, 4, null },
                    { 37, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 34, 13, null },
                    { 55, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 34, 13, null },
                    { 64, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 7, 5, null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 23, 10, null },
                    { 46, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 8, 1, null },
                    { 33, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 25, 5, null },
                    { 82, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 25, 10, null },
                    { 47, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 28, 7, null },
                    { 18, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 16, 8, null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 44, 9, null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 44, 5, null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 25, 6, null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 23, 3, null },
                    { 36, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 3, 11, null },
                    { 96, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 13, 1, null },
                    { 83, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 46, 12, null },
                    { 62, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 20, 4, null },
                    { 67, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 18, 12, null },
                    { 29, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 18, 5, null },
                    { 70, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 46, 10, null },
                    { 21, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 46, 1, null },
                    { 44, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 38, 11, null },
                    { 32, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 9, 9, null },
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 38, 1, null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 38, 2, null },
                    { 24, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 19, 12, null },
                    { 22, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 26, 13, null },
                    { 26, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 13, 8, null },
                    { 27, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 13, 15, null },
                    { 38, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 13, 12, null },
                    { 75, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 40, 10, null },
                    { 34, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 27, 6, null },
                    { 65, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 44, 2, null },
                    { 42, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 27, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 35, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 27, 15, null },
                    { 28, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 30, 15, null },
                    { 23, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 30, 3, null },
                    { 68, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 43, 13, null },
                    { 99, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 43, 6, null },
                    { 77, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 31, 2, null },
                    { 58, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 31, 5, null },
                    { 31, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 31, 12, null },
                    { 20, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 43, 9, null },
                    { 41, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 41, 5, null },
                    { 74, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 41, 7, null },
                    { 39, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 30, 10, null },
                    { 40, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 2, 8, null },
                    { 50, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 16, 5, null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 2, 4, null },
                    { 17, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 31, 9, null },
                    { 89, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 42, 4, null },
                    { 49, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 42, 15, null },
                    { 30, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 31, 7, null },
                    { 61, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 27, 13, null },
                    { 87, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 4, 11, null },
                    { 80, new DateTime(2021, 9, 30, 16, 44, 44, 819, DateTimeKind.Local).AddTicks(5976), "Juan Leon", 16, 4, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 51, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 31, 17, null },
                    { 163, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 18, 12, null },
                    { 9, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 3, 9, null },
                    { 66, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 3, 25, null },
                    { 44, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 31, 22, null },
                    { 5, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 17, 19, null },
                    { 95, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 18, 32, null },
                    { 92, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 27, null },
                    { 135, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 12, 19, null },
                    { 175, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 17, 11, null },
                    { 139, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 17, 20, null },
                    { 73, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 17, 5, null },
                    { 195, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 16, 13, null },
                    { 143, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 25, null },
                    { 46, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 13, null },
                    { 82, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 3, null },
                    { 37, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 21, null },
                    { 32, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 19, null },
                    { 31, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 14, null },
                    { 30, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 28, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 2, null },
                    { 196, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 10, null },
                    { 167, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 28, null },
                    { 146, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 6, null },
                    { 83, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 40, 4, null },
                    { 182, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 29, 6, null },
                    { 151, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 31, 1, null },
                    { 144, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 31, 23, null },
                    { 65, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 12, 23, null },
                    { 128, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 9, null },
                    { 53, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 10, null },
                    { 2, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 1, null },
                    { 45, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 8, null },
                    { 112, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 29, null },
                    { 49, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 29, 12, null },
                    { 38, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 29, 21, null },
                    { 122, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 25, 29, null },
                    { 115, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 7, 14, null },
                    { 183, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 19, 27, null },
                    { 166, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 19, 4, null },
                    { 120, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 19, 28, null },
                    { 68, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 12, null },
                    { 104, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 11, 19, null },
                    { 162, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 18, 18, null },
                    { 91, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 30, 20, null },
                    { 106, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 21, null },
                    { 173, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 38, 29, null },
                    { 161, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 38, 5, null },
                    { 152, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 26, 4, null },
                    { 136, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 26, 2, null },
                    { 114, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 26, 14, null },
                    { 13, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 26, 5, null },
                    { 177, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 23, null },
                    { 176, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 26, null },
                    { 138, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 16, null },
                    { 129, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 9, null },
                    { 97, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 14, null },
                    { 88, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 14, null },
                    { 47, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 47, 16, null },
                    { 148, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 35, 1, null },
                    { 123, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 35, 16, null },
                    { 6, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 46, 11, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 22, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 46, 15, null },
                    { 107, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 46, 7, null },
                    { 156, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 46, 11, null },
                    { 153, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 13, null },
                    { 119, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 2, null },
                    { 19, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 15, null },
                    { 12, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 5, null },
                    { 3, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 7, null },
                    { 169, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 13, 20, null },
                    { 79, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 13, 2, null },
                    { 89, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 35, 20, null },
                    { 62, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 13, 15, null },
                    { 18, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 13, 28, null },
                    { 140, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 9, 16, null },
                    { 102, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 9, 31, null },
                    { 76, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 9, 1, null },
                    { 23, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 9, 30, null },
                    { 150, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 20, 11, null },
                    { 48, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 20, 28, null },
                    { 33, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 13, 15, null },
                    { 154, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 19, null },
                    { 59, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 35, 18, null },
                    { 85, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 44, 3, null },
                    { 188, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 21, 24, null },
                    { 181, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 21, 19, null },
                    { 99, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 21, 27, null },
                    { 116, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 1, 29, null },
                    { 111, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 1, 27, null },
                    { 187, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 32, 22, null },
                    { 164, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 29, null },
                    { 130, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 16, null },
                    { 118, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 5, null },
                    { 113, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 32, null },
                    { 98, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 17, null },
                    { 86, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 16, null },
                    { 40, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 48, 20, null },
                    { 133, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 24, 13, null },
                    { 52, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 24, 16, null },
                    { 15, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 22, 25, null },
                    { 58, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 22, 32, null },
                    { 103, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 22, 22, null },
                    { 126, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 22, 8, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 78, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 44, 1, null },
                    { 56, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 44, 28, null },
                    { 84, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 2, 28, null },
                    { 75, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 2, 14, null },
                    { 69, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 2, 8, null },
                    { 17, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 2, 1, null },
                    { 8, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 2, 24, null },
                    { 42, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 35, 31, null },
                    { 197, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 43, 18, null },
                    { 43, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 43, 23, null },
                    { 41, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 43, 17, null },
                    { 29, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 43, 3, null },
                    { 134, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 42, 2, null },
                    { 100, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 42, 8, null },
                    { 27, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 42, 12, null },
                    { 132, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 22, 9, null },
                    { 168, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 43, 29, null },
                    { 171, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 2, null },
                    { 199, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 23, 14, null },
                    { 35, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 6, null },
                    { 184, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 8, null },
                    { 155, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 24, null },
                    { 101, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 15, null },
                    { 96, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 32, null },
                    { 94, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 7, null },
                    { 90, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 3, null },
                    { 54, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 8, null },
                    { 1, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 11, null },
                    { 157, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 5, 16, null },
                    { 149, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 5, 8, null },
                    { 109, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 5, 6, null },
                    { 57, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 5, 29, null },
                    { 141, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 45, 25, null },
                    { 72, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 45, 21, null },
                    { 26, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 45, 20, null },
                    { 186, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 6, 15, null },
                    { 50, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 10, 24, null },
                    { 63, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 10, 29, null },
                    { 198, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 10, 23, null },
                    { 74, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 2, null },
                    { 34, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 25, null },
                    { 21, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 15, 16, null },
                    { 190, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 16, null },
                    { 137, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 23, null },
                    { 117, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 29, null },
                    { 191, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 12, null },
                    { 55, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 28, null },
                    { 7, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 31, null },
                    { 4, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 31, null },
                    { 180, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 37, 4, null },
                    { 179, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 33, 31, null },
                    { 170, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 33, 20, null },
                    { 77, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 33, 21, null },
                    { 25, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 33, 16, null },
                    { 20, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 39, 29, null },
                    { 14, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 12, null },
                    { 160, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 23, null },
                    { 80, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 11, null },
                    { 10, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 28, null },
                    { 142, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 36, 5, null },
                    { 108, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 36, 32, null },
                    { 70, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 36, 19, null },
                    { 11, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 36, 3, null },
                    { 200, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 28, 31, null },
                    { 158, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 28, 12, null },
                    { 194, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 8, 17, null },
                    { 131, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 8, 26, null },
                    { 39, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 8, 1, null },
                    { 145, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 23, null },
                    { 125, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 32, null },
                    { 105, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 16, null },
                    { 64, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 1, null },
                    { 60, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 34, 18, null },
                    { 93, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 2, null },
                    { 110, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 25, null },
                    { 178, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 16, null },
                    { 189, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 14, null },
                    { 36, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 20, null },
                    { 24, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 6, null },
                    { 174, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 4, 20, null },
                    { 159, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 4, 10, null },
                    { 147, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 4, 29, null },
                    { 124, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 4, 25, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 121, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 41, 18, null },
                    { 127, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 14, 3, null },
                    { 87, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 41, 4, null },
                    { 61, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 41, 20, null },
                    { 185, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 30, 22, null },
                    { 172, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 30, 30, null },
                    { 165, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 30, null },
                    { 81, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 30, 3, null },
                    { 71, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 30, 13, null },
                    { 192, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 27, 22, null },
                    { 67, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 41, 9, null },
                    { 193, new DateTime(2021, 9, 30, 16, 44, 44, 824, DateTimeKind.Local).AddTicks(4899), "Juan Leon", 49, 19, null }
                });

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
