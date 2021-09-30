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
                    { 1, "Greenfelder", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Phillip_Greenfelder@hotmail.com", new DateTime(1993, 5, 7, 15, 49, 3, 84, DateTimeKind.Local).AddTicks(3079), "879489530", "Phillip", "Phillip Greenfelder", "(729) 714-1854 x1336", null },
                    { 28, "Bartoletti", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Erika.Bartoletti@yahoo.com", new DateTime(1958, 1, 16, 16, 26, 53, 738, DateTimeKind.Local).AddTicks(5761), "116171587", "Erika", "Erika Bartoletti", "(278) 458-6881 x0962", null },
                    { 29, "Kunde", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Kim.Kunde@yahoo.com", new DateTime(1986, 10, 9, 8, 20, 57, 439, DateTimeKind.Local).AddTicks(3332), "181089990", "Kim", "Kim Kunde", "(863) 965-2928 x861", null },
                    { 31, "Cormier", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Mildred.Cormier@hotmail.com", new DateTime(1995, 8, 4, 9, 40, 43, 801, DateTimeKind.Local).AddTicks(1554), "538445121", "Mildred", "Mildred Cormier", "503-761-1045", null },
                    { 32, "Gutkowski", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Opal.Gutkowski60@yahoo.com", new DateTime(1973, 5, 29, 2, 25, 45, 944, DateTimeKind.Local).AddTicks(4361), "125109391", "Opal", "Opal Gutkowski", "542.928.0954 x3116", null },
                    { 33, "Hermann", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Sharon_Hermann@gmail.com", new DateTime(1978, 4, 27, 10, 42, 42, 286, DateTimeKind.Local).AddTicks(2465), "912591297", "Sharon", "Sharon Hermann", "1-918-630-0819 x054", null },
                    { 34, "Veum", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Kelly_Veum93@hotmail.com", new DateTime(1993, 2, 18, 8, 43, 11, 183, DateTimeKind.Local).AddTicks(385), "692574157", "Kelly", "Kelly Veum", "(837) 676-6363 x25185", null },
                    { 35, "Green", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Kristen.Green@yahoo.com", new DateTime(1959, 10, 30, 8, 23, 51, 980, DateTimeKind.Local).AddTicks(751), "252449241", "Kristen", "Kristen Green", "684.471.3067 x8329", null },
                    { 36, "Reinger", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Theresa_Reinger@hotmail.com", new DateTime(1976, 7, 5, 12, 46, 31, 683, DateTimeKind.Local).AddTicks(3015), "710190347", "Theresa", "Theresa Reinger", "704-637-2380 x90349", null },
                    { 37, "Parker", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Rita38@gmail.com", new DateTime(1999, 3, 5, 2, 49, 28, 740, DateTimeKind.Local).AddTicks(8776), "957784387", "Rita", "Rita Parker", "762.330.1727 x21491", null },
                    { 38, "O'Connell", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Nina_OConnell38@yahoo.com", new DateTime(1976, 3, 2, 2, 53, 54, 366, DateTimeKind.Local).AddTicks(9562), "982492751", "Nina", "Nina O'Connell", "(911) 986-5281 x2399", null },
                    { 27, "Fadel", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Sandy.Fadel@hotmail.com", new DateTime(1998, 11, 22, 3, 38, 37, 683, DateTimeKind.Local).AddTicks(5695), "674628883", "Sandy", "Sandy Fadel", "523-505-1452", null },
                    { 39, "Abshire", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Ebony92@gmail.com", new DateTime(1988, 6, 14, 7, 14, 31, 283, DateTimeKind.Local).AddTicks(2993), "484967600", "Ebony", "Ebony Abshire", "709-415-5639 x17646", null },
                    { 41, "Christiansen", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Christie_Christiansen@yahoo.com", new DateTime(1994, 4, 10, 9, 46, 26, 434, DateTimeKind.Local).AddTicks(1716), "471812033", "Christie", "Christie Christiansen", "937-932-9186", null },
                    { 42, "Bernhard", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Harry6@yahoo.com", new DateTime(1987, 2, 17, 9, 31, 47, 10, DateTimeKind.Local).AddTicks(2582), "185411588", "Harry", "Harry Bernhard", "856.346.2723", null },
                    { 43, "Cole", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Harold.Cole4@gmail.com", new DateTime(1985, 1, 22, 16, 26, 27, 944, DateTimeKind.Local).AddTicks(773), "377238580", "Harold", "Harold Cole", "972-603-7524 x1966", null },
                    { 44, "Swaniawski", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Blake.Swaniawski73@gmail.com", new DateTime(1968, 2, 7, 14, 7, 45, 94, DateTimeKind.Local).AddTicks(5988), "531903649", "Blake", "Blake Swaniawski", "(592) 639-2811", null },
                    { 45, "Wiegand", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Sonia.Wiegand51@gmail.com", new DateTime(1959, 1, 5, 0, 27, 5, 469, DateTimeKind.Local).AddTicks(5221), "527290088", "Sonia", "Sonia Wiegand", "1-906-383-4010", null },
                    { 46, "Herman", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Douglas.Herman@yahoo.com", new DateTime(1981, 2, 4, 23, 33, 21, 416, DateTimeKind.Local).AddTicks(5204), "264895395", "Douglas", "Douglas Herman", "621-640-4192 x68365", null },
                    { 47, "Pfeffer", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Floyd.Pfeffer@gmail.com", new DateTime(2000, 7, 24, 2, 13, 41, 504, DateTimeKind.Local).AddTicks(1186), "436917315", "Floyd", "Floyd Pfeffer", "412.985.9215 x435", null },
                    { 48, "Dare", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Andrea.Dare14@hotmail.com", new DateTime(1978, 7, 30, 22, 25, 56, 758, DateTimeKind.Local).AddTicks(4806), "695402858", "Andrea", "Andrea Dare", "(208) 992-1208 x13178", null },
                    { 49, "Runte", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Edwin.Runte@hotmail.com", new DateTime(1956, 5, 6, 18, 16, 50, 166, DateTimeKind.Local).AddTicks(1661), "744487712", "Edwin", "Edwin Runte", "(424) 723-2282 x016", null },
                    { 50, "Crooks", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Jean.Crooks@gmail.com", new DateTime(1997, 3, 11, 3, 6, 48, 747, DateTimeKind.Local).AddTicks(7264), "698463485", "Jean", "Jean Crooks", "654-298-7142 x40419", null },
                    { 40, "Reilly", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Earl72@yahoo.com", new DateTime(1973, 1, 5, 0, 26, 13, 59, DateTimeKind.Local).AddTicks(1905), "115477788", "Earl", "Earl Reilly", "902-505-0251 x06477", null },
                    { 26, "Hyatt", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Krista53@hotmail.com", new DateTime(1975, 12, 16, 10, 16, 44, 951, DateTimeKind.Local).AddTicks(7560), "145702807", "Krista", "Krista Hyatt", "1-599-838-6390 x53012", null },
                    { 30, "Murphy", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Israel8@hotmail.com", new DateTime(1968, 1, 22, 13, 14, 6, 196, DateTimeKind.Local).AddTicks(4093), "414054169", "Israel", "Israel Murphy", "256-717-4780", null },
                    { 24, "Renner", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Beth.Renner@gmail.com", new DateTime(1962, 6, 3, 16, 52, 58, 185, DateTimeKind.Local).AddTicks(2790), "407165013", "Beth", "Beth Renner", "748.300.2591", null },
                    { 2, "Kris", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Bennie17@gmail.com", new DateTime(1985, 5, 18, 0, 52, 21, 387, DateTimeKind.Local).AddTicks(9635), "455228140", "Bennie", "Bennie Kris", "507-526-1106 x765", null },
                    { 3, "Wolff", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Amanda50@yahoo.com", new DateTime(1991, 1, 23, 23, 22, 52, 48, DateTimeKind.Local).AddTicks(8199), "579269156", "Amanda", "Amanda Wolff", "717-446-1904 x5437", null },
                    { 4, "Jacobi", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Tim84@yahoo.com", new DateTime(1958, 10, 22, 0, 2, 16, 246, DateTimeKind.Local).AddTicks(6381), "292658084", "Tim", "Tim Jacobi", "310.247.3584 x482", null },
                    { 5, "Lynch", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Ginger7@yahoo.com", new DateTime(1974, 12, 30, 10, 58, 42, 562, DateTimeKind.Local).AddTicks(1463), "443597444", "Ginger", "Ginger Lynch", "259-273-7869 x9570", null },
                    { 6, "Halvorson", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Doreen5@hotmail.com", new DateTime(1982, 1, 4, 18, 9, 34, 948, DateTimeKind.Local).AddTicks(4781), "337300010", "Doreen", "Doreen Halvorson", "749.456.3414 x77984", null },
                    { 7, "Murray", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Dan39@yahoo.com", new DateTime(1954, 5, 8, 7, 35, 50, 633, DateTimeKind.Local).AddTicks(5668), "466117630", "Dan", "Dan Murray", "(442) 237-1995", null },
                    { 8, "Hand", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Rafael.Hand@gmail.com", new DateTime(1965, 10, 21, 8, 42, 4, 926, DateTimeKind.Local).AddTicks(6170), "896005446", "Rafael", "Rafael Hand", "436.310.7525 x544", null },
                    { 25, "Conn", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Phillip45@gmail.com", new DateTime(1977, 9, 23, 14, 40, 48, 957, DateTimeKind.Local).AddTicks(6742), "713591684", "Phillip", "Phillip Conn", "317-839-4727 x30558", null },
                    { 10, "Paucek", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Taylor.Paucek@gmail.com", new DateTime(1996, 12, 10, 21, 18, 31, 581, DateTimeKind.Local).AddTicks(4994), "153373346", "Taylor", "Taylor Paucek", "(369) 393-8787", null },
                    { 11, "Ebert", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Melanie64@hotmail.com", new DateTime(1988, 11, 10, 2, 22, 31, 312, DateTimeKind.Local).AddTicks(725), "644491780", "Melanie", "Melanie Ebert", "1-328-754-5116", null },
                    { 12, "Hettinger", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Vanessa16@hotmail.com", new DateTime(1977, 3, 20, 12, 28, 18, 521, DateTimeKind.Local).AddTicks(2622), "229914581", "Vanessa", "Vanessa Hettinger", "839-794-4863", null },
                    { 9, "Metz", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Josephine_Metz@gmail.com", new DateTime(1970, 11, 1, 0, 41, 45, 423, DateTimeKind.Local).AddTicks(3019), "198972832", "Josephine", "Josephine Metz", "1-768-386-7340 x30432", null },
                    { 14, "Steuber", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Jeanne19@hotmail.com", new DateTime(1980, 6, 25, 9, 45, 1, 149, DateTimeKind.Local).AddTicks(7121), "588851729", "Jeanne", "Jeanne Steuber", "(841) 761-5903 x115", null },
                    { 23, "Torp", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Melanie_Torp17@hotmail.com", new DateTime(1984, 9, 5, 3, 29, 19, 46, DateTimeKind.Local).AddTicks(1518), "563258894", "Melanie", "Melanie Torp", "1-707-706-6757 x2159", null },
                    { 13, "Feest", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Claudia_Feest80@hotmail.com", new DateTime(1967, 7, 4, 6, 3, 31, 745, DateTimeKind.Local).AddTicks(2568), "561481229", "Claudia", "Claudia Feest", "1-950-762-2108", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "Corwin", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Melissa.Corwin@hotmail.com", new DateTime(1989, 10, 12, 13, 10, 36, 698, DateTimeKind.Local).AddTicks(5411), "248605640", "Melissa", "Melissa Corwin", "1-657-870-1430 x27484", null },
                    { 20, "Gutkowski", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Ellen_Gutkowski62@hotmail.com", new DateTime(1988, 12, 26, 18, 43, 26, 628, DateTimeKind.Local).AddTicks(4895), "677980818", "Ellen", "Ellen Gutkowski", "1-675-898-4120", null },
                    { 22, "Pacocha", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Lance_Pacocha@hotmail.com", new DateTime(1959, 10, 2, 0, 37, 8, 234, DateTimeKind.Local).AddTicks(1846), "408095148", "Lance", "Lance Pacocha", "(440) 719-5217 x999", null },
                    { 18, "Luettgen", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Loren.Luettgen42@gmail.com", new DateTime(1998, 5, 31, 11, 36, 58, 756, DateTimeKind.Local).AddTicks(4770), "656903680", "Loren", "Loren Luettgen", "428.568.9162", null },
                    { 17, "Terry", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Maria.Terry@gmail.com", new DateTime(1987, 2, 22, 8, 17, 24, 788, DateTimeKind.Local).AddTicks(6129), "827923942", "Maria", "Maria Terry", "(687) 973-7793 x9976", null },
                    { 16, "Barton", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Dominick_Barton68@gmail.com", new DateTime(1953, 11, 19, 23, 0, 15, 339, DateTimeKind.Local).AddTicks(173), "983432537", "Dominick", "Dominick Barton", "1-303-646-0150 x946", null },
                    { 15, "Vandervort", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Lindsey74@hotmail.com", new DateTime(1977, 10, 11, 5, 12, 46, 748, DateTimeKind.Local).AddTicks(4231), "189213052", "Lindsey", "Lindsey Vandervort", "1-373-374-6819 x0942", null },
                    { 19, "Goodwin", new DateTime(2021, 9, 30, 17, 35, 13, 753, DateTimeKind.Local).AddTicks(2695), "Juan Leon", "Angel.Goodwin54@hotmail.com", new DateTime(1965, 1, 9, 7, 18, 25, 887, DateTimeKind.Local).AddTicks(4068), "565683844", "Angel", "Angel Goodwin", "1-549-807-6610", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 714, DateTimeKind.Local).AddTicks(8571), "Juan Leon", "Activo", null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 714, DateTimeKind.Local).AddTicks(9116), "Juan Leon", "Inactivo", null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 714, DateTimeKind.Local).AddTicks(9122), "Juan Leon", "Devuelto", null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 714, DateTimeKind.Local).AddTicks(9124), "Juan Leon", "Prestamo", null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 714, DateTimeKind.Local).AddTicks(9125), "Juan Leon", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(664), "Juan Leon", "Nintendo", null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(666), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(665), "Juan Leon", "Rockstar", null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(663), "Juan Leon", "Activision", null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(654), "Juan Leon", "Sony", null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(660), "Juan Leon", "Ubisoft", null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(659), "Juan Leon", "EA", null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(661), "Juan Leon", "Rovio", null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(165), "Juan Leon", "Microsoft", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2101), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2100), "Juan Leon", "Android", null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2097), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2096), "Juan Leon", "Nintendo 64", null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2095), "Juan Leon", "PlayStation 5", null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2093), "Juan Leon", "PlayStation 4", null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2092), "Juan Leon", "PlayStation 3", null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2099), "Juan Leon", "Nintendo Switch", null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2090), "Juan Leon", "PlayStation", null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2088), "Juan Leon", "PSP Vita", null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2087), "Juan Leon", "Xbox X", null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2086), "Juan Leon", "Xbox ONE", null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2084), "Juan Leon", "Xbox 360", null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2080), "Juan Leon", "Xbox", null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(1601), "Juan Leon", "PC", null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 716, DateTimeKind.Local).AddTicks(2091), "Juan Leon", "PlayStation 2", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9205), "Juan Leon", "Link", null },
                    { 20, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9206), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9208), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9209), "Juan Leon", "Geralt de Rivia", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9210), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9212), "Juan Leon", "Ellie", null },
                    { 27, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9215), "Juan Leon", "Tracer", null },
                    { 25, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9213), "Juan Leon", "Faith", null },
                    { 26, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9214), "Juan Leon", "Bayonetta", null },
                    { 28, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9217), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9218), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9219), "Juan Leon", "Leon S. Kennedy", null },
                    { 18, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9204), "Juan Leon", "Zelda", null },
                    { 31, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9220), "Juan Leon", "Agente 47", null },
                    { 17, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9203), "Juan Leon", "Jill Valentine", null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9184), "Juan Leon", "John-117", null },
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9200), "Juan Leon", "Gordon Freeman", null },
                    { 32, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9222), "Juan Leon", "Haytham Kenway", null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(8620), "Juan Leon", "Mario Bross", null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9172), "Juan Leon", "Tommy Vercetti", null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9177), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9179), "Juan Leon", "Natan Drake", null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9181), "Juan Leon", "Crash Bandicoot", null },
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9201), "Juan Leon", "Joel", null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9182), "Juan Leon", "Samus Aran", null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9192), "Juan Leon", "Carl Jhonson", null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9194), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9195), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9196), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9198), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9199), "Juan Leon", "Vass", null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9191), "Juan Leon", "Aiden Perce", null },
                    { 33, new DateTime(2021, 9, 30, 17, 35, 13, 715, DateTimeKind.Local).AddTicks(9223), "Juan Leon", "Lara Croft", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 3, 26, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81036.0 },
                    { 41, 10, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31386.0 },
                    { 40, 34, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 120163.0 },
                    { 38, 31, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80309.0 },
                    { 36, 18, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105565.0 },
                    { 32, 46, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27109.0 },
                    { 25, 11, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122541.0 },
                    { 23, 28, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115025.0 },
                    { 22, 16, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72535.0 },
                    { 21, 5, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125790.0 },
                    { 19, 28, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67777.0 },
                    { 18, 37, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67889.0 },
                    { 17, 8, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42827.0 },
                    { 14, 13, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 110291.0 },
                    { 9, 11, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56863.0 },
                    { 6, 12, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 126290.0 },
                    { 5, 21, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 117823.0 },
                    { 4, 17, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58991.0 },
                    { 2, 13, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29467.0 },
                    { 1, 9, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 120922.0 },
                    { 99, 29, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 70356.0 },
                    { 98, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 52419.0 },
                    { 43, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54521.0 },
                    { 44, 45, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100064.0 },
                    { 45, 19, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34626.0 },
                    { 46, 32, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88666.0 },
                    { 100, 39, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 61314.0 },
                    { 96, 3, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54921.0 },
                    { 95, 48, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96105.0 },
                    { 91, 32, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66123.0 },
                    { 85, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68390.0 },
                    { 84, 18, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42157.0 },
                    { 82, 40, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 129890.0 },
                    { 75, 48, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 121564.0 },
                    { 74, 43, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97614.0 },
                    { 69, 29, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144489.0 },
                    { 97, 8, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 109606.0 },
                    { 68, 25, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 101499.0 },
                    { 65, 17, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54708.0 },
                    { 64, 1, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27102.0 },
                    { 60, 23, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65720.0 },
                    { 58, 26, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37285.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 57, 35, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64442.0 },
                    { 55, 46, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 132331.0 },
                    { 53, 14, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125739.0 },
                    { 51, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 136371.0 },
                    { 49, 45, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98702.0 },
                    { 47, 45, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 106552.0 },
                    { 67, 10, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 123071.0 },
                    { 94, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 118865.0 },
                    { 11, 26, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 4, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125422.0 },
                    { 92, 47, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100369.0 },
                    { 48, 35, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122342.0 },
                    { 42, 43, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 145239.0 },
                    { 39, 4, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34585.0 },
                    { 37, 24, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112655.0 },
                    { 35, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115803.0 },
                    { 34, 9, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131011.0 },
                    { 33, 43, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 86503.0 },
                    { 31, 16, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32934.0 },
                    { 93, 25, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 143859.0 },
                    { 29, 45, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 61303.0 },
                    { 50, 28, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44146.0 },
                    { 28, 16, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44880.0 },
                    { 26, 48, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77102.0 },
                    { 24, 49, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68750.0 },
                    { 20, 8, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 127951.0 },
                    { 16, 12, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64708.0 },
                    { 15, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 109062.0 },
                    { 13, 34, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 82509.0 },
                    { 12, 4, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 59574.0 },
                    { 10, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 62643.0 },
                    { 8, 31, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96937.0 },
                    { 7, 23, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 146346.0 },
                    { 27, 25, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 102232.0 },
                    { 52, 24, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32524.0 },
                    { 30, 10, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54761.0 },
                    { 56, 42, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73386.0 },
                    { 54, 46, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45407.0 },
                    { 89, 13, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 148680.0 },
                    { 88, 47, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66096.0 },
                    { 87, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51371.0 },
                    { 86, 42, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25410.0 },
                    { 83, 21, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96178.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 81, 3, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 120551.0 },
                    { 80, 29, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58874.0 },
                    { 79, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 59123.0 },
                    { 78, 33, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39961.0 },
                    { 90, 41, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67416.0 },
                    { 76, 11, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 130551.0 },
                    { 77, 32, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43013.0 },
                    { 61, 36, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49058.0 },
                    { 62, 8, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 126466.0 },
                    { 63, 36, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60633.0 },
                    { 66, 30, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 123312.0 },
                    { 59, 6, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 86450.0 },
                    { 71, 38, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 102054.0 },
                    { 72, 26, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112518.0 },
                    { 73, 34, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58304.0 },
                    { 70, 13, new DateTime(2021, 9, 30, 17, 35, 13, 802, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 3, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28497.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(492), "Juan Leon", 7, "Amy Hennig", null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(485), "Juan Leon", 5, "Gabe Newell", null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(472), "Juan Leon", 7, "Will Wriths", null },
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(496), "Juan Leon", 6, "Warren Spector", null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(489), "Juan Leon", 6, "Shigeru Miyamoto", null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(480), "Juan Leon", 6, "Ken Levine", null },
                    { 22, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(507), "Juan Leon", 5, "Hironobu Sakaguchi", null },
                    { 20, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(504), "Juan Leon", 5, "John Carmack", null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(495), "Juan Leon", 5, "Goichi Suda", null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(488), "Juan Leon", 4, "Yoko Taro", null },
                    { 21, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(505), "Juan Leon", 2, "Keiji Inafune", null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 803, DateTimeKind.Local).AddTicks(9976), "Juan Leon", 4, "Hideo Kojima", null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(486), "Juan Leon", 3, "Tom Howard", null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(477), "Juan Leon", 3, "Hidetaka Miyazaki", null },
                    { 18, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(501), "Juan Leon", 2, "Yuji Naka", null },
                    { 17, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(499), "Juan Leon", 2, "Yuji Horii", null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(493), "Juan Leon", 2, "Michel Ancel", null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(478), "Juan Leon", 2, "Tim Schafer", null },
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(498), "Juan Leon", 1, "John Romero", null },
                    { 19, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(502), "Juan Leon", 7, "Sid Meier", null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(481), "Juan Leon", 4, "Fumito Ueda", null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(483), "Juan Leon", 8, "Yves Guillemot", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2924), "Juan Leon", 16, new DateTime(2002, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 18357.0, 7, null },
                    { 22, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2943), "Juan Leon", 14, new DateTime(2006, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 19534.0, 14, null },
                    { 28, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2959), "Juan Leon", 14, new DateTime(1995, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 15783.0, 3, null },
                    { 33, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2974), "Juan Leon", 14, new DateTime(2011, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 16871.0, 7, null },
                    { 42, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2999), "Juan Leon", 14, new DateTime(2006, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 19887.0, 13, null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2912), "Juan Leon", 20, new DateTime(2010, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 24196.0, 10, null },
                    { 21, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2940), "Juan Leon", 20, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 20783.0, 14, null },
                    { 43, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3001), "Juan Leon", 5, new DateTime(2012, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 24790.0, 7, null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2899), "Juan Leon", 11, new DateTime(2012, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 15161.0, 8, null },
                    { 24, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2949), "Juan Leon", 11, new DateTime(1996, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 18863.0, 5, null },
                    { 45, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3007), "Juan Leon", 11, new DateTime(1996, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 19906.0, 2, null },
                    { 47, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3013), "Juan Leon", 11, new DateTime(1998, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 22465.0, 6, null },
                    { 40, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2993), "Juan Leon", 15, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 24355.0, 6, null },
                    { 44, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3004), "Juan Leon", 2, new DateTime(2009, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 24134.0, 2, null },
                    { 48, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3015), "Juan Leon", 2, new DateTime(2004, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 19907.0, 10, null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2902), "Juan Leon", 12, new DateTime(1995, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 16394.0, 7, null },
                    { 27, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2956), "Juan Leon", 19, new DateTime(2004, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 16019.0, 13, null },
                    { 50, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3020), "Juan Leon", 19, new DateTime(2016, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 18685.0, 10, null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2909), "Juan Leon", 7, new DateTime(2012, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 15848.0, 12, null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2922), "Juan Leon", 7, new DateTime(2006, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 23698.0, 10, null },
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2927), "Juan Leon", 7, new DateTime(1997, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 18592.0, 12, null },
                    { 20, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2938), "Juan Leon", 7, new DateTime(1997, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 22438.0, 9, null },
                    { 30, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2966), "Juan Leon", 8, new DateTime(2010, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 19933.0, 7, null },
                    { 19, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2935), "Juan Leon", 8, new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 24407.0, 5, null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2896), "Juan Leon", 8, new DateTime(2009, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 20922.0, 8, null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2894), "Juan Leon", 10, new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 22336.0, 6, null },
                    { 18, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2932), "Juan Leon", 16, new DateTime(2010, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 23654.0, 9, null },
                    { 29, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2962), "Juan Leon", 16, new DateTime(2014, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 18335.0, 6, null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2919), "Juan Leon", 4, new DateTime(2001, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 19683.0, 11, null },
                    { 25, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2951), "Juan Leon", 4, new DateTime(2003, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 22101.0, 9, null },
                    { 34, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2977), "Juan Leon", 4, new DateTime(2004, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 17830.0, 3, null },
                    { 36, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2982), "Juan Leon", 13, new DateTime(2004, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 20925.0, 12, null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2904), "Juan Leon", 17, new DateTime(1998, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 22295.0, 9, null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2907), "Juan Leon", 17, new DateTime(2001, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 18390.0, 10, null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2887), "Juan Leon", 21, new DateTime(2009, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 23915.0, 8, null },
                    { 26, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2954), "Juan Leon", 21, new DateTime(2002, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 20498.0, 5, null },
                    { 35, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2979), "Juan Leon", 7, new DateTime(2009, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 22076.0, 7, null },
                    { 32, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2972), "Juan Leon", 21, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 15028.0, 3, null },
                    { 31, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2969), "Juan Leon", 3, new DateTime(2003, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 18159.0, 12, null },
                    { 46, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3010), "Juan Leon", 3, new DateTime(1996, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 24182.0, 14, null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2914), "Juan Leon", 9, new DateTime(2012, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 24519.0, 12, null },
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2917), "Juan Leon", 9, new DateTime(1995, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 22167.0, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2946), "Juan Leon", 9, new DateTime(2011, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 19119.0, 13, null },
                    { 49, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(3017), "Juan Leon", 9, new DateTime(2013, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 20706.0, 8, null },
                    { 17, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2930), "Juan Leon", 1, new DateTime(2001, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 15678.0, 11, null },
                    { 38, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2988), "Juan Leon", 1, new DateTime(2012, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 20774.0, 10, null },
                    { 41, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2996), "Juan Leon", 1, new DateTime(2006, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 23969.0, 11, null },
                    { 39, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2990), "Juan Leon", 6, new DateTime(2012, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 15022.0, 4, null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2398), "Juan Leon", 3, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 18454.0, 4, null },
                    { 37, new DateTime(2021, 9, 30, 17, 35, 13, 804, DateTimeKind.Local).AddTicks(2984), "Juan Leon", 7, new DateTime(1999, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 23994.0, 13, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 61, 99, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 15, null, 0.0 },
                    { 19, 55, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 41, null, 0.0 },
                    { 63, 94, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 22, 57, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 80, 74, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 107, 1, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 289, 77, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 248, 73, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 170, 25, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 53, 23, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 41, null, 0.0 },
                    { 127, 12, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 20, 26, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 187, 80, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 222, 59, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 234, 16, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 6, null, 0.0 },
                    { 109, 84, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 131, 23, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 206, 82, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 177, 28, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 106, 32, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 38, null, 0.0 },
                    { 156, 50, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 146, 5, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 41, null, 0.0 },
                    { 266, 79, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 41, null, 0.0 },
                    { 197, 77, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 216, 42, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 224, 6, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 268, 96, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 242, 14, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 },
                    { 239, 84, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 },
                    { 134, 72, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 },
                    { 113, 79, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 },
                    { 259, 66, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 41, null, 0.0 },
                    { 57, 81, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 },
                    { 281, 18, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 256, 94, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 39, null, 0.0 },
                    { 137, 74, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 39, null, 0.0 },
                    { 32, 62, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 39, null, 0.0 },
                    { 14, 99, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 47, null, 0.0 },
                    { 4, 72, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 47, null, 0.0 },
                    { 35, 33, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 48, 31, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 36, 55, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 3, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 188, 62, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 141, 28, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 101, 98, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 262, 36, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 273, 31, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 199, 36, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 30, 66, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 108, 1, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 229, 72, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 12, null, 0.0 },
                    { 176, 17, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 12, null, 0.0 },
                    { 160, 4, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 235, 98, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 208, 83, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 276, 9, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 11, null, 0.0 },
                    { 227, 71, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 11, null, 0.0 },
                    { 116, 8, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 11, null, 0.0 },
                    { 91, 83, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 11, null, 0.0 },
                    { 51, 31, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 11, null, 0.0 },
                    { 228, 39, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 280, 58, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 287, 23, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 218, 88, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 9, null, 0.0 },
                    { 104, 89, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 56, 9, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 39, 71, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 34, 49, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 17, null, 0.0 },
                    { 161, 91, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 193, 60, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 5, null, 0.0 },
                    { 25, 12, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 147, 68, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 49, null, 0.0 },
                    { 119, 8, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 49, null, 0.0 },
                    { 124, 75, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 164, 1, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 29, 11, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 215, 45, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 250, 47, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 237, 22, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 209, 62, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 195, 29, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 103, 78, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 67, 39, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 65, 5, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 40, 34, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 217, 60, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 27, null, 0.0 },
                    { 18, 16, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 60, 79, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 44, 94, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 219, 97, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 233, 20, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 240, 68, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 83, 71, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 88, 73, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 293, 28, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 42, null, 0.0 },
                    { 253, 35, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 42, null, 0.0 },
                    { 132, 97, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 42, null, 0.0 },
                    { 213, 85, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 90, 37, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 183, 73, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 41, 99, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 33, null, 0.0 },
                    { 31, 68, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 33, null, 0.0 },
                    { 201, 70, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 202, 42, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 220, 30, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 299, 44, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 254, 16, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 93, 58, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 40, null, 0.0 },
                    { 296, 71, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 28, null, 0.0 },
                    { 23, 33, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 75, 69, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 148, 67, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 47, null, 0.0 },
                    { 189, 73, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 47, null, 0.0 },
                    { 261, 43, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 47, null, 0.0 },
                    { 300, 80, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 274, 34, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 204, 24, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 121, 97, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 78, 9, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 45, 24, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 72, 25, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 46, 65, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 295, 34, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 275, 5, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 230, 99, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 196, 9, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 139, 93, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 125, 33, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 110, 36, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 10, null, 0.0 },
                    { 71, 11, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 21, null, 0.0 },
                    { 13, 93, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 245, 22, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 28, null, 0.0 },
                    { 192, 25, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 28, null, 0.0 },
                    { 200, 57, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 181, 71, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 123, 3, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 99, 84, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 68, 70, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 9, 32, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 270, 57, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 271, 24, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 226, 52, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 19, null, 0.0 },
                    { 277, 85, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 8, 85, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 48, null, 0.0 },
                    { 282, 20, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 225, 87, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 168, 35, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 162, 69, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 130, 68, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 120, 69, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 54, 41, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 4, null, 0.0 },
                    { 278, 47, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 231, 1, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 28, null, 0.0 },
                    { 258, 35, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 33, 56, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 47, 87, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 28, null, 0.0 },
                    { 260, 48, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 6, 68, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 70, 22, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 92, 5, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 111, 50, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 247, 79, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 22, null, 0.0 },
                    { 194, 31, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 22, null, 0.0 },
                    { 10, 1, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 152, 22, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 22, null, 0.0 },
                    { 157, 59, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 174, 27, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 210, 78, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 232, 30, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 44, null, 0.0 },
                    { 252, 53, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 212, 17, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 159, 46, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 105, 53, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 30, null, 0.0 },
                    { 64, 63, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 22, null, 0.0 },
                    { 58, 63, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 16, 67, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 23, null, 0.0 },
                    { 246, 93, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 291, 94, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 288, 37, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 272, 45, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 94, 62, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 81, 12, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 5, 92, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 36, null, 0.0 },
                    { 118, 80, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 35, null, 0.0 },
                    { 129, 88, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 35, null, 0.0 },
                    { 297, 64, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 283, 58, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 263, 54, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 255, 91, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 182, 12, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 95, 96, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 69, 31, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 42, 50, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 35, null, 0.0 },
                    { 11, 61, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 35, null, 0.0 },
                    { 84, 73, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 50, 19, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 221, 44, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 8, null, 0.0 },
                    { 85, 49, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 122, 1, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 144, 83, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 145, 96, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 180, 17, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 214, 32, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 59, 26, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 186, 2, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 165, 6, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 154, 56, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 140, 58, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 74, 99, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 66, 86, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 1, 68, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 223, 31, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 178, 37, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 7, null, 0.0 },
                    { 26, 63, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 34, null, 0.0 },
                    { 205, 58, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 166, 12, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 175, 22, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 138, 29, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 96, 15, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 76, 44, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 49, 54, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 38, 11, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 21, 21, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 179, 99, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 298, 21, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 18, null, 0.0 },
                    { 143, 76, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 18, null, 0.0 },
                    { 135, 95, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 18, null, 0.0 },
                    { 114, 82, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 18, null, 0.0 },
                    { 286, 14, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 151, 76, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 15, null, 0.0 },
                    { 115, 51, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 15, null, 0.0 },
                    { 79, 44, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 15, null, 0.0 },
                    { 198, 54, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 18, null, 0.0 },
                    { 292, 28, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 8, null, 0.0 },
                    { 238, 99, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 264, 31, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 133, 88, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 126, 29, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 52, 15, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 43, 49, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 25, null, 0.0 },
                    { 102, 92, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 155, 18, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 158, 29, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 243, 41, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 29, null, 0.0 },
                    { 257, 50, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 45, null, 0.0 },
                    { 190, 93, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 13, null, 0.0 },
                    { 128, 78, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 13, null, 0.0 },
                    { 17, 48, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 13, null, 0.0 },
                    { 7, 54, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 13, null, 0.0 },
                    { 24, 39, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 37, null, 0.0 },
                    { 73, 96, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 37, null, 0.0 },
                    { 163, 61, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 37, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 285, 91, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 13, null, 0.0 },
                    { 77, 42, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 20, null, 0.0 },
                    { 87, 22, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 43, null, 0.0 },
                    { 294, 59, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 97, 20, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 171, 32, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 98, 74, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 117, 12, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 142, 32, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 251, 99, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 236, 28, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 1, null, 0.0 },
                    { 3, 59, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 16, null, 0.0 },
                    { 27, 68, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 112, 15, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 191, 2, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 185, 19, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 153, 52, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 82, 88, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 100, 70, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 172, 24, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 207, 40, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 265, 14, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 269, 19, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 290, 43, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 62, 43, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 55, 17, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 31, null, 0.0 },
                    { 284, 65, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 279, 81, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 173, 79, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 2, 9, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 1, null, 0.0 },
                    { 86, 92, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 1, null, 0.0 },
                    { 89, 27, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 1, null, 0.0 },
                    { 167, 89, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 32, null, 0.0 },
                    { 28, 75, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 },
                    { 249, 27, 9, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 1, null, 0.0 },
                    { 184, 82, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 16, null, 0.0 },
                    { 37, 56, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 46, null, 0.0 },
                    { 15, 18, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 46, null, 0.0 },
                    { 211, 12, 7, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 2, null, 0.0 },
                    { 150, 66, 6, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 2, null, 0.0 },
                    { 136, 89, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 },
                    { 12, 72, 8, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 26, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 149, 15, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 46, null, 0.0 },
                    { 203, 94, 1, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 46, null, 0.0 },
                    { 267, 60, 3, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 16, null, 0.0 },
                    { 244, 53, 5, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 16, null, 0.0 },
                    { 241, 56, 2, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 16, null, 0.0 },
                    { 169, 29, 4, new DateTime(2021, 9, 30, 17, 35, 13, 813, DateTimeKind.Local).AddTicks(7901), "Juan Leon", 24, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 42, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 33, 15, null },
                    { 41, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 29, 3, null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 2, null },
                    { 34, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 21, 11, null },
                    { 82, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 14, 4, null },
                    { 86, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 14, 9, null },
                    { 17, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 40, 4, null },
                    { 58, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 28, 9, null },
                    { 51, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 1, 12, null },
                    { 83, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 28, 11, null },
                    { 76, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 28, 1, null },
                    { 67, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 33, 1, null },
                    { 84, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 21, 14, null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 47, 14, null },
                    { 62, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 9, 9, null },
                    { 39, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 28, 15, null },
                    { 18, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 1, 11, null },
                    { 74, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 40, 5, null },
                    { 53, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 15, 10, null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 9, 1, null },
                    { 69, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 15, 14, null },
                    { 23, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 18, 7, null },
                    { 40, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 18, 14, null },
                    { 80, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 18, 13, null },
                    { 95, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 47, 4, null },
                    { 87, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 18, 2, null },
                    { 30, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 2, null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 14, 8, null },
                    { 31, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 2, null },
                    { 91, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 31, 10, null },
                    { 37, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 7, null },
                    { 61, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 15, 6, null },
                    { 75, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 11, 3, null },
                    { 93, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 10, 15, null },
                    { 90, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 31, 14, null },
                    { 46, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 31, 11, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 32, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 47, 10, null },
                    { 19, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 47, 14, null },
                    { 48, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 1, null },
                    { 88, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 37, 9, null },
                    { 70, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 33, 15, null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 45, 5, null },
                    { 20, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 45, 8, null },
                    { 96, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 11, 15, null },
                    { 24, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 23, 2, null },
                    { 64, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 46, 15, null },
                    { 98, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 13, 6, null },
                    { 50, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 17, 6, null },
                    { 89, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 17, 4, null },
                    { 73, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 46, 9, null },
                    { 78, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 3, 10, null },
                    { 60, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 3, 10, null },
                    { 33, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 3, 1, null },
                    { 72, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 2, 14, null },
                    { 66, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 2, 2, null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 7, 4, null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 7, 11, null },
                    { 21, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 7, 1, null },
                    { 36, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 7, 2, null },
                    { 56, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 38, 2, null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 48, 1, null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 48, 10, null },
                    { 85, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 48, 12, null },
                    { 52, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 43, 12, null },
                    { 38, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 39, 2, null },
                    { 92, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 38, 8, null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 2, 7, null },
                    { 68, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 43, 13, null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 16, 1, null },
                    { 22, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 8, 6, null },
                    { 25, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 41, 7, null },
                    { 47, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 8, 12, null },
                    { 26, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 36, 4, null },
                    { 35, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 13, 1, null },
                    { 29, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 4, 4, null },
                    { 45, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 26, 11, null },
                    { 77, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 22, 11, null },
                    { 63, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 22, 7, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 27, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 22, 12, null },
                    { 94, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 32, 15, null },
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 32, 2, null },
                    { 59, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 23, 1, null },
                    { 99, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 23, 13, null },
                    { 54, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 25, 15, null },
                    { 81, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 35, 9, null },
                    { 79, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 30, 5, null },
                    { 49, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 4, 8, null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 30, 6, null },
                    { 43, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 30, 6, null },
                    { 57, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 44, 13, null },
                    { 71, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 44, 11, null },
                    { 100, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 19, 4, null },
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 19, 5, null },
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 19, 11, null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 49, 11, null },
                    { 55, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 49, 9, null },
                    { 28, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 34, 5, null },
                    { 44, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 35, 1, null },
                    { 97, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 26, 13, null },
                    { 65, new DateTime(2021, 9, 30, 17, 35, 13, 807, DateTimeKind.Local).AddTicks(519), "Juan Leon", 35, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 112, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 20, null },
                    { 170, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 7, null },
                    { 173, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 24, null },
                    { 153, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 18, null },
                    { 157, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 6, 12, null },
                    { 42, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 47, 22, null },
                    { 154, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 20, null },
                    { 190, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 7, null },
                    { 192, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 8, null },
                    { 106, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 14, 15, null },
                    { 134, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 14, 8, null },
                    { 164, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 14, 4, null },
                    { 181, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 14, 2, null },
                    { 19, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 16, 10, null },
                    { 75, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 16, 12, null },
                    { 168, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 16, 4, null },
                    { 47, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 20, 32, null },
                    { 82, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 20, 7, null },
                    { 7, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 35, 15, null },
                    { 46, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 35, 23, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 118, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 35, 17, null },
                    { 188, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 35, 4, null },
                    { 89, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 37, 13, null },
                    { 143, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 37, 15, null },
                    { 150, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 37, 3, null },
                    { 152, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 29, null },
                    { 23, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 47, 28, null },
                    { 96, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 22, null },
                    { 196, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 27, 13, null },
                    { 101, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 47, 21, null },
                    { 175, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 47, 25, null },
                    { 63, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 40, 2, null },
                    { 183, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 40, 15, null },
                    { 74, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 44, 7, null },
                    { 126, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 44, 7, null },
                    { 135, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 44, 24, null },
                    { 156, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 44, 1, null },
                    { 41, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 32, null },
                    { 61, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 13, null },
                    { 103, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 18, null },
                    { 158, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 8, null },
                    { 163, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 24, null },
                    { 167, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 16, null },
                    { 191, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 48, 19, null },
                    { 1, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 6, 30, null },
                    { 50, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 6, 7, null },
                    { 105, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 6, 5, null },
                    { 85, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 22, null },
                    { 45, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 9, 5, null },
                    { 73, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 6, null },
                    { 88, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 4, 4, null },
                    { 3, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 32, null },
                    { 162, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 31, 3, null },
                    { 125, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 31, 17, null },
                    { 90, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 31, 22, null },
                    { 20, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 31, 7, null },
                    { 165, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 1, 15, null },
                    { 139, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 1, 23, null },
                    { 5, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 16, null },
                    { 195, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 32, 21, null },
                    { 72, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 32, 24, null },
                    { 199, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 26, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 65, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 26, 8, null },
                    { 172, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 2, 31, null },
                    { 123, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 2, 24, null },
                    { 81, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 2, 14, null },
                    { 97, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 32, 28, null },
                    { 12, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 24, null },
                    { 31, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 6, null },
                    { 66, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 30, null },
                    { 133, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 23, 31, null },
                    { 104, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 23, 25, null },
                    { 55, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 23, 14, null },
                    { 197, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 23, null },
                    { 161, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 25, null },
                    { 108, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 6, null },
                    { 100, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 20, null },
                    { 78, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 1, null },
                    { 56, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 12, 18, null },
                    { 84, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 11, 8, null },
                    { 59, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 11, 26, null },
                    { 8, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 11, 3, null },
                    { 198, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 8, null },
                    { 180, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 7, null },
                    { 149, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 46, 19, null },
                    { 22, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 2, 16, null },
                    { 138, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 8, 26, null },
                    { 117, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 8, 2, null },
                    { 111, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 8, 2, null },
                    { 80, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 13, 13, null },
                    { 70, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 13, 23, null },
                    { 21, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 13, 10, null },
                    { 194, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 29, 7, null },
                    { 140, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 29, 25, null },
                    { 26, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 29, 23, null },
                    { 25, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 29, 6, null },
                    { 33, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 18, 24, null },
                    { 171, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 4, null },
                    { 141, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 21, null },
                    { 102, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 21, null },
                    { 68, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 32, null },
                    { 48, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 3, null },
                    { 24, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 3, null },
                    { 6, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 15, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 107, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 13, 19, null },
                    { 169, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 23, 6, null },
                    { 83, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 25, 10, null },
                    { 98, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 34, 15, null },
                    { 94, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 8, 5, null },
                    { 91, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 8, 28, null },
                    { 200, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 7, 15, null },
                    { 130, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 7, 9, null },
                    { 62, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 7, 17, null },
                    { 37, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 7, 27, null },
                    { 16, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 7, 18, null },
                    { 187, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 18, null },
                    { 160, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 1, null },
                    { 144, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 17, null },
                    { 129, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 23, null },
                    { 60, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 30, null },
                    { 4, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 36, 11, null },
                    { 159, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 34, 20, null },
                    { 114, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 34, 23, null },
                    { 113, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 25, 23, null },
                    { 30, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 45, 21, null },
                    { 29, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 49, 20, null },
                    { 176, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 49, 10, null },
                    { 116, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 33, 11, null },
                    { 58, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 33, 31, null },
                    { 35, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 33, 17, null },
                    { 179, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 3, null },
                    { 119, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 7, null },
                    { 109, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 8, null },
                    { 15, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 13, null },
                    { 87, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 1, null },
                    { 54, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 30, null },
                    { 13, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 9, null },
                    { 151, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 22, 6, null },
                    { 132, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 22, 16, null },
                    { 128, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 22, 29, null },
                    { 121, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 22, 13, null },
                    { 69, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 28, 29, null },
                    { 71, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 28, null },
                    { 92, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 6, null },
                    { 131, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 25, null },
                    { 193, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 24, 18, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 155, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 24, 21, null },
                    { 34, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 24, 11, null },
                    { 32, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 24, 18, null },
                    { 76, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 43, 1, null },
                    { 17, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 43, 12, null },
                    { 124, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 21, 2, null },
                    { 53, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 21, 4, null },
                    { 52, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 21, 3, null },
                    { 39, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 21, 15, null },
                    { 120, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 10, 27, null },
                    { 28, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 10, 21, null },
                    { 178, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 22, null },
                    { 177, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 24, null },
                    { 166, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 42, 14, null },
                    { 99, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 22, 14, null },
                    { 182, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 30, 1, null },
                    { 145, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 30, 26, null },
                    { 136, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 30, 12, null },
                    { 9, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 39, 24, null },
                    { 110, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 41, 20, null },
                    { 79, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 41, 29, null },
                    { 57, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 41, 7, null },
                    { 49, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 41, 16, null },
                    { 43, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 41, 14, null },
                    { 186, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 38, 17, null },
                    { 146, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 38, 29, null },
                    { 36, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 38, 16, null },
                    { 27, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 38, 26, null },
                    { 115, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 17, 21, null },
                    { 95, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 17, 10, null },
                    { 67, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 17, 19, null },
                    { 38, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 17, 25, null },
                    { 2, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 17, 15, null },
                    { 18, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 39, 23, null },
                    { 148, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 49, 22, null },
                    { 40, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 39, 23, null },
                    { 77, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 39, 6, null },
                    { 127, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 30, 21, null },
                    { 93, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 19, 29, null },
                    { 86, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 19, 11, null },
                    { 51, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 19, 32, null },
                    { 184, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 4, 20, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 147, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 4, 30, null },
                    { 142, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 4, 27, null },
                    { 174, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 37, 23, null },
                    { 64, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 4, 6, null },
                    { 185, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 28, null },
                    { 137, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 32, null },
                    { 122, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 7, null },
                    { 14, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 18, null },
                    { 11, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 15, null },
                    { 10, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 3, 19, null },
                    { 44, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 39, 3, null },
                    { 189, new DateTime(2021, 9, 30, 17, 35, 13, 810, DateTimeKind.Local).AddTicks(1877), "Juan Leon", 37, 22, null }
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
