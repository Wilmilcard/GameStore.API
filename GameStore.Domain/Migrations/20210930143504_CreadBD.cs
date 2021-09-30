using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Domain.Migrations
{
    public partial class CreadBD : Migration
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
                    { 1, "Roberts", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Dana_Roberts61@gmail.com", new DateTime(1994, 10, 27, 0, 33, 17, 388, DateTimeKind.Local).AddTicks(3075), "767616243", "Dana", "Dana Roberts", "529.680.1102 x90763", null },
                    { 28, "Johns", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Sherman22@hotmail.com", new DateTime(1957, 5, 12, 20, 29, 16, 504, DateTimeKind.Local).AddTicks(5005), "775535168", "Sherman", "Sherman Johns", "544.633.0191 x75221", null },
                    { 29, "Tromp", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Norma.Tromp@hotmail.com", new DateTime(1956, 8, 16, 7, 29, 29, 593, DateTimeKind.Local).AddTicks(2180), "752831785", "Norma", "Norma Tromp", "(336) 459-1169 x2378", null },
                    { 31, "Carter", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Angelo.Carter47@hotmail.com", new DateTime(1974, 12, 30, 8, 49, 26, 623, DateTimeKind.Local).AddTicks(1273), "602873932", "Angelo", "Angelo Carter", "690.454.7058", null },
                    { 32, "Koss", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Lucia_Koss@gmail.com", new DateTime(1983, 12, 28, 21, 47, 29, 352, DateTimeKind.Local).AddTicks(7613), "468067860", "Lucia", "Lucia Koss", "603.299.8833 x70989", null },
                    { 33, "Hansen", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Sarah_Hansen37@yahoo.com", new DateTime(1967, 9, 3, 2, 56, 21, 653, DateTimeKind.Local).AddTicks(2187), "347057216", "Sarah", "Sarah Hansen", "(628) 675-8445", null },
                    { 34, "Crona", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Courtney_Crona@yahoo.com", new DateTime(1986, 9, 23, 17, 35, 49, 287, DateTimeKind.Local).AddTicks(4945), "792983892", "Courtney", "Courtney Crona", "1-252-883-9622 x75000", null },
                    { 35, "Macejkovic", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Doris13@yahoo.com", new DateTime(1956, 7, 5, 2, 31, 28, 199, DateTimeKind.Local).AddTicks(5708), "142652908", "Doris", "Doris Macejkovic", "1-328-977-0073", null },
                    { 36, "Nitzsche", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Rene_Nitzsche@hotmail.com", new DateTime(1977, 4, 5, 19, 17, 26, 186, DateTimeKind.Local).AddTicks(1595), "608133055", "Rene", "Rene Nitzsche", "(854) 277-3706 x538", null },
                    { 37, "Reichel", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Lynette_Reichel84@hotmail.com", new DateTime(1991, 4, 26, 16, 34, 19, 50, DateTimeKind.Local).AddTicks(9873), "924089612", "Lynette", "Lynette Reichel", "493-742-5669 x244", null },
                    { 38, "Barton", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Edith40@yahoo.com", new DateTime(1968, 12, 30, 20, 3, 59, 767, DateTimeKind.Local).AddTicks(1488), "519248493", "Edith", "Edith Barton", "965-292-0144 x10486", null },
                    { 27, "Prosacco", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Vanessa29@hotmail.com", new DateTime(1953, 1, 27, 2, 4, 5, 627, DateTimeKind.Local).AddTicks(9586), "510536969", "Vanessa", "Vanessa Prosacco", "807.563.8099 x286", null },
                    { 39, "Herzog", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Jonathon.Herzog92@gmail.com", new DateTime(1952, 8, 28, 20, 44, 25, 30, DateTimeKind.Local).AddTicks(7681), "347288271", "Jonathon", "Jonathon Herzog", "683.462.7958 x58905", null },
                    { 41, "McLaughlin", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Henrietta.McLaughlin@gmail.com", new DateTime(1995, 3, 3, 0, 0, 21, 429, DateTimeKind.Local).AddTicks(281), "847935870", "Henrietta", "Henrietta McLaughlin", "(711) 235-9739 x1096", null },
                    { 42, "Stroman", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Toni7@hotmail.com", new DateTime(1989, 7, 13, 4, 1, 14, 548, DateTimeKind.Local).AddTicks(8687), "444776128", "Toni", "Toni Stroman", "581.271.6960 x2554", null },
                    { 43, "Lockman", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Kelly71@hotmail.com", new DateTime(1976, 6, 26, 1, 28, 56, 207, DateTimeKind.Local).AddTicks(5661), "678197151", "Kelly", "Kelly Lockman", "(769) 949-2634", null },
                    { 44, "Beier", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Estelle.Beier98@yahoo.com", new DateTime(1961, 9, 7, 14, 58, 28, 449, DateTimeKind.Local).AddTicks(4736), "867025896", "Estelle", "Estelle Beier", "1-577-710-8579 x64315", null },
                    { 45, "Cummerata", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Michele.Cummerata20@hotmail.com", new DateTime(1974, 4, 25, 5, 20, 15, 557, DateTimeKind.Local).AddTicks(6562), "486970691", "Michele", "Michele Cummerata", "341.567.7615 x29848", null },
                    { 46, "Quigley", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Courtney96@yahoo.com", new DateTime(1960, 2, 16, 17, 55, 52, 469, DateTimeKind.Local).AddTicks(7663), "844977344", "Courtney", "Courtney Quigley", "(412) 834-8703 x1055", null },
                    { 47, "Reichel", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Desiree.Reichel@gmail.com", new DateTime(1996, 8, 25, 2, 8, 6, 706, DateTimeKind.Local).AddTicks(1353), "570368686", "Desiree", "Desiree Reichel", "698-528-1549", null },
                    { 48, "Torphy", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Olga.Torphy14@hotmail.com", new DateTime(1964, 8, 26, 4, 56, 55, 469, DateTimeKind.Local).AddTicks(7926), "324842426", "Olga", "Olga Torphy", "374-450-5645 x05931", null },
                    { 49, "Bailey", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Lowell.Bailey29@yahoo.com", new DateTime(1977, 12, 7, 2, 44, 12, 167, DateTimeKind.Local).AddTicks(1760), "590222345", "Lowell", "Lowell Bailey", "1-750-700-8562 x51209", null },
                    { 50, "Rodriguez", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Omar.Rodriguez34@yahoo.com", new DateTime(1995, 10, 9, 18, 39, 44, 646, DateTimeKind.Local).AddTicks(2646), "304304861", "Omar", "Omar Rodriguez", "1-507-893-9184", null },
                    { 40, "Armstrong", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Vickie.Armstrong40@hotmail.com", new DateTime(1992, 11, 17, 0, 31, 7, 169, DateTimeKind.Local).AddTicks(6408), "372963197", "Vickie", "Vickie Armstrong", "526-647-9067", null },
                    { 26, "Paucek", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Kurt_Paucek48@hotmail.com", new DateTime(1962, 4, 14, 21, 1, 48, 379, DateTimeKind.Local).AddTicks(3519), "207768317", "Kurt", "Kurt Paucek", "212.767.6970", null },
                    { 30, "Quitzon", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Austin.Quitzon@hotmail.com", new DateTime(1954, 2, 14, 14, 12, 45, 45, DateTimeKind.Local).AddTicks(7408), "840605319", "Austin", "Austin Quitzon", "622-537-3509 x152", null },
                    { 24, "Shanahan", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Rickey.Shanahan@hotmail.com", new DateTime(1992, 3, 20, 8, 39, 8, 442, DateTimeKind.Local).AddTicks(2212), "967257066", "Rickey", "Rickey Shanahan", "578.862.4537 x25373", null },
                    { 2, "Barrows", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Israel_Barrows@yahoo.com", new DateTime(1951, 11, 3, 12, 20, 2, 749, DateTimeKind.Local).AddTicks(3955), "383210845", "Israel", "Israel Barrows", "484-397-2158 x80926", null },
                    { 3, "Osinski", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Regina_Osinski@yahoo.com", new DateTime(1991, 4, 29, 7, 20, 28, 923, DateTimeKind.Local).AddTicks(732), "529406206", "Regina", "Regina Osinski", "1-541-360-3779 x2481", null },
                    { 4, "Schimmel", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Brandi90@gmail.com", new DateTime(1985, 5, 1, 13, 24, 33, 133, DateTimeKind.Local).AddTicks(8818), "333190220", "Brandi", "Brandi Schimmel", "1-641-289-4995 x965", null },
                    { 5, "Hammes", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Phyllis_Hammes57@gmail.com", new DateTime(1979, 3, 30, 21, 47, 23, 977, DateTimeKind.Local).AddTicks(968), "910992080", "Phyllis", "Phyllis Hammes", "308-461-8783 x56756", null },
                    { 6, "Reichert", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Jacob.Reichert23@gmail.com", new DateTime(1994, 8, 11, 12, 3, 12, 131, DateTimeKind.Local).AddTicks(429), "523766095", "Jacob", "Jacob Reichert", "(937) 248-7613", null },
                    { 7, "Reilly", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Fannie_Reilly@gmail.com", new DateTime(1989, 3, 27, 2, 20, 6, 210, DateTimeKind.Local).AddTicks(5973), "116219379", "Fannie", "Fannie Reilly", "858.371.4801", null },
                    { 8, "Greenholt", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Sabrina.Greenholt53@hotmail.com", new DateTime(1995, 9, 28, 4, 14, 18, 150, DateTimeKind.Local).AddTicks(2371), "815040618", "Sabrina", "Sabrina Greenholt", "873-316-5195 x487", null },
                    { 25, "Kassulke", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Kristi.Kassulke35@hotmail.com", new DateTime(1955, 8, 24, 11, 35, 47, 732, DateTimeKind.Local).AddTicks(7961), "702472260", "Kristi", "Kristi Kassulke", "617.821.0150 x2888", null },
                    { 10, "Mante", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Forrest.Mante@gmail.com", new DateTime(1991, 6, 21, 16, 56, 47, 891, DateTimeKind.Local).AddTicks(928), "280382912", "Forrest", "Forrest Mante", "250.266.2570", null },
                    { 11, "Davis", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Andres30@gmail.com", new DateTime(1954, 6, 21, 17, 6, 24, 767, DateTimeKind.Local).AddTicks(700), "617981563", "Andres", "Andres Davis", "263.289.2097 x3108", null },
                    { 12, "Murazik", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Carolyn69@gmail.com", new DateTime(1986, 5, 8, 4, 12, 58, 402, DateTimeKind.Local).AddTicks(5555), "154178204", "Carolyn", "Carolyn Murazik", "(390) 382-5875 x83165", null },
                    { 9, "Davis", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Ronald.Davis@gmail.com", new DateTime(1974, 5, 23, 23, 26, 33, 175, DateTimeKind.Local).AddTicks(2407), "658566243", "Ronald", "Ronald Davis", "578-496-4974", null },
                    { 14, "Price", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Greg.Price@yahoo.com", new DateTime(1981, 10, 22, 20, 7, 14, 818, DateTimeKind.Local).AddTicks(4850), "447008832", "Greg", "Greg Price", "1-360-994-1600 x26051", null },
                    { 23, "Weber", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Julius_Weber@gmail.com", new DateTime(1985, 9, 19, 10, 22, 6, 938, DateTimeKind.Local).AddTicks(7306), "234409038", "Julius", "Julius Weber", "(211) 531-7023 x4457", null },
                    { 13, "Green", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Winifred.Green87@gmail.com", new DateTime(1998, 11, 15, 13, 2, 32, 392, DateTimeKind.Local).AddTicks(2057), "846714785", "Winifred", "Winifred Green", "781.807.6012 x650", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "Schinner", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Alejandro.Schinner@yahoo.com", new DateTime(1996, 3, 5, 20, 25, 57, 132, DateTimeKind.Local).AddTicks(3338), "965546111", "Alejandro", "Alejandro Schinner", "742-843-1479 x677", null },
                    { 20, "Bruen", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Traci.Bruen@yahoo.com", new DateTime(1961, 2, 4, 14, 12, 20, 504, DateTimeKind.Local).AddTicks(3599), "391596942", "Traci", "Traci Bruen", "220-798-2271", null },
                    { 22, "Huel", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Chris_Huel@yahoo.com", new DateTime(1956, 4, 2, 18, 38, 58, 721, DateTimeKind.Local).AddTicks(5221), "666633277", "Chris", "Chris Huel", "1-354-853-9263 x7665", null },
                    { 18, "Adams", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Brian_Adams@gmail.com", new DateTime(1951, 10, 14, 20, 33, 54, 523, DateTimeKind.Local).AddTicks(6522), "454233154", "Brian", "Brian Adams", "1-345-360-7764", null },
                    { 17, "Rau", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Vincent53@gmail.com", new DateTime(1979, 4, 24, 1, 49, 48, 289, DateTimeKind.Local).AddTicks(398), "523318410", "Vincent", "Vincent Rau", "1-470-453-0708", null },
                    { 16, "Corkery", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Irving_Corkery@yahoo.com", new DateTime(1975, 8, 9, 18, 20, 21, 234, DateTimeKind.Local).AddTicks(8118), "420618467", "Irving", "Irving Corkery", "726-475-7449", null },
                    { 15, "Bailey", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Dean.Bailey@yahoo.com", new DateTime(1975, 8, 31, 22, 22, 19, 940, DateTimeKind.Local).AddTicks(8554), "457827365", "Dean", "Dean Bailey", "293.456.2891 x3742", null },
                    { 19, "Little", new DateTime(2021, 9, 30, 9, 35, 4, 226, DateTimeKind.Local).AddTicks(4861), "Juan Leon", "Cathy88@yahoo.com", new DateTime(1993, 5, 21, 16, 38, 4, 1, DateTimeKind.Local).AddTicks(8515), "627594014", "Cathy", "Cathy Little", "761-894-9646 x960", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 187, DateTimeKind.Local).AddTicks(757), "Juan Leon", "Activo", null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 187, DateTimeKind.Local).AddTicks(1325), "Juan Leon", "Inactivo", null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 187, DateTimeKind.Local).AddTicks(1330), "Juan Leon", "Devuelto", null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 187, DateTimeKind.Local).AddTicks(1332), "Juan Leon", "Prestamo", null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 187, DateTimeKind.Local).AddTicks(1334), "Juan Leon", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3052), "Juan Leon", "Nintendo", null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3054), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3053), "Juan Leon", "Rockstar", null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3051), "Juan Leon", "Activision", null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3042), "Juan Leon", "Sony", null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3047), "Juan Leon", "Ubisoft", null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3046), "Juan Leon", "EA", null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3049), "Juan Leon", "Rovio", null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(2564), "Juan Leon", "Microsoft", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4408), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4407), "Juan Leon", "Android", null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4404), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4403), "Juan Leon", "Nintendo 64", null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4401), "Juan Leon", "PlayStation 5", null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4400), "Juan Leon", "PlayStation 4", null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4399), "Juan Leon", "PlayStation 3", null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4406), "Juan Leon", "Nintendo Switch", null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4396), "Juan Leon", "PlayStation", null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4395), "Juan Leon", "PSP Vita", null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4394), "Juan Leon", "Xbox X", null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4392), "Juan Leon", "Xbox ONE", null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4391), "Juan Leon", "Xbox 360", null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4387), "Juan Leon", "Xbox", null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(3923), "Juan Leon", "PC", null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(4398), "Juan Leon", "PlayStation 2", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1547), "Juan Leon", "Link", null },
                    { 20, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1548), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1550), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1551), "Juan Leon", "Geralt de Rivia", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1553), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1554), "Juan Leon", "Ellie", null },
                    { 27, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1558), "Juan Leon", "Tracer", null },
                    { 25, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1555), "Juan Leon", "Faith", null },
                    { 26, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1556), "Juan Leon", "Bayonetta", null },
                    { 28, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1559), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1560), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1561), "Juan Leon", "Leon S. Kennedy", null },
                    { 18, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1545), "Juan Leon", "Zelda", null },
                    { 31, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1563), "Juan Leon", "Agente 47", null },
                    { 17, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1544), "Juan Leon", "Jill Valentine", null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1531), "Juan Leon", "John-117", null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1542), "Juan Leon", "Gordon Freeman", null },
                    { 32, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1564), "Juan Leon", "Haytham Kenway", null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(997), "Juan Leon", "Mario Bross", null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1520), "Juan Leon", "Tommy Vercetti", null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1525), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1527), "Juan Leon", "Natan Drake", null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1528), "Juan Leon", "Crash Bandicoot", null },
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1543), "Juan Leon", "Joel", null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1529), "Juan Leon", "Samus Aran", null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1534), "Juan Leon", "Carl Jhonson", null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1535), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1536), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1538), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1539), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1540), "Juan Leon", "Vass", null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1532), "Juan Leon", "Aiden Perce", null },
                    { 33, new DateTime(2021, 9, 30, 9, 35, 4, 188, DateTimeKind.Local).AddTicks(1566), "Juan Leon", "Lara Croft", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 4, 39, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49317.0 },
                    { 42, 37, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36334.0 },
                    { 41, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97103.0 },
                    { 40, 41, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131174.0 },
                    { 39, 31, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78283.0 },
                    { 38, 11, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105192.0 },
                    { 37, 47, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 147864.0 },
                    { 33, 5, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78372.0 },
                    { 32, 13, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34768.0 },
                    { 31, 4, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83492.0 },
                    { 29, 13, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92811.0 },
                    { 22, 4, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 136694.0 },
                    { 19, 6, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47488.0 },
                    { 17, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63232.0 },
                    { 13, 19, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 148197.0 },
                    { 11, 19, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34291.0 },
                    { 6, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119132.0 },
                    { 3, 3, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78543.0 },
                    { 2, 2, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 124747.0 },
                    { 1, 25, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35238.0 },
                    { 100, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71481.0 },
                    { 96, 16, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87209.0 },
                    { 44, 9, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 93111.0 },
                    { 46, 38, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66396.0 },
                    { 49, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88207.0 },
                    { 50, 19, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112532.0 },
                    { 99, 38, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 55562.0 },
                    { 98, 35, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88929.0 },
                    { 97, 38, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 142462.0 },
                    { 93, 25, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48000.0 },
                    { 92, 20, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46919.0 },
                    { 85, 37, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60129.0 },
                    { 83, 48, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71875.0 },
                    { 82, 27, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77981.0 },
                    { 80, 16, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75729.0 },
                    { 74, 14, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66315.0 },
                    { 95, 17, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119546.0 },
                    { 73, 24, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65138.0 },
                    { 70, 5, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48719.0 },
                    { 69, 3, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 134377.0 },
                    { 64, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58333.0 },
                    { 61, 24, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36627.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 59, 35, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 82191.0 },
                    { 58, 28, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125945.0 },
                    { 56, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48545.0 },
                    { 54, 9, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 61392.0 },
                    { 53, 49, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 107774.0 },
                    { 52, 37, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 79669.0 },
                    { 71, 49, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105662.0 },
                    { 94, 7, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 127694.0 },
                    { 16, 47, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 4, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103526.0 },
                    { 90, 6, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 86974.0 },
                    { 43, 7, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122262.0 },
                    { 36, 10, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54194.0 },
                    { 35, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 110520.0 },
                    { 34, 42, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96727.0 },
                    { 30, 5, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144891.0 },
                    { 28, 19, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 135082.0 },
                    { 27, 3, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 107505.0 },
                    { 26, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63620.0 },
                    { 91, 15, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 52575.0 },
                    { 24, 25, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 102599.0 },
                    { 45, 27, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71004.0 },
                    { 23, 6, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 123128.0 },
                    { 20, 16, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48231.0 },
                    { 18, 6, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 118422.0 },
                    { 15, 15, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77913.0 },
                    { 14, 29, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94896.0 },
                    { 12, 3, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80273.0 },
                    { 10, 25, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 121040.0 },
                    { 9, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53223.0 },
                    { 8, 11, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 111684.0 },
                    { 7, 25, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144976.0 },
                    { 5, 1, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 139210.0 },
                    { 21, 45, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 133433.0 },
                    { 47, 34, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33994.0 },
                    { 25, 4, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 117126.0 },
                    { 51, 17, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 109761.0 },
                    { 48, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54523.0 },
                    { 88, 46, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41980.0 },
                    { 87, 14, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76994.0 },
                    { 86, 17, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28822.0 },
                    { 84, 43, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 130280.0 },
                    { 81, 42, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54626.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 79, 48, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56594.0 },
                    { 78, 47, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 55016.0 },
                    { 77, 46, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39431.0 },
                    { 76, 9, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122099.0 },
                    { 89, 22, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51784.0 },
                    { 72, 10, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 108041.0 },
                    { 75, 44, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 101129.0 },
                    { 57, 45, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26619.0 },
                    { 60, 24, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100589.0 },
                    { 62, 6, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34893.0 },
                    { 63, 48, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43872.0 },
                    { 55, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69943.0 },
                    { 66, 7, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 149523.0 },
                    { 67, 47, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26900.0 },
                    { 68, 26, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76470.0 },
                    { 65, 21, new DateTime(2021, 9, 30, 9, 35, 4, 274, DateTimeKind.Local).AddTicks(7748), "Juan Leon", 3, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 62548.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6310), "Juan Leon", 7, "Gabe Newell", null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6269), "Juan Leon", 5, "Ken Levine", null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6266), "Juan Leon", 7, "Tim Schafer", null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6259), "Juan Leon", 7, "Will Wriths", null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6327), "Juan Leon", 6, "Warren Spector", null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6313), "Juan Leon", 6, "Yoko Taro", null },
                    { 22, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6339), "Juan Leon", 5, "Hironobu Sakaguchi", null },
                    { 17, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6330), "Juan Leon", 5, "Yuji Horii", null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6325), "Juan Leon", 5, "Goichi Suda", null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6264), "Juan Leon", 5, "Hidetaka Miyazaki", null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6321), "Juan Leon", 2, "Amy Hennig", null },
                    { 21, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6337), "Juan Leon", 2, "Keiji Inafune", null },
                    { 18, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6332), "Juan Leon", 2, "Yuji Naka", null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6323), "Juan Leon", 2, "Michel Ancel", null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6320), "Juan Leon", 2, "Shigeru Miyamoto", null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6312), "Juan Leon", 2, "Tom Howard", null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6272), "Juan Leon", 2, "Yves Guillemot", null },
                    { 19, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6333), "Juan Leon", 1, "Sid Meier", null },
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6329), "Juan Leon", 1, "John Romero", null },
                    { 20, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6335), "Juan Leon", 7, "John Carmack", null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(5273), "Juan Leon", 5, "Hideo Kojima", null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(6270), "Juan Leon", 8, "Fumito Ueda", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 47, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8790), "Juan Leon", 16, new DateTime(2011, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 23707.0, 5, null },
                    { 44, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8780), "Juan Leon", 10, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 17496.0, 12, null },
                    { 23, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8705), "Juan Leon", 15, new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 16342.0, 8, null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8639), "Juan Leon", 2, new DateTime(2013, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 23643.0, 3, null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8650), "Juan Leon", 2, new DateTime(2015, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 18066.0, 7, null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8669), "Juan Leon", 2, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 17064.0, 2, null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8635), "Juan Leon", 4, new DateTime(1998, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 22118.0, 10, null },
                    { 21, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8696), "Juan Leon", 4, new DateTime(2007, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 18653.0, 3, null },
                    { 36, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8759), "Juan Leon", 4, new DateTime(2008, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 23106.0, 11, null },
                    { 39, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8767), "Juan Leon", 4, new DateTime(2014, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 16605.0, 4, null },
                    { 46, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8787), "Juan Leon", 4, new DateTime(2008, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 19542.0, 6, null },
                    { 50, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8802), "Juan Leon", 4, new DateTime(2001, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 15848.0, 13, null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8632), "Juan Leon", 8, new DateTime(2012, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 19901.0, 14, null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8673), "Juan Leon", 8, new DateTime(2004, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 23815.0, 4, null },
                    { 24, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8708), "Juan Leon", 8, new DateTime(2011, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 24908.0, 6, null },
                    { 27, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8718), "Juan Leon", 8, new DateTime(2013, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 19499.0, 8, null },
                    { 30, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8731), "Juan Leon", 8, new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 20541.0, 11, null },
                    { 45, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8783), "Juan Leon", 8, new DateTime(2015, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 20306.0, 4, null },
                    { 22, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8699), "Juan Leon", 20, new DateTime(2004, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 21755.0, 8, null },
                    { 40, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8769), "Juan Leon", 20, new DateTime(2008, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 17607.0, 8, null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8655), "Juan Leon", 6, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 17076.0, 10, null },
                    { 20, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8692), "Juan Leon", 6, new DateTime(2018, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 24070.0, 13, null },
                    { 35, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8756), "Juan Leon", 10, new DateTime(2007, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 23139.0, 3, null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8629), "Juan Leon", 10, new DateTime(1998, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 23304.0, 3, null },
                    { 38, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8764), "Juan Leon", 17, new DateTime(2014, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 20106.0, 5, null },
                    { 34, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8753), "Juan Leon", 17, new DateTime(2001, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 23826.0, 3, null },
                    { 48, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8794), "Juan Leon", 16, new DateTime(1999, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 18655.0, 6, null },
                    { 49, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8798), "Juan Leon", 7, new DateTime(2015, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 20949.0, 8, null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8641), "Juan Leon", 9, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 16533.0, 6, null },
                    { 37, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8762), "Juan Leon", 11, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 15280.0, 10, null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8644), "Juan Leon", 12, new DateTime(2016, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 22211.0, 2, null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8646), "Juan Leon", 13, new DateTime(2010, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 20480.0, 6, null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8663), "Juan Leon", 13, new DateTime(2012, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 24272.0, 5, null },
                    { 42, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8775), "Juan Leon", 13, new DateTime(1999, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 17375.0, 10, null },
                    { 32, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8744), "Juan Leon", 18, new DateTime(1998, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 23515.0, 7, null },
                    { 41, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8772), "Juan Leon", 21, new DateTime(2011, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 18780.0, 10, null },
                    { 25, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8712), "Juan Leon", 6, new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 23498.0, 3, null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8140), "Juan Leon", 1, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 24984.0, 5, null },
                    { 33, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8748), "Juan Leon", 1, new DateTime(2005, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 24869.0, 9, null },
                    { 19, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8688), "Juan Leon", 3, new DateTime(2017, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 18965.0, 9, null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8621), "Juan Leon", 5, new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 18265.0, 4, null },
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8676), "Juan Leon", 5, new DateTime(2011, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 19802.0, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8679), "Juan Leon", 14, new DateTime(2014, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 18026.0, 7, null },
                    { 28, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8723), "Juan Leon", 14, new DateTime(2006, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 16765.0, 10, null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8626), "Juan Leon", 17, new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 24721.0, 13, null },
                    { 18, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8684), "Juan Leon", 17, new DateTime(2016, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 17745.0, 9, null },
                    { 26, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8714), "Juan Leon", 17, new DateTime(2003, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 24517.0, 14, null },
                    { 31, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8741), "Juan Leon", 17, new DateTime(2013, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 15767.0, 2, null },
                    { 29, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8727), "Juan Leon", 1, new DateTime(2017, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 18365.0, 4, null },
                    { 43, new DateTime(2021, 9, 30, 9, 35, 4, 276, DateTimeKind.Local).AddTicks(8778), "Juan Leon", 6, new DateTime(2009, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 24663.0, 7, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 82, 72, 68502, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 47, null, 0.0 },
                    { 93, 67, 114045, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 30, null, 0.0 },
                    { 180, 29, 82431, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 30, null, 0.0 },
                    { 204, 85, 104220, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 30, null, 0.0 },
                    { 271, 31, 29597, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 31, null, 0.0 },
                    { 167, 30, 52080, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 31, null, 0.0 },
                    { 75, 78, 69434, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 31, null, 0.0 },
                    { 56, 51, 79575, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 31, null, 0.0 },
                    { 11, 38, 34114, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 31, null, 0.0 },
                    { 44, 19, 103940, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 34, null, 0.0 },
                    { 287, 65, 138003, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 30, null, 0.0 },
                    { 238, 41, 52348, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 233, 72, 40486, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 192, 66, 64452, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 176, 48, 39991, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 155, 51, 95412, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 131, 44, 46148, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 42, 10, 35535, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 57, 28, 82839, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 267, 82, 80892, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 26, null, 0.0 },
                    { 65, 3, 118208, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 34, null, 0.0 },
                    { 70, 41, 123862, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 34, null, 0.0 },
                    { 143, 73, 75217, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 34, null, 0.0 },
                    { 154, 59, 68293, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 100, 62, 144248, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 72, 5, 105630, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 64, 86, 96343, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 102, 98, 143332, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 27, null, 0.0 },
                    { 103, 88, 46310, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 27, null, 0.0 },
                    { 206, 45, 92311, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 27, null, 0.0 },
                    { 247, 11, 39996, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 27, null, 0.0 },
                    { 166, 67, 83545, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 4, null, 0.0 },
                    { 146, 46, 52168, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 4, null, 0.0 },
                    { 293, 81, 134652, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 236, 57, 79862, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 205, 50, 92568, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 181, 68, 83838, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 151, 32, 115836, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 140, 56, 46167, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 83, 9, 30714, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 41, 41, 139292, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 38, null, 0.0 },
                    { 32, 41, 100502, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 30, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 108, 71, 125932, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 210, 42, 80421, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 281, 84, 96537, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 18, null, 0.0 },
                    { 163, 89, 127868, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 18, null, 0.0 },
                    { 52, 78, 103869, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 71, 49, 100812, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 124, 58, 63570, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 294, 14, 30908, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 16, null, 0.0 },
                    { 286, 48, 101394, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 16, null, 0.0 },
                    { 113, 76, 28203, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 16, null, 0.0 },
                    { 109, 55, 102401, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 16, null, 0.0 },
                    { 170, 33, 129111, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 15, 39, 70963, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 173, 89, 58041, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 265, 91, 121407, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 251, 45, 71078, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 187, 67, 139067, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 157, 84, 70255, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 156, 86, 139296, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 98, 31, 135375, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 51, 53, 124191, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 40, 74, 58409, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 196, 72, 63296, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 22, null, 0.0 },
                    { 90, 73, 106659, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 122, 33, 119529, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 148, 70, 135873, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 135, 15, 131348, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 18, null, 0.0 },
                    { 118, 79, 58821, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 18, null, 0.0 },
                    { 175, 17, 80357, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 179, 26, 108284, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 211, 36, 94984, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 231, 90, 109014, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 268, 47, 112913, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 45, null, 0.0 },
                    { 258, 56, 134275, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 3, null, 0.0 },
                    { 191, 12, 92587, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 3, null, 0.0 },
                    { 128, 71, 64899, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 3, null, 0.0 },
                    { 229, 68, 41255, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 28, null, 0.0 },
                    { 174, 24, 35446, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 28, null, 0.0 },
                    { 14, 75, 31462, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 79, 90, 144542, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 28, null, 0.0 },
                    { 8, 37, 66459, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 28, null, 0.0 },
                    { 284, 64, 68326, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 219, 7, 53780, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 202, 98, 28975, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 198, 76, 130045, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 17, null, 0.0 },
                    { 224, 5, 29772, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 18, null, 0.0 },
                    { 220, 4, 26687, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 35, null, 0.0 },
                    { 296, 26, 117786, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 28, 78, 87445, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 116, 9, 48177, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 60, 67, 98126, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 58, 60, 147746, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 34, 56, 135113, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 6, 72, 26719, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 272, 76, 114870, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 212, 34, 96379, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 96, 47, 62206, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 189, 85, 79882, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 89, 83, 36160, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 33, 38, 149455, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 283, 19, 105740, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 279, 66, 107705, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 266, 5, 30717, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 222, 33, 135360, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 218, 74, 73357, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 200, 92, 46740, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 149, 52, 83331, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 84, 25, 85868, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 21, null, 0.0 },
                    { 197, 19, 80977, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 237, 69, 41665, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 36, null, 0.0 },
                    { 297, 95, 143694, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 7, 11, 39530, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 101, 55, 108825, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 245, 64, 72068, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 46, null, 0.0 },
                    { 240, 71, 124083, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 46, null, 0.0 },
                    { 216, 4, 46263, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 46, null, 0.0 },
                    { 199, 94, 108390, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 46, null, 0.0 },
                    { 150, 56, 93553, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 46, null, 0.0 },
                    { 282, 87, 140209, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 254, 51, 106702, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 183, 85, 131569, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 172, 16, 48524, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 158, 80, 132740, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 88, 23, 27618, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 46, 43, 80972, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 18, 88, 63593, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 39, null, 0.0 },
                    { 133, 78, 110014, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 160, 48, 144366, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 203, 48, 139048, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 263, 95, 77059, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 99, 71, 135733, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 6, null, 0.0 },
                    { 5, 95, 31869, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 16, 90, 108646, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 142, 66, 58844, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 256, 23, 39729, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 249, 48, 95887, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 190, 50, 142052, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 91, 45, 39262, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 9, 41, 110263, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 81, 38, 131174, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 86, 74, 50768, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 106, 81, 43561, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 110, 27, 61959, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 169, 36, 146825, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 177, 63, 69311, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 280, 90, 65316, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 270, 57, 30666, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 260, 48, 131035, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 61, 23, 91680, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 59, 15, 68343, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 55, 63, 123953, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 50, 36, 35900, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 38, 85, 32388, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 44, null, 0.0 },
                    { 288, 58, 83784, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 23, null, 0.0 },
                    { 12, 48, 121603, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 27, 12, 85040, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 24, null, 0.0 },
                    { 127, 83, 141586, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 7, null, 0.0 },
                    { 153, 96, 103761, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 276, 21, 48725, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 14, null, 0.0 },
                    { 165, 44, 40811, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 14, null, 0.0 },
                    { 10, 20, 97844, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 14, null, 0.0 },
                    { 178, 74, 123876, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 257, 85, 80948, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 278, 9, 98567, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 15, null, 0.0 },
                    { 259, 19, 67696, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 239, 58, 136944, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 227, 51, 123948, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 226, 26, 111533, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 184, 72, 79511, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 132, 29, 92828, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 114, 10, 128172, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 76, 2, 86993, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 62, 14, 102086, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 11, null, 0.0 },
                    { 242, 71, 70752, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 7, null, 0.0 },
                    { 225, 24, 61524, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 7, null, 0.0 },
                    { 137, 80, 47192, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 7, null, 0.0 },
                    { 120, 52, 92439, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 7, null, 0.0 },
                    { 2, 6, 107525, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 2, null, 0.0 },
                    { 130, 79, 32228, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 28, null, 0.0 },
                    { 1, 51, 64495, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 42, null, 0.0 },
                    { 111, 99, 26372, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 97, 38, 65845, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 13, null, 0.0 },
                    { 31, 48, 129637, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 13, null, 0.0 },
                    { 230, 23, 42061, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 246, 43, 146208, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 253, 56, 101265, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 277, 98, 81575, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 21, 42, 97529, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 25, null, 0.0 },
                    { 250, 40, 122929, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 171, 11, 25984, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 152, 30, 32023, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 138, 62, 72846, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 115, 68, 116953, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 295, 44, 30719, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 292, 18, 57390, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 136, 43, 137842, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 223, 70, 98028, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 10, null, 0.0 },
                    { 48, 35, 41538, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 95, 21, 116730, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 42, null, 0.0 },
                    { 252, 27, 32620, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 42, null, 0.0 },
                    { 164, 60, 95173, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 20, 38, 58726, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 74, 51, 114794, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 92, 92, 35088, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 125, 55, 109600, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 129, 88, 148064, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 285, 84, 120983, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 241, 94, 65141, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 42, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 215, 26, 85528, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 78, 65, 95746, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 77, 96, 78202, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 49, 9, 81730, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 162, 51, 123787, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 217, 79, 142218, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 248, 80, 133739, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 20, null, 0.0 },
                    { 291, 45, 148914, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 42, null, 0.0 },
                    { 208, 49, 93314, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 32, null, 0.0 },
                    { 36, 75, 97101, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 13, 12, 94350, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 9, null, 0.0 },
                    { 275, 98, 111546, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 87, 47, 34776, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 45, 60, 77860, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 24, 76, 72402, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 139, 19, 25780, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 232, 35, 89267, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 269, 58, 33495, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 299, 75, 53053, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 123, 3, 98077, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 273, 70, 86413, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 147, 58, 31885, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 104, 73, 107869, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 63, 15, 119690, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 298, 5, 107910, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 47, null, 0.0 },
                    { 289, 39, 134281, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 47, null, 0.0 },
                    { 214, 20, 90838, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 47, null, 0.0 },
                    { 107, 83, 38685, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 47, null, 0.0 },
                    { 168, 45, 27909, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 48, null, 0.0 },
                    { 159, 86, 148270, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 188, 98, 66720, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 213, 11, 49456, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 209, 10, 137936, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 145, 31, 105286, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 94, 77, 50283, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 66, 80, 83612, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 54, 17, 146836, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 39, 38, 123410, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 22, 25, 134921, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 37, null, 0.0 },
                    { 264, 65, 120875, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 },
                    { 262, 37, 97356, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 },
                    { 261, 10, 118363, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 195, 88, 144192, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 },
                    { 193, 80, 74577, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 },
                    { 80, 29, 90172, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 8, null, 0.0 },
                    { 25, 1, 146144, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 67, 38, 122148, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 105, 42, 85088, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 43, null, 0.0 },
                    { 290, 45, 67613, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 49, null, 0.0 },
                    { 185, 57, 66393, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 194, 44, 31414, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 23, 30, 49685, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 5, null, 0.0 },
                    { 117, 80, 96371, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 29, 37, 96769, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 3, 18, 70147, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 },
                    { 19, 81, 148204, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 },
                    { 30, 92, 38920, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 4, 35, 64487, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 73, 48, 90183, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 121, 86, 73836, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 144, 90, 124201, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 33, null, 0.0 },
                    { 26, 42, 83743, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 },
                    { 161, 19, 51976, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 207, 41, 123983, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 141, 74, 37082, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 33, null, 0.0 },
                    { 69, 98, 145229, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 33, null, 0.0 },
                    { 43, 92, 81718, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 33, null, 0.0 },
                    { 201, 71, 25088, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 234, 73, 86543, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 1, null, 0.0 },
                    { 134, 68, 25293, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 228, 75, 51627, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 274, 63, 79697, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 40, null, 0.0 },
                    { 53, 12, 90726, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 },
                    { 244, 42, 149461, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 29, null, 0.0 },
                    { 300, 24, 66351, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 29, null, 0.0 },
                    { 35, 21, 36233, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 29, null, 0.0 },
                    { 243, 38, 78784, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 112, 21, 137094, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 29, null, 0.0 },
                    { 126, 47, 90723, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 221, 30, 94478, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 41, null, 0.0 },
                    { 119, 48, 56614, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 68, 49, 109237, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 186, 43, 39124, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 255, 81, 102263, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 47, 31, 102569, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 235, 9, 82342, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 85, 42, 64729, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 },
                    { 37, 8, 32834, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 17, 17, 113018, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 19, null, 0.0 },
                    { 182, 26, 30712, new DateTime(2021, 9, 30, 9, 35, 4, 286, DateTimeKind.Local).AddTicks(7674), "Juan Leon", 12, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 22, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 14, 9, null },
                    { 83, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 15, 12, null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 14, 14, null },
                    { 38, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 7, 10, null },
                    { 28, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 14, 5, null },
                    { 33, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 17, 2, null },
                    { 43, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 15, 13, null },
                    { 72, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 17, 15, null },
                    { 52, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 17, 9, null },
                    { 51, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 9, 14, null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 37, 13, null },
                    { 26, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 37, 1, null },
                    { 35, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 15, 11, null },
                    { 82, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 11, 2, null },
                    { 64, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 11, 2, null },
                    { 27, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 11, 4, null },
                    { 69, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 14, 1, null },
                    { 76, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 17, 1, null },
                    { 41, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 9, 10, null },
                    { 92, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 9, 7, null },
                    { 62, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 26, 4, null },
                    { 88, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 49, 6, null },
                    { 42, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 29, 13, null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 19, 8, null },
                    { 75, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 46, 12, null },
                    { 77, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 47, 11, null },
                    { 85, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 47, 7, null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 39, 1, null },
                    { 57, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 48, 8, null },
                    { 94, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 43, 1, null },
                    { 74, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 43, 13, null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 2, 3, null },
                    { 89, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 2, 9, null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 22, 14, null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 5, 11, null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 5, 11, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 58, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 33, 13, null },
                    { 47, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 16, 9, null },
                    { 24, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 5, 10, null },
                    { 29, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 5, 13, null },
                    { 53, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 5, 4, null },
                    { 18, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 21, 10, null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 49, 1, null },
                    { 54, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 16, 6, null },
                    { 91, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 6, 6, null },
                    { 63, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 6, 15, null },
                    { 32, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 6, 5, null },
                    { 86, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 29, 13, null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 17, 9, null },
                    { 84, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 25, 1, null },
                    { 20, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 22, 2, null },
                    { 23, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 1, 15, null },
                    { 21, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 30, 6, null },
                    { 68, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 27, 4, null },
                    { 90, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 34, 12, null },
                    { 87, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 24, 15, null },
                    { 100, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 34, 12, null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 32, 4, null },
                    { 66, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 18, 13, null },
                    { 67, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 35, 15, null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 18, 6, null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 18, 3, null },
                    { 34, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 38, 3, null },
                    { 37, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 35, 13, null },
                    { 19, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 35, 8, null },
                    { 39, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 38, 14, null },
                    { 60, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 1, 8, null },
                    { 99, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 23, 4, null },
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 42, 5, null },
                    { 70, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 38, 2, null },
                    { 59, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 42, 4, null },
                    { 96, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 42, 3, null },
                    { 98, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 4, 5, null },
                    { 55, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 4, 10, null },
                    { 44, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 4, 7, null },
                    { 61, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 1, 6, null },
                    { 81, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 1, 3, null },
                    { 45, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 32, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 79, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 20, 2, null },
                    { 17, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 30, 14, null },
                    { 36, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 41, 8, null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 12, 13, null },
                    { 73, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 26, 6, null },
                    { 71, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 26, 11, null },
                    { 49, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 13, 15, null },
                    { 46, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 28, 13, null },
                    { 56, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 28, 3, null },
                    { 97, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 28, 10, null },
                    { 31, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 23, 7, null },
                    { 30, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 10, 13, null },
                    { 48, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 31, 3, null },
                    { 65, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 10, 15, null },
                    { 78, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 45, 13, null },
                    { 93, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 31, 6, null },
                    { 95, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 3, 11, null },
                    { 40, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 44, 11, null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 44, 11, null },
                    { 25, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 13, 14, null },
                    { 50, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 10, 14, null },
                    { 80, new DateTime(2021, 9, 30, 9, 35, 4, 279, DateTimeKind.Local).AddTicks(8126), "Juan Leon", 23, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 124, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 27, 27, null },
                    { 100, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 22, 30, null },
                    { 87, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 27, 8, null },
                    { 62, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 27, 14, null },
                    { 151, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 27, 13, null },
                    { 159, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 22, 27, null },
                    { 20, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 12, 4, null },
                    { 15, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 43, 22, null },
                    { 181, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 22, 22, null },
                    { 31, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 12, 23, null },
                    { 113, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 30, 14, null },
                    { 11, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 43, 16, null },
                    { 101, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 12, 9, null },
                    { 190, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 27, 13, null },
                    { 122, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 12, 30, null },
                    { 136, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 40, 16, null },
                    { 54, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 5, 11, null },
                    { 155, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 20, null },
                    { 171, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 23, null },
                    { 184, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 40, 17, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 30, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 45, 25, null },
                    { 28, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 45, 13, null },
                    { 147, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 14, null },
                    { 110, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 13, null },
                    { 26, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 15, 22, null },
                    { 89, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 15, null },
                    { 65, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 31, null },
                    { 59, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 23, null },
                    { 88, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 15, 1, null },
                    { 130, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 15, 10, null },
                    { 194, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 15, 7, null },
                    { 150, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 40, 7, null },
                    { 38, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 5, 32, null },
                    { 107, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 1, null },
                    { 69, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 24, 10, null },
                    { 95, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 5, 18, null },
                    { 131, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 5, 9, null },
                    { 57, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 11, null },
                    { 63, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 13, null },
                    { 197, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 5, 12, null },
                    { 178, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 45, 11, null },
                    { 74, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 20, 15, null },
                    { 96, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 45, 30, null },
                    { 180, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 1, null },
                    { 50, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 40, 1, null },
                    { 135, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 40, 6, null },
                    { 144, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 24, 32, null },
                    { 104, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 24, 13, null },
                    { 80, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 24, 28, null },
                    { 7, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 22, 24, null },
                    { 10, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 25, 30, null },
                    { 165, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 5, null },
                    { 163, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 1, null },
                    { 152, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 8, null },
                    { 117, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 8, null },
                    { 34, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 18, null },
                    { 8, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 21, null },
                    { 196, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 41, 28, null },
                    { 142, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 41, 12, null },
                    { 153, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 13, null },
                    { 82, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 41, 23, null },
                    { 191, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 28, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 149, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 10, null },
                    { 138, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 8, null },
                    { 83, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 11, null },
                    { 79, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 18, null },
                    { 77, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 12, null },
                    { 61, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 41, 30, null },
                    { 182, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 1, 9, null },
                    { 13, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 29, 14, null },
                    { 64, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 29, 4, null },
                    { 195, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 2, 1, null },
                    { 183, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 2, 22, null },
                    { 112, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 2, 5, null },
                    { 9, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 2, 26, null },
                    { 170, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 19, 28, null },
                    { 81, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 19, 32, null },
                    { 43, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 19, 8, null },
                    { 179, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 33, 21, null },
                    { 137, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 33, 18, null },
                    { 67, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 33, 9, null },
                    { 55, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 33, 30, null },
                    { 33, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 33, 31, null },
                    { 172, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 29, 26, null },
                    { 166, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 29, 30, null },
                    { 156, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 29, 5, null },
                    { 76, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 1, null },
                    { 22, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 16, 16, null },
                    { 60, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 15, null },
                    { 173, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 11, null },
                    { 39, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 16, null },
                    { 36, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 11, null },
                    { 102, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 37, 29, null },
                    { 140, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 8, 29, null },
                    { 123, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 49, 23, null },
                    { 91, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 49, 5, null },
                    { 70, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 14, null },
                    { 45, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 49, 15, null },
                    { 164, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 9, null },
                    { 99, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 23, null },
                    { 52, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 29, null },
                    { 51, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 6, null },
                    { 12, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 8, null },
                    { 23, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 47, 32, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 175, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 48, 7, null },
                    { 90, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 15, null },
                    { 134, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 5, null },
                    { 188, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 9, 20, null },
                    { 128, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 26, null },
                    { 97, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 10, null },
                    { 21, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 28, null },
                    { 18, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 8, null },
                    { 17, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 42, 29, null },
                    { 143, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 15, null },
                    { 129, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 20, null },
                    { 94, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 10, null },
                    { 73, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 31, null },
                    { 53, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 31, null },
                    { 14, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 13, 27, null },
                    { 115, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 10, 5, null },
                    { 78, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 10, 2, null },
                    { 42, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 10, 14, null },
                    { 3, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 10, 17, null },
                    { 25, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 32, 14, null },
                    { 93, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 16, 8, null },
                    { 127, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 16, 2, null },
                    { 161, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 16, 7, null },
                    { 132, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 11, 30, null },
                    { 118, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 11, 23, null },
                    { 56, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 11, 13, null },
                    { 71, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 7, 26, null },
                    { 44, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 7, 3, null },
                    { 32, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 7, 1, null },
                    { 139, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 11, 4, null },
                    { 187, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 23, 27, null },
                    { 146, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 23, 27, null },
                    { 19, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 23, 22, null },
                    { 141, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 18, null },
                    { 126, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 20, null },
                    { 108, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 8, null },
                    { 29, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 22, null },
                    { 157, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 23, 13, null },
                    { 40, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 14, 20, null },
                    { 66, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 14, 29, null },
                    { 109, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 14, 13, null },
                    { 162, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 120, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 28, null },
                    { 103, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 15, null },
                    { 84, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 4, null },
                    { 49, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 10, null },
                    { 41, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 36, 14, null },
                    { 198, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 27, null },
                    { 158, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 18, null },
                    { 145, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 14, null },
                    { 125, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 27, null },
                    { 119, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 26, null },
                    { 75, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 3, null },
                    { 72, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 21, 3, null },
                    { 133, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 6, 26, null },
                    { 192, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 14, 18, null },
                    { 16, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 27, null },
                    { 2, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 17, null },
                    { 1, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 44, 28, null },
                    { 199, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 11, null },
                    { 169, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 26, 19, null },
                    { 4, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 26, 1, null },
                    { 174, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 18, 4, null },
                    { 168, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 18, 16, null },
                    { 114, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 18, 8, null },
                    { 46, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 18, 26, null },
                    { 186, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 3, 27, null },
                    { 185, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 3, 31, null },
                    { 116, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 3, 26, null },
                    { 98, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 3, 6, null },
                    { 58, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 3, 26, null },
                    { 106, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 28, 6, null },
                    { 37, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 28, 13, null },
                    { 86, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 17, 7, null },
                    { 167, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 16, 30, null },
                    { 68, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 31, 18, null },
                    { 154, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 46, 25, null },
                    { 177, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 31, 4, null },
                    { 160, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 34, 22, null },
                    { 92, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 15, null },
                    { 85, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 17, null },
                    { 27, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 25, null },
                    { 24, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 27, null },
                    { 5, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 35, 18, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 193, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 4, 25, null },
                    { 176, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 4, 27, null },
                    { 111, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 4, 14, null },
                    { 105, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 4, 6, null },
                    { 200, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 6, null },
                    { 35, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 43, 25, null },
                    { 148, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 17, null },
                    { 121, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 28, null },
                    { 47, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 15, null },
                    { 6, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 38, 28, null },
                    { 189, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 31, 30, null },
                    { 48, new DateTime(2021, 9, 30, 9, 35, 4, 282, DateTimeKind.Local).AddTicks(9702), "Juan Leon", 43, 5, null }
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
