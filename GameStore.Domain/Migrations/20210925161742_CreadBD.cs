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
                    { 1, "Zboncak", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Doug_Zboncak@hotmail.com", new DateTime(1983, 11, 11, 8, 11, 40, 216, DateTimeKind.Local).AddTicks(2575), "968259769", "Doug", "Doug Zboncak", "675-802-0905 x0636", null },
                    { 28, "Steuber", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Vickie.Steuber@yahoo.com", new DateTime(2001, 3, 7, 4, 36, 8, 92, DateTimeKind.Local).AddTicks(9324), "257526552", "Vickie", "Vickie Steuber", "219.991.7018 x39892", null },
                    { 29, "Erdman", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Darlene12@gmail.com", new DateTime(1972, 7, 24, 13, 24, 48, 721, DateTimeKind.Local).AddTicks(9868), "767258696", "Darlene", "Darlene Erdman", "(561) 415-7050 x595", null },
                    { 31, "Wyman", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Edgar_Wyman@yahoo.com", new DateTime(1962, 12, 9, 5, 54, 24, 677, DateTimeKind.Local).AddTicks(2063), "365314514", "Edgar", "Edgar Wyman", "1-817-445-5033 x64412", null },
                    { 32, "Franecki", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Toni.Franecki52@gmail.com", new DateTime(1998, 1, 15, 3, 34, 10, 315, DateTimeKind.Local).AddTicks(8052), "963537094", "Toni", "Toni Franecki", "451-212-7745 x4591", null },
                    { 33, "Breitenberg", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Jackie_Breitenberg22@gmail.com", new DateTime(1996, 2, 26, 6, 5, 58, 784, DateTimeKind.Local).AddTicks(6145), "536943636", "Jackie", "Jackie Breitenberg", "644.423.0672 x747", null },
                    { 34, "Kessler", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Pam_Kessler@hotmail.com", new DateTime(1954, 10, 6, 8, 45, 12, 983, DateTimeKind.Local).AddTicks(6544), "808795836", "Pam", "Pam Kessler", "985-664-8518 x70247", null },
                    { 35, "Crooks", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Becky_Crooks@gmail.com", new DateTime(2000, 12, 5, 10, 4, 4, 736, DateTimeKind.Local).AddTicks(1822), "182325186", "Becky", "Becky Crooks", "(882) 287-7580 x74526", null },
                    { 36, "Kiehn", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Kim58@gmail.com", new DateTime(1990, 6, 22, 17, 58, 11, 460, DateTimeKind.Local).AddTicks(6776), "262196314", "Kim", "Kim Kiehn", "1-652-475-8988 x720", null },
                    { 37, "Robel", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Sylvester99@gmail.com", new DateTime(1988, 5, 12, 4, 24, 15, 558, DateTimeKind.Local).AddTicks(556), "730266080", "Sylvester", "Sylvester Robel", "(334) 986-6441", null },
                    { 38, "Halvorson", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Monica.Halvorson@hotmail.com", new DateTime(1983, 7, 15, 0, 0, 50, 787, DateTimeKind.Local).AddTicks(2535), "690142817", "Monica", "Monica Halvorson", "708.542.2897", null },
                    { 27, "Russel", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Alma39@gmail.com", new DateTime(1964, 2, 3, 10, 28, 51, 990, DateTimeKind.Local).AddTicks(2148), "489589496", "Alma", "Alma Russel", "975-262-2745", null },
                    { 39, "Little", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Bobby.Little34@hotmail.com", new DateTime(1975, 5, 25, 5, 42, 59, 5, DateTimeKind.Local).AddTicks(4694), "515598160", "Bobby", "Bobby Little", "947-873-0069 x937", null },
                    { 41, "Rutherford", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Nadine73@yahoo.com", new DateTime(1993, 11, 7, 21, 35, 56, 965, DateTimeKind.Local).AddTicks(5019), "451711891", "Nadine", "Nadine Rutherford", "954.271.2523 x48445", null },
                    { 42, "Wintheiser", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Pat_Wintheiser@yahoo.com", new DateTime(1994, 11, 18, 12, 4, 56, 651, DateTimeKind.Local).AddTicks(1341), "873844488", "Pat", "Pat Wintheiser", "(282) 790-4715 x9094", null },
                    { 43, "Zieme", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Joanna.Zieme@yahoo.com", new DateTime(1968, 7, 24, 3, 16, 19, 304, DateTimeKind.Local).AddTicks(5430), "161079516", "Joanna", "Joanna Zieme", "(395) 593-2980 x52325", null },
                    { 44, "Goodwin", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Darryl_Goodwin57@gmail.com", new DateTime(1998, 6, 23, 19, 34, 2, 441, DateTimeKind.Local).AddTicks(5841), "474274527", "Darryl", "Darryl Goodwin", "814.845.7265", null },
                    { 45, "Braun", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Josefina_Braun53@gmail.com", new DateTime(1952, 8, 1, 19, 44, 23, 65, DateTimeKind.Local).AddTicks(9811), "118293247", "Josefina", "Josefina Braun", "516.877.7279 x46829", null },
                    { 46, "Nitzsche", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Bennie_Nitzsche5@gmail.com", new DateTime(1972, 11, 8, 12, 31, 53, 243, DateTimeKind.Local).AddTicks(4156), "584625974", "Bennie", "Bennie Nitzsche", "(647) 478-2760", null },
                    { 47, "Larson", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Virgil.Larson29@yahoo.com", new DateTime(1967, 3, 30, 18, 39, 39, 991, DateTimeKind.Local).AddTicks(6551), "767566676", "Virgil", "Virgil Larson", "660.816.8229", null },
                    { 48, "Schamberger", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Kent_Schamberger@gmail.com", new DateTime(1957, 2, 5, 18, 57, 25, 426, DateTimeKind.Local).AddTicks(5969), "427000163", "Kent", "Kent Schamberger", "(285) 210-2742 x46544", null },
                    { 49, "Johnston", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Wanda_Johnston79@yahoo.com", new DateTime(1974, 7, 25, 22, 19, 15, 573, DateTimeKind.Local).AddTicks(2785), "864859254", "Wanda", "Wanda Johnston", "781-583-4327 x589", null },
                    { 50, "Runolfsson", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Amanda_Runolfsson@yahoo.com", new DateTime(1984, 12, 18, 0, 27, 12, 71, DateTimeKind.Local).AddTicks(2183), "439453191", "Amanda", "Amanda Runolfsson", "(645) 439-8413 x20752", null },
                    { 40, "Bergstrom", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "William85@gmail.com", new DateTime(1957, 2, 16, 21, 51, 32, 244, DateTimeKind.Local).AddTicks(8740), "302383772", "William", "William Bergstrom", "1-743-866-4845 x9367", null },
                    { 26, "Homenick", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Geneva88@yahoo.com", new DateTime(2000, 6, 21, 17, 58, 19, 943, DateTimeKind.Local).AddTicks(5187), "379149685", "Geneva", "Geneva Homenick", "(609) 824-0739 x562", null },
                    { 30, "Rolfson", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Roland_Rolfson@hotmail.com", new DateTime(1961, 10, 11, 11, 40, 32, 762, DateTimeKind.Local).AddTicks(2746), "824166611", "Roland", "Roland Rolfson", "1-402-334-3662 x4226", null },
                    { 24, "Kuphal", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Cary.Kuphal60@yahoo.com", new DateTime(1958, 6, 29, 11, 22, 16, 344, DateTimeKind.Local).AddTicks(7805), "347179090", "Cary", "Cary Kuphal", "734.304.4728", null },
                    { 2, "Satterfield", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Paulette23@hotmail.com", new DateTime(1977, 8, 9, 6, 3, 39, 855, DateTimeKind.Local).AddTicks(5128), "487900140", "Paulette", "Paulette Satterfield", "(270) 429-7551 x1622", null },
                    { 3, "O'Keefe", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Pearl.OKeefe60@gmail.com", new DateTime(2000, 3, 1, 2, 1, 45, 400, DateTimeKind.Local).AddTicks(9927), "438414591", "Pearl", "Pearl O'Keefe", "1-658-399-7484", null },
                    { 4, "Bednar", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Boyd.Bednar@gmail.com", new DateTime(1963, 7, 8, 6, 21, 15, 567, DateTimeKind.Local).AddTicks(8303), "658063792", "Boyd", "Boyd Bednar", "(820) 794-2292 x0522", null },
                    { 5, "Lakin", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Sonja22@yahoo.com", new DateTime(1953, 10, 5, 4, 11, 9, 394, DateTimeKind.Local).AddTicks(7287), "743246497", "Sonja", "Sonja Lakin", "895-800-9243 x046", null },
                    { 6, "Yost", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Don.Yost4@gmail.com", new DateTime(1985, 7, 26, 22, 37, 14, 930, DateTimeKind.Local).AddTicks(7653), "250017282", "Don", "Don Yost", "511.722.1859 x15374", null },
                    { 7, "Schiller", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Roderick.Schiller32@yahoo.com", new DateTime(1966, 7, 20, 2, 36, 10, 511, DateTimeKind.Local).AddTicks(540), "573990676", "Roderick", "Roderick Schiller", "(301) 526-7559", null },
                    { 8, "Brakus", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Percy_Brakus@hotmail.com", new DateTime(1965, 3, 25, 1, 32, 46, 480, DateTimeKind.Local).AddTicks(7994), "304445890", "Percy", "Percy Brakus", "310.898.9568 x90995", null },
                    { 25, "Block", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Archie_Block@gmail.com", new DateTime(1977, 8, 11, 14, 52, 46, 553, DateTimeKind.Local).AddTicks(4851), "844640334", "Archie", "Archie Block", "860.318.1414 x19718", null },
                    { 10, "Ward", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Franklin10@hotmail.com", new DateTime(1991, 9, 8, 11, 37, 18, 842, DateTimeKind.Local).AddTicks(7219), "275127500", "Franklin", "Franklin Ward", "(751) 283-1775", null },
                    { 11, "Pacocha", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Peter79@yahoo.com", new DateTime(1955, 7, 12, 2, 33, 49, 487, DateTimeKind.Local).AddTicks(6122), "684354931", "Peter", "Peter Pacocha", "417-623-2803", null },
                    { 12, "Gorczany", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Cornelius.Gorczany@yahoo.com", new DateTime(1957, 3, 5, 7, 30, 58, 86, DateTimeKind.Local).AddTicks(8385), "214258414", "Cornelius", "Cornelius Gorczany", "(546) 615-4574 x5832", null },
                    { 9, "Gutkowski", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Ignacio32@yahoo.com", new DateTime(1993, 10, 13, 19, 56, 25, 727, DateTimeKind.Local).AddTicks(4926), "554757221", "Ignacio", "Ignacio Gutkowski", "(291) 921-2641", null },
                    { 14, "Collins", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Conrad_Collins@hotmail.com", new DateTime(1962, 3, 6, 22, 56, 14, 731, DateTimeKind.Local).AddTicks(5522), "284842465", "Conrad", "Conrad Collins", "430.422.0764", null },
                    { 23, "Kuhic", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Pedro_Kuhic42@hotmail.com", new DateTime(1985, 8, 2, 19, 56, 25, 69, DateTimeKind.Local).AddTicks(8795), "604274603", "Pedro", "Pedro Kuhic", "657.609.1817 x01723", null },
                    { 13, "Ledner", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Al10@hotmail.com", new DateTime(1992, 7, 3, 16, 39, 25, 531, DateTimeKind.Local).AddTicks(167), "936828577", "Al", "Al Ledner", "282.282.5130 x42770", null }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "CreatedAt", "CreatedBy", "Email", "Nacimiento", "Nit", "Nombre", "NombreCompleto", "Telefono", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, "Douglas", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Anne49@gmail.com", new DateTime(1976, 11, 7, 17, 20, 2, 767, DateTimeKind.Local).AddTicks(1941), "244292689", "Anne", "Anne Douglas", "391-871-5733 x55301", null },
                    { 20, "Dickinson", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Renee_Dickinson@gmail.com", new DateTime(1983, 5, 13, 8, 24, 11, 856, DateTimeKind.Local).AddTicks(5118), "427816975", "Renee", "Renee Dickinson", "1-675-436-7459", null },
                    { 22, "Rice", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Diane69@hotmail.com", new DateTime(1975, 9, 18, 12, 6, 16, 903, DateTimeKind.Local).AddTicks(6157), "867184266", "Diane", "Diane Rice", "(437) 976-9351", null },
                    { 18, "Schultz", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Stacey.Schultz@hotmail.com", new DateTime(1977, 7, 29, 6, 14, 32, 591, DateTimeKind.Local).AddTicks(6810), "392689837", "Stacey", "Stacey Schultz", "988-219-7346 x3314", null },
                    { 17, "Reichert", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Lindsey_Reichert65@yahoo.com", new DateTime(1952, 4, 6, 23, 56, 28, 796, DateTimeKind.Local).AddTicks(3728), "915187124", "Lindsey", "Lindsey Reichert", "715.487.2875 x80752", null },
                    { 16, "Abernathy", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Delia.Abernathy10@gmail.com", new DateTime(1977, 4, 23, 14, 31, 5, 567, DateTimeKind.Local).AddTicks(9181), "641542537", "Delia", "Delia Abernathy", "743-608-4210", null },
                    { 15, "Bailey", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Seth_Bailey@gmail.com", new DateTime(1998, 6, 11, 12, 7, 12, 543, DateTimeKind.Local).AddTicks(3206), "982868825", "Seth", "Seth Bailey", "496.851.8948 x95730", null },
                    { 19, "Kub", new DateTime(2021, 9, 25, 11, 17, 41, 813, DateTimeKind.Local).AddTicks(8625), "Juan Leon", "Bernadette_Kub@yahoo.com", new DateTime(1988, 4, 21, 23, 22, 39, 105, DateTimeKind.Local).AddTicks(1206), "994974958", "Bernadette", "Bernadette Kub", "1-905-742-3805", null }
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 777, DateTimeKind.Local).AddTicks(1486), "Juan Leon", "Activo", null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 777, DateTimeKind.Local).AddTicks(2009), "Juan Leon", "Inactivo", null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 777, DateTimeKind.Local).AddTicks(2014), "Juan Leon", "Devuelto", null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 777, DateTimeKind.Local).AddTicks(2015), "Juan Leon", "Prestamo", null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 777, DateTimeKind.Local).AddTicks(2017), "Juan Leon", "Error", null }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6111), "Juan Leon", "Nintendo", null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6113), "Juan Leon", "CD Project Red", null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6112), "Juan Leon", "Rockstar", null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6110), "Juan Leon", "Activision", null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6101), "Juan Leon", "Sony", null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6107), "Juan Leon", "Ubisoft", null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6106), "Juan Leon", "EA", null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(6108), "Juan Leon", "Rovio", null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(5541), "Juan Leon", "Microsoft", null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7668), "Juan Leon", "IOS", null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7667), "Juan Leon", "Android", null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7664), "Juan Leon", "Nintendo DS", null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7663), "Juan Leon", "Nintendo 64", null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7662), "Juan Leon", "PlayStation 5", null },
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7660), "Juan Leon", "PlayStation 4", null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7659), "Juan Leon", "PlayStation 3", null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7665), "Juan Leon", "Nintendo Switch", null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7656), "Juan Leon", "PlayStation", null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7655), "Juan Leon", "PSP Vita", null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7654), "Juan Leon", "Xbox X", null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7653), "Juan Leon", "Xbox ONE", null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7651), "Juan Leon", "Xbox 360", null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7647), "Juan Leon", "Xbox", null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7103), "Juan Leon", "PC", null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(7658), "Juan Leon", "PlayStation 2", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4486), "Juan Leon", "Link", null },
                    { 20, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4487), "Juan Leon", "Glados", null },
                    { 21, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4488), "Juan Leon", "Meet Boy", null },
                    { 22, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4489), "Juan Leon", "Geralt de Rivia", null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista",
                columns: new[] { "ProtagonistaId", "CreatedAt", "CreatedBy", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 23, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4491), "Juan Leon", "Steve", null },
                    { 24, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4492), "Juan Leon", "Ellie", null },
                    { 27, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4496), "Juan Leon", "Tracer", null },
                    { 25, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4493), "Juan Leon", "Faith", null },
                    { 26, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4494), "Juan Leon", "Bayonetta", null },
                    { 28, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4497), "Juan Leon", "Pacman", null },
                    { 29, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4498), "Juan Leon", "Chris Redfield", null },
                    { 30, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4499), "Juan Leon", "Leon S. Kennedy", null },
                    { 18, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4484), "Juan Leon", "Zelda", null },
                    { 31, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4501), "Juan Leon", "Agente 47", null },
                    { 17, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4483), "Juan Leon", "Jill Valentine", null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4471), "Juan Leon", "John-117", null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4481), "Juan Leon", "Gordon Freeman", null },
                    { 32, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4502), "Juan Leon", "Haytham Kenway", null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(3875), "Juan Leon", "Mario Bross", null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4460), "Juan Leon", "Tommy Vercetti", null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4465), "Juan Leon", "Altaïr Ibn-La'Ahad", null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4467), "Juan Leon", "Natan Drake", null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4468), "Juan Leon", "Crash Bandicoot", null },
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4482), "Juan Leon", "Joel", null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4469), "Juan Leon", "Samus Aran", null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4473), "Juan Leon", "Carl Jhonson", null },
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4474), "Juan Leon", "Red", null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4476), "Juan Leon", "Crazy Dave", null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4477), "Juan Leon", "Spyro", null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4478), "Juan Leon", "Marcus Fenix", null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4479), "Juan Leon", "Vass", null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4472), "Juan Leon", "Aiden Perce", null },
                    { 33, new DateTime(2021, 9, 25, 11, 17, 41, 778, DateTimeKind.Local).AddTicks(4503), "Juan Leon", "Lara Croft", null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 2, 15, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 120335.0 },
                    { 47, 16, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119106.0 },
                    { 46, 47, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 55079.0 },
                    { 42, 3, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 70755.0 },
                    { 40, 6, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 148259.0 },
                    { 37, 11, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105604.0 },
                    { 35, 25, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67662.0 },
                    { 34, 39, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64959.0 },
                    { 32, 17, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37827.0 },
                    { 30, 49, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98076.0 },
                    { 28, 2, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80520.0 },
                    { 26, 30, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48773.0 },
                    { 23, 44, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47249.0 },
                    { 20, 33, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35419.0 },
                    { 15, 20, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80343.0 },
                    { 13, 41, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 106834.0 },
                    { 11, 18, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53645.0 },
                    { 10, 20, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 126871.0 },
                    { 8, 43, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32751.0 },
                    { 7, 48, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26823.0 },
                    { 6, 19, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96881.0 },
                    { 4, 24, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99379.0 },
                    { 49, 22, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 133156.0 },
                    { 52, 4, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 110178.0 },
                    { 53, 29, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67875.0 },
                    { 55, 35, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 124960.0 },
                    { 100, 9, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98344.0 },
                    { 99, 37, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36447.0 },
                    { 97, 48, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69051.0 },
                    { 96, 10, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 117052.0 },
                    { 95, 45, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31470.0 },
                    { 94, 24, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28860.0 },
                    { 92, 5, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 86290.0 },
                    { 91, 22, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 137261.0 },
                    { 90, 47, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38851.0 },
                    { 89, 5, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 90000.0 },
                    { 1, 35, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27903.0 },
                    { 88, 30, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105890.0 },
                    { 86, 12, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 114114.0 },
                    { 79, 9, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 135734.0 },
                    { 76, 16, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51431.0 },
                    { 75, 26, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122064.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 74, 18, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47580.0 },
                    { 71, 43, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 140111.0 },
                    { 66, 1, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40817.0 },
                    { 59, 41, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112236.0 },
                    { 57, 20, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98086.0 },
                    { 56, 28, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53811.0 },
                    { 87, 38, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119953.0 },
                    { 98, 18, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33928.0 },
                    { 19, 24, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 4, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45838.0 },
                    { 85, 25, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104285.0 },
                    { 44, 41, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 89027.0 },
                    { 43, 2, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29590.0 },
                    { 41, 7, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63356.0 },
                    { 39, 34, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131337.0 },
                    { 38, 33, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78103.0 },
                    { 36, 42, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85346.0 },
                    { 33, 43, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131457.0 },
                    { 31, 16, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 74292.0 },
                    { 93, 41, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115868.0 },
                    { 27, 9, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105094.0 },
                    { 45, 10, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 114162.0 },
                    { 25, 32, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 137144.0 },
                    { 22, 7, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 124093.0 },
                    { 21, 19, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97187.0 },
                    { 18, 30, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39687.0 },
                    { 17, 16, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38083.0 },
                    { 16, 5, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95714.0 },
                    { 14, 48, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 147074.0 },
                    { 12, 41, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 106548.0 },
                    { 9, 33, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 93739.0 },
                    { 5, 39, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26250.0 },
                    { 3, 25, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119209.0 },
                    { 24, 19, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99895.0 },
                    { 48, 30, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44855.0 },
                    { 29, 39, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31047.0 },
                    { 51, 25, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 143791.0 },
                    { 50, 6, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112736.0 },
                    { 83, 30, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97364.0 },
                    { 82, 29, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85239.0 },
                    { 81, 14, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 79668.0 },
                    { 80, 35, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 107064.0 },
                    { 78, 3, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 108222.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler",
                columns: new[] { "AlquilerId", "ClienteId", "CreatedAt", "CreatedBy", "EstadoId", "Fecha_Devolucion", "Fecha_Reservacion", "UpdatedAt", "Valor_Total" },
                values: new object[,]
                {
                    { 77, 6, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119502.0 },
                    { 73, 46, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58350.0 },
                    { 72, 33, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 109981.0 },
                    { 70, 27, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144997.0 },
                    { 84, 34, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68312.0 },
                    { 68, 2, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66875.0 },
                    { 69, 23, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104411.0 },
                    { 58, 7, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44314.0 },
                    { 60, 10, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 127477.0 },
                    { 61, 11, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 141788.0 },
                    { 62, 47, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96304.0 },
                    { 54, 13, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50566.0 },
                    { 64, 34, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 145663.0 },
                    { 65, 4, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77579.0 },
                    { 67, 47, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125092.0 },
                    { 63, 5, new DateTime(2021, 9, 25, 11, 17, 41, 859, DateTimeKind.Local).AddTicks(4209), "Juan Leon", 3, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26703.0 }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "DirectorId", "CreatedAt", "CreatedBy", "MarcaId", "Nombre", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8485), "Juan Leon", 7, "Keiji Inafune", null },
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8447), "Juan Leon", 4, "Yoko Taro", null },
                    { 19, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8479), "Juan Leon", 7, "Sid Meier", null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8390), "Juan Leon", 7, "Hidetaka Miyazaki", null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8444), "Juan Leon", 6, "Tom Howard", null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8393), "Juan Leon", 6, "Tim Schafer", null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8450), "Juan Leon", 5, "Shigeru Miyamoto", null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8441), "Juan Leon", 5, "Gabe Newell", null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8464), "Juan Leon", 4, "Goichi Suda", null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8437), "Juan Leon", 4, "Yves Guillemot", null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8453), "Juan Leon", 3, "Amy Hennig", null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(7840), "Juan Leon", 4, "Hideo Kojima", null },
                    { 20, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8482), "Juan Leon", 3, "John Carmack", null },
                    { 17, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8473), "Juan Leon", 3, "Yuji Horii", null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8383), "Juan Leon", 3, "Will Wriths", null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8467), "Juan Leon", 2, "Warren Spector", null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8461), "Juan Leon", 2, "Michel Ancel", null },
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8469), "Juan Leon", 1, "John Romero", null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8397), "Juan Leon", 1, "Ken Levine", null },
                    { 18, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8477), "Juan Leon", 8, "Yuji Naka", null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8400), "Juan Leon", 4, "Fumito Ueda", null },
                    { 22, new DateTime(2021, 9, 25, 11, 17, 41, 860, DateTimeKind.Local).AddTicks(8487), "Juan Leon", 8, "Hironobu Sakaguchi", null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 48, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(999), "Juan Leon", 5, new DateTime(2020, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 2042", 21162.0, 3, null },
                    { 17, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(895), "Juan Leon", 10, new DateTime(2002, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", 23072.0, 3, null },
                    { 39, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(975), "Juan Leon", 10, new DateTime(2009, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", 15977.0, 5, null },
                    { 41, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(980), "Juan Leon", 10, new DateTime(1995, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch", 21974.0, 2, null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(848), "Juan Leon", 14, new DateTime(2007, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA Vice City", 18253.0, 4, null },
                    { 28, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(934), "Juan Leon", 14, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims", 18512.0, 8, null },
                    { 49, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(1003), "Juan Leon", 14, new DateTime(2007, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "florence", 18485.0, 13, null },
                    { 23, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(916), "Juan Leon", 8, new DateTime(2000, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires III", 17171.0, 12, null },
                    { 25, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(924), "Juan Leon", 8, new DateTime(2002, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Dead Redemption II", 23743.0, 2, null },
                    { 34, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(956), "Juan Leon", 8, new DateTime(2004, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fligth Simulation", 19978.0, 4, null },
                    { 44, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(988), "Juan Leon", 8, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Squadrons", 15946.0, 11, null },
                    { 43, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(985), "Juan Leon", 11, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fortnite", 21333.0, 4, null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(318), "Juan Leon", 4, new DateTime(2001, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed I", 17223.0, 12, null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(862), "Juan Leon", 4, new DateTime(1998, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 18", 18800.0, 9, null },
                    { 36, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(967), "Juan Leon", 4, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pureya", 15822.0, 3, null },
                    { 22, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(911), "Juan Leon", 9, new DateTime(2014, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires II", 20324.0, 12, null },
                    { 30, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(942), "Juan Leon", 9, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo", 22222.0, 7, null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(883), "Juan Leon", 19, new DateTime(2004, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears Of War", 19413.0, 2, null },
                    { 26, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(928), "Juan Leon", 19, new DateTime(1995, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "DOOM", 16972.0, 7, null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(845), "Juan Leon", 21, new DateTime(2002, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA III", 24219.0, 7, null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(853), "Juan Leon", 18, new DateTime(2018, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA IV", 20358.0, 12, null },
                    { 20, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(904), "Juan Leon", 18, new DateTime(1997, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon", 18648.0, 12, null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(887), "Juan Leon", 7, new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs", 18480.0, 11, null },
                    { 45, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(990), "Juan Leon", 6, new DateTime(2005, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil 8: Village", 24351.0, 12, null },
                    { 40, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(977), "Juan Leon", 6, new DateTime(1995, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us 2", 23894.0, 12, null },
                    { 32, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(949), "Juan Leon", 6, new DateTime(2012, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plants vs Zombies", 21754.0, 10, null },
                    { 18, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(898), "Juan Leon", 16, new DateTime(2013, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 2", 15423.0, 13, null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(837), "Juan Leon", 13, new DateTime(2005, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassins Creed Valhalla", 21623.0, 7, null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(859), "Juan Leon", 13, new DateTime(2012, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 17", 16519.0, 8, null },
                    { 19, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(901), "Juan Leon", 13, new DateTime(2013, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3", 16645.0, 12, null },
                    { 27, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(931), "Juan Leon", 15, new DateTime(2013, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pong", 15532.0, 6, null },
                    { 33, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(954), "Juan Leon", 15, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battlefield 3", 21145.0, 5, null },
                    { 37, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(970), "Juan Leon", 15, new DateTime(2005, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rust", 23378.0, 10, null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(856), "Juan Leon", 2, new DateTime(2009, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA V", 15355.0, 7, null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(867), "Juan Leon", 2, new DateTime(2007, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 20", 16390.0, 11, null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(869), "Juan Leon", 2, new DateTime(1999, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 21", 24904.0, 8, null },
                    { 35, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(963), "Juan Leon", 18, new DateTime(2003, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chivarly II", 19347.0, 6, null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(872), "Juan Leon", 2, new DateTime(2020, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", 20746.0, 11, null },
                    { 50, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(1007), "Juan Leon", 2, new DateTime(1998, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "portal", 15623.0, 14, null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(851), "Juan Leon", 12, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GTA San Andreas", 15274.0, 14, null },
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(864), "Juan Leon", 12, new DateTime(2015, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 19", 23552.0, 7, null },
                    { 21, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(907), "Juan Leon", 12, new DateTime(1996, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires", 17404.0, 8, null }
                });

            migrationBuilder.InsertData(
                table: "Juego",
                columns: new[] { "JuegoId", "CreatedAt", "CreatedBy", "DirectorId", "Lanzamiento", "Nombre", "Precio", "Stock", "UpdatedAt" },
                values: new object[,]
                {
                    { 29, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(939), "Juan Leon", 12, new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 2", 21923.0, 14, null },
                    { 38, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(972), "Juan Leon", 20, new DateTime(2012, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mass Effect: Legendary Edition", 19698.0, 11, null },
                    { 31, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(945), "Juan Leon", 1, new DateTime(2008, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angry Birds", 18419.0, 14, null },
                    { 42, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(982), "Juan Leon", 1, new DateTime(1996, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "NBA 2K21", 20601.0, 9, null },
                    { 46, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(993), "Juan Leon", 1, new DateTime(2000, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heroes of the Storm", 17270.0, 11, null },
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(891), "Juan Leon", 6, new DateTime(2016, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch_Dogs 2", 23735.0, 11, null },
                    { 24, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(920), "Juan Leon", 2, new DateTime(1999, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Age Of Empires IV", 24012.0, 8, null },
                    { 47, new DateTime(2021, 9, 25, 11, 17, 41, 861, DateTimeKind.Local).AddTicks(996), "Juan Leon", 18, new DateTime(2001, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battefield 4", 21537.0, 8, null }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 49, 52, 106052, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 },
                    { 239, 75, 96601, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 211, 8, 92707, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 175, 46, 145663, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 120, 15, 94428, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 95, 66, 30776, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 19, 7, 66378, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 43, null, 0.0 },
                    { 83, 54, 98438, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 43, null, 0.0 },
                    { 276, 85, 29050, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 105, 52, 38167, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 90, 32, 141290, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 82, 66, 58416, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 73, 75, 37705, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 33, 46, 96775, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 38, null, 0.0 },
                    { 101, 61, 104308, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 43, null, 0.0 },
                    { 133, 45, 110081, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 43, null, 0.0 },
                    { 257, 53, 118835, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 242, 32, 131387, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 29, null, 0.0 },
                    { 272, 79, 144966, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 300, 69, 61490, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 216, 19, 90171, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 230, 80, 34029, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 262, 68, 119215, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 85, 93, 61898, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 100, 13, 130808, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 122, 15, 44295, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 252, 6, 73970, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 169, 59, 64052, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 155, 86, 25096, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 124, 3, 136806, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 45, 88, 104543, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 1, 75, 79988, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 42, null, 0.0 },
                    { 170, 91, 48096, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 217, 38, 135502, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 290, 5, 142329, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 44, null, 0.0 },
                    { 278, 53, 64198, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 31, null, 0.0 },
                    { 235, 14, 98902, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 29, null, 0.0 },
                    { 228, 47, 53280, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 29, null, 0.0 },
                    { 215, 64, 135519, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 29, null, 0.0 },
                    { 240, 40, 90282, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 224, 21, 68033, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 207, 98, 147496, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 205, 79, 69030, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 89, 50, 34909, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 68, 13, 146192, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 210, 70, 65763, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 39, null, 0.0 },
                    { 4, 57, 138160, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 26, 6, 78821, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 75, 14, 76179, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 123, 61, 136283, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 150, 44, 149496, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 199, 4, 73098, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 226, 2, 50444, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 297, 49, 104136, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 282, 31, 81647, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 296, 65, 76551, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 196, 30, 136633, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 186, 56, 43261, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 5, 32, 122625, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 29, null, 0.0 },
                    { 2, 98, 77231, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 71, 41, 86754, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 97, 75, 95472, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 144, 55, 103636, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 166, 7, 56053, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 197, 38, 64858, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 9, 3, 78503, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 218, 6, 140888, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 1, null, 0.0 },
                    { 294, 10, 78015, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 21, null, 0.0 },
                    { 261, 82, 139123, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 21, null, 0.0 },
                    { 182, 7, 77255, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 21, null, 0.0 },
                    { 14, 64, 30171, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 76, 69, 121207, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 77, 58, 141815, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 163, 78, 131520, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 3, 37, 90444, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 9, null, 0.0 },
                    { 136, 54, 144596, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 157, 52, 70234, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 172, 14, 61144, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 130, 73, 61231, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 147, 41, 131042, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 176, 73, 109334, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 225, 43, 98735, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 268, 15, 108084, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 289, 62, 92396, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 161, 33, 142427, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 28, null, 0.0 },
                    { 198, 45, 91420, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 28, null, 0.0 },
                    { 292, 17, 55997, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 180, 46, 56159, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 156, 76, 85012, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 107, 66, 97955, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 53, 47, 117550, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 29, 7, 41109, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 8, 14, 45295, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 45, null, 0.0 },
                    { 86, 17, 46720, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 15, null, 0.0 },
                    { 201, 22, 107258, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 15, null, 0.0 },
                    { 127, 59, 85952, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 62, 87, 47338, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 80, 67, 35339, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 39, null, 0.0 },
                    { 18, 13, 108392, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 58, 8, 149885, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 138, 21, 62756, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 181, 43, 110804, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 206, 19, 54903, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 277, 99, 106732, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 41, null, 0.0 },
                    { 203, 7, 119646, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 28, null, 0.0 },
                    { 149, 75, 34191, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 17, null, 0.0 },
                    { 59, 73, 130424, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 17, null, 0.0 },
                    { 12, 78, 139864, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 20, 21, 113466, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 39, 19, 95687, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 54, 98, 72982, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 57, 69, 100356, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 60, 38, 68804, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 4, null, 0.0 },
                    { 87, 54, 143024, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 17, null, 0.0 },
                    { 266, 87, 41821, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 231, 76, 69475, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 28, null, 0.0 },
                    { 15, 58, 72808, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 112, 92, 114952, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 16, null, 0.0 },
                    { 35, 91, 52076, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 16, null, 0.0 },
                    { 32, 61, 110574, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 16, null, 0.0 },
                    { 25, 53, 32735, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 16, null, 0.0 },
                    { 111, 23, 68972, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 25, null, 0.0 },
                    { 160, 97, 96323, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 25, null, 0.0 },
                    { 233, 1, 134549, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 25, null, 0.0 },
                    { 63, 54, 29185, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 96, 36, 39947, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 141, 45, 98766, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 159, 2, 67392, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 34, null, 0.0 },
                    { 280, 97, 36961, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 246, 69, 86774, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 229, 32, 61979, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 177, 36, 142306, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 46, null, 0.0 },
                    { 209, 54, 110232, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 16, null, 0.0 },
                    { 269, 56, 87331, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 23, null, 0.0 },
                    { 254, 8, 60821, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 23, null, 0.0 },
                    { 245, 42, 78312, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 23, null, 0.0 },
                    { 30, 34, 30011, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 255, 23, 80828, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 40, null, 0.0 },
                    { 219, 85, 140387, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 40, null, 0.0 },
                    { 151, 16, 91047, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 40, null, 0.0 },
                    { 140, 70, 133520, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 40, null, 0.0 },
                    { 132, 65, 37919, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 40, null, 0.0 },
                    { 56, 10, 60786, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 237, 64, 107610, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 28, null, 0.0 },
                    { 193, 71, 145365, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 273, 63, 69286, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 264, 73, 101203, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 32, null, 0.0 },
                    { 168, 64, 33659, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 32, null, 0.0 },
                    { 106, 2, 78379, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 32, null, 0.0 },
                    { 61, 67, 64698, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 32, null, 0.0 },
                    { 81, 29, 51112, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 23, null, 0.0 },
                    { 243, 56, 68954, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 23, null, 0.0 },
                    { 247, 99, 123715, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 49, null, 0.0 },
                    { 248, 40, 134133, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 38, 13, 109205, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 10, null, 0.0 },
                    { 187, 76, 70616, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 279, 42, 139721, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 274, 39, 75104, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 222, 87, 25685, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 213, 67, 106307, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 208, 58, 89230, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 146, 42, 112130, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 126, 88, 91845, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 287, 1, 124852, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 23, 86, 126875, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 251, 5, 26131, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 293, 18, 103177, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 31, 52, 132380, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 43, 94, 52387, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 },
                    { 258, 51, 76612, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 220, 68, 37276, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 158, 62, 145795, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 13, 66, 58581, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 19, null, 0.0 },
                    { 137, 81, 75816, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 171, 38, 105465, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 50, 24, 99922, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 72, 14, 64734, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 270, 3, 147098, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 64, 61, 73491, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 26, null, 0.0 },
                    { 234, 44, 148224, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 173, 28, 34978, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 26, null, 0.0 },
                    { 189, 42, 30112, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 26, null, 0.0 },
                    { 295, 52, 101159, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 26, null, 0.0 },
                    { 128, 66, 135822, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 260, 66, 43586, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 27, null, 0.0 },
                    { 184, 30, 140632, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 27, null, 0.0 },
                    { 114, 55, 120084, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 27, null, 0.0 },
                    { 110, 77, 81273, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 3, null, 0.0 },
                    { 145, 77, 97318, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 3, null, 0.0 },
                    { 191, 32, 99361, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 3, null, 0.0 },
                    { 267, 25, 53039, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 3, null, 0.0 },
                    { 16, 12, 81549, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 6, null, 0.0 },
                    { 200, 15, 66264, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 27, null, 0.0 },
                    { 88, 66, 48793, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 108, 56, 121647, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 36, 84, 27437, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 24, 47, 90559, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 37, 73, 144795, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 291, 22, 44587, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 18, null, 0.0 },
                    { 250, 37, 75922, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 18, null, 0.0 },
                    { 227, 2, 65780, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 18, null, 0.0 },
                    { 118, 16, 87998, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 18, null, 0.0 },
                    { 99, 35, 50323, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 18, null, 0.0 },
                    { 10, 3, 98528, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 98, 75, 128896, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 153, 7, 117303, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 298, 73, 117752, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 185, 29, 120185, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 },
                    { 167, 60, 29871, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 },
                    { 142, 9, 46377, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 109, 7, 146803, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 },
                    { 79, 84, 136017, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 48, null, 0.0 },
                    { 143, 82, 51990, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 47, null, 0.0 },
                    { 46, 76, 147397, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 8, null, 0.0 },
                    { 256, 83, 106573, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 115, 59, 42691, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 103, 55, 132601, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 },
                    { 121, 85, 130711, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 },
                    { 179, 35, 64488, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 },
                    { 221, 66, 135437, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 20, null, 0.0 },
                    { 22, 29, 44201, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 265, 16, 146289, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 259, 25, 62360, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 162, 46, 112133, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 244, 68, 114349, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 139, 36, 78020, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 70, 80, 70371, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 7, 4, 76828, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 41, 91, 62286, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 51, 15, 118113, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 65, 42, 116149, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 92, 39, 144910, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 35, null, 0.0 },
                    { 195, 56, 141094, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 2, null, 0.0 },
                    { 94, 64, 51883, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 78, 44, 135404, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 26, null, 0.0 },
                    { 232, 61, 75885, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 165, 38, 55538, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 281, 55, 76729, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 285, 47, 32898, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 27, 4, 144113, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 134, 56, 30208, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 12, null, 0.0 },
                    { 129, 93, 140128, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 12, null, 0.0 },
                    { 104, 63, 60681, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 12, null, 0.0 },
                    { 66, 67, 123735, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 12, null, 0.0 },
                    { 44, 9, 141472, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 84, 16, 91187, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 125, 45, 143290, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 178, 41, 57646, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 271, 38, 132562, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 194, 66, 131698, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 188, 14, 29186, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 135, 74, 81031, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 55, 47, 52479, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 102, 54, 56517, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 13, null, 0.0 },
                    { 52, 4, 110660, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 152, 11, 32473, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 13, null, 0.0 },
                    { 212, 98, 37587, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 13, null, 0.0 },
                    { 131, 84, 50735, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 67, 83, 68089, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 5, null, 0.0 },
                    { 236, 53, 138422, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 36, null, 0.0 },
                    { 6, 87, 58810, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 48, 54, 110696, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 69, 66, 128096, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 284, 46, 136057, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 223, 84, 28547, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 202, 19, 122382, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 174, 85, 53073, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 113, 52, 38868, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 93, 1, 128782, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 74, 46, 145904, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 11, 32, 84309, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 24, null, 0.0 },
                    { 117, 8, 98901, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 154, 56, 105895, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 22, null, 0.0 },
                    { 275, 48, 141511, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 13, null, 0.0 },
                    { 204, 32, 136095, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 13, null, 0.0 },
                    { 47, 53, 52708, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 11, null, 0.0 },
                    { 286, 59, 145505, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 39, null, 0.0 },
                    { 241, 18, 45766, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 283, 92, 57102, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 214, 80, 36232, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 192, 29, 80021, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 183, 78, 126631, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 164, 52, 110571, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 148, 77, 33697, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 34, 24, 62389, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 37, null, 0.0 },
                    { 40, 22, 70474, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 299, 90, 118061, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 42, 65, 99658, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 190, 42, 146020, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 17, 20, 148940, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 28, 40, 54489, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 238, 13, 140537, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 21, 82, 70864, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 7, null, 0.0 },
                    { 91, 23, 77082, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 7, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Alquiler_Dets",
                columns: new[] { "AlquilerDetId", "AlquilerId", "Cantidad", "CreatedAt", "CreatedBy", "JuegoId", "UpdatedAt", "Valor" },
                values: new object[,]
                {
                    { 263, 87, 52250, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 119, 60, 36592, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 7, null, 0.0 },
                    { 253, 54, 101034, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 14, null, 0.0 },
                    { 249, 80, 146179, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 33, null, 0.0 },
                    { 288, 16, 98727, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 30, null, 0.0 },
                    { 116, 32, 31281, new DateTime(2021, 9, 25, 11, 17, 41, 869, DateTimeKind.Local).AddTicks(1677), "Juan Leon", 7, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 64, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 34, 15, null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 14, 12, null },
                    { 46, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 34, 6, null },
                    { 61, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 41, 14, null },
                    { 69, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 47, 13, null },
                    { 18, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 9, 7, null },
                    { 79, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 39, 3, null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 41, 14, null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 3, 6, null },
                    { 85, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 30, 12, null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 43, 5, null },
                    { 17, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 49, 11, null },
                    { 74, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 49, 12, null },
                    { 80, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 49, 6, null },
                    { 100, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 49, 1, null },
                    { 27, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 43, 9, null },
                    { 73, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 43, 13, null },
                    { 72, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 44, 6, null },
                    { 24, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 44, 5, null },
                    { 50, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 25, 3, null },
                    { 93, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 23, 8, null },
                    { 49, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 1, 13, null },
                    { 90, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 1, 15, null },
                    { 84, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 22, 15, null },
                    { 39, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 22, 14, null },
                    { 96, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 4, 12, null },
                    { 40, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 30, 12, null },
                    { 45, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 30, 5, null },
                    { 94, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 3, 10, null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 49, 4, null },
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 44, 3, null },
                    { 92, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 34, 6, null },
                    { 37, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 45, 2, null },
                    { 52, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 5, 13, null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 16, 5, null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 16, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 44, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 16, 7, null },
                    { 60, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 16, 12, null },
                    { 83, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 19, 13, null },
                    { 71, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 19, 9, null },
                    { 57, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 19, 15, null },
                    { 62, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 37, 14, null },
                    { 41, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 19, 1, null },
                    { 70, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 32, 10, null },
                    { 36, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 42, 7, null },
                    { 81, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 21, 5, null },
                    { 89, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 2, 6, null },
                    { 87, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 2, 10, null },
                    { 38, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 2, 13, null },
                    { 67, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 21, 7, null },
                    { 42, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 32, 8, null },
                    { 56, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 21, 13, null },
                    { 48, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 29, 2, null },
                    { 47, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 38, 14, null },
                    { 53, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 42, 2, null },
                    { 63, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 42, 8, null },
                    { 59, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 31, 11, null },
                    { 58, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 31, 7, null },
                    { 66, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 42, 9, null },
                    { 97, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 42, 5, null },
                    { 77, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 27, 12, null },
                    { 43, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 37, 11, null },
                    { 65, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 27, 14, null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 46, 13, null },
                    { 20, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 46, 1, null },
                    { 26, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 27, 4, null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 27, 4, null },
                    { 95, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 5, 13, null },
                    { 29, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 37, 15, null },
                    { 30, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 37, 1, null },
                    { 55, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 27, 4, null },
                    { 51, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 21, 8, null },
                    { 32, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 8, 1, null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 12, 9, null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 10, 5, null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 15, 6, null },
                    { 23, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 15, 12, null },
                    { 54, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 15, 12, null }
                });

            migrationBuilder.InsertData(
                table: "Plataforma_Juego",
                columns: new[] { "PlataformaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "PlataformaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 10, 6, null },
                    { 25, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 11, null },
                    { 21, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 3, null },
                    { 19, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 8, null },
                    { 98, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 13, 1, null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 17, 5, null },
                    { 34, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 17, 6, null },
                    { 78, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 17, 8, null },
                    { 31, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 24, 5, null },
                    { 76, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 24, 6, null },
                    { 86, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 24, 12, null },
                    { 91, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 24, 14, null },
                    { 28, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 5, 14, null },
                    { 35, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 10, 9, null },
                    { 82, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 10, 10, null },
                    { 75, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 15, 3, null },
                    { 33, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 21, 2, null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 2, 6, null },
                    { 22, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 45, 14, null },
                    { 68, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 13, null },
                    { 88, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 4, null },
                    { 99, new DateTime(2021, 9, 25, 11, 17, 41, 863, DateTimeKind.Local).AddTicks(3191), "Juan Leon", 18, 5, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 119, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 11, 14, null },
                    { 22, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 13, 1, null },
                    { 69, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 33, 13, null },
                    { 26, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 22, 18, null },
                    { 54, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 22, 25, null },
                    { 49, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 33, 6, null },
                    { 200, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 27, 24, null },
                    { 147, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 22, 32, null },
                    { 152, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 22, 20, null },
                    { 74, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 11, 20, null },
                    { 46, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 12, 10, null },
                    { 59, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 11, 27, null },
                    { 199, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 33, 2, null },
                    { 52, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 22, 31, null },
                    { 80, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 37, 13, null },
                    { 83, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 37, 26, null },
                    { 70, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 37, 28, null },
                    { 27, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 7, 4, null },
                    { 198, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 11, 3, null },
                    { 191, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 33, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 56, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 7, 11, null },
                    { 60, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 12, 27, null },
                    { 51, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 30, 12, null },
                    { 101, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 30, 27, null },
                    { 117, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 12, 22, null },
                    { 125, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 12, 19, null },
                    { 193, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 12, 13, null },
                    { 44, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 30, 9, null },
                    { 169, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 27, 29, null },
                    { 103, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 19, null },
                    { 100, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 1, null },
                    { 76, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 20, 28, null },
                    { 133, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 18, 15, null },
                    { 47, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 18, 25, null },
                    { 42, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 18, 22, null },
                    { 40, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 18, 2, null },
                    { 13, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 24, null },
                    { 19, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 6, null },
                    { 20, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 26, null },
                    { 31, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 19, null },
                    { 38, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 20, null },
                    { 109, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 22, null },
                    { 118, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 16, null },
                    { 148, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 10, null },
                    { 149, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 32, null },
                    { 157, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 20, null },
                    { 163, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 35, 19, null },
                    { 130, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 48, 10, null },
                    { 98, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 48, 27, null },
                    { 96, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 48, 23, null },
                    { 75, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 48, 15, null },
                    { 14, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 48, 24, null },
                    { 116, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 47, 14, null },
                    { 122, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 47, 26, null },
                    { 25, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 20, 24, null },
                    { 23, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 20, 21, null },
                    { 15, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 20, 10, null },
                    { 5, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 20, 3, null },
                    { 102, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 32, null },
                    { 107, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 15, null },
                    { 112, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 22, null },
                    { 195, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 24, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 39, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 28, null },
                    { 62, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 16, null },
                    { 144, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 20, null },
                    { 159, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 10, null },
                    { 182, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 26, 9, null },
                    { 173, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 27, null },
                    { 153, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 27, null },
                    { 28, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 14, 21, null },
                    { 137, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 18, null },
                    { 92, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 27, null },
                    { 17, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 32, null },
                    { 34, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 3, 7, null },
                    { 132, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 8, 32, null },
                    { 41, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 8, 4, null },
                    { 37, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 6, 12, null },
                    { 61, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 6, 26, null },
                    { 95, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 6, 21, null },
                    { 126, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 6, 22, null },
                    { 10, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 8, 29, null },
                    { 67, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 2, 22, null },
                    { 111, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 19, 9, null },
                    { 58, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 39, 20, null },
                    { 7, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 10, 32, null },
                    { 87, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 5, 12, null },
                    { 166, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 40, 11, null },
                    { 141, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 40, 32, null },
                    { 24, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 28, 28, null },
                    { 129, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 28, 20, null },
                    { 151, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 28, 26, null },
                    { 73, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 40, 30, null },
                    { 36, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 40, 15, null },
                    { 128, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 32, 11, null },
                    { 110, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 32, 22, null },
                    { 97, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 32, 11, null },
                    { 172, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 29, null },
                    { 139, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 15, null },
                    { 121, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 28, null },
                    { 85, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 32, null },
                    { 143, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 49, 10, null },
                    { 156, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 49, 3, null },
                    { 160, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 49, 3, null },
                    { 171, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 49, 6, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 197, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 49, 22, null },
                    { 84, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 13, null },
                    { 4, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 16, 29, null },
                    { 6, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 23, 14, null },
                    { 68, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 23, 26, null },
                    { 150, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 23, 10, null },
                    { 170, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 23, 6, null },
                    { 168, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 40, 1, null },
                    { 89, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 17, null },
                    { 161, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 47, 16, null },
                    { 184, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 4, 3, null },
                    { 176, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 39, 14, null },
                    { 183, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 17, 22, null },
                    { 178, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 17, 2, null },
                    { 138, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 17, 17, null },
                    { 99, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 17, 17, null },
                    { 155, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 15, 5, null },
                    { 30, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 41, 31, null },
                    { 50, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 41, 22, null },
                    { 79, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 41, 31, null },
                    { 185, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 41, 16, null },
                    { 196, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 41, 17, null },
                    { 154, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 15, 12, null },
                    { 120, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 15, 4, null },
                    { 91, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 15, 17, null },
                    { 65, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 15, 3, null },
                    { 180, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 26, null },
                    { 174, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 26, null },
                    { 146, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 20, null },
                    { 140, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 12, null },
                    { 81, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 3, null },
                    { 71, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 27, null },
                    { 16, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 45, 24, null },
                    { 48, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 4, 20, null },
                    { 57, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 4, 25, null },
                    { 105, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 4, 10, null },
                    { 188, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 4, 25, null },
                    { 64, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 5, 12, null },
                    { 88, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 9, null },
                    { 77, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 32, null },
                    { 124, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 7, null },
                    { 12, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 43, 25, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 164, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 43, 13, null },
                    { 115, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 4, null },
                    { 94, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 1, null },
                    { 55, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 22, null },
                    { 35, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 15, null },
                    { 1, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 2, null },
                    { 113, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 1, 8, null },
                    { 145, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 1, 13, null },
                    { 167, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 1, 21, null },
                    { 177, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 1, 13, null },
                    { 190, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 1, 29, null },
                    { 63, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 10, 17, null },
                    { 29, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 10, 14, null },
                    { 194, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 17, 20, null },
                    { 134, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 5, 21, null },
                    { 2, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 17, null },
                    { 21, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 6, null },
                    { 33, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 23, null },
                    { 114, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 24, null },
                    { 136, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 10, null },
                    { 179, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 2, null },
                    { 189, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 9, 24, null },
                    { 108, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 5, 13, null },
                    { 131, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 21, 1, null },
                    { 86, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 27, null },
                    { 18, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 29, 14, null },
                    { 11, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 38, 25, null },
                    { 32, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 25, 4, null },
                    { 82, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 25, 11, null },
                    { 142, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 25, 28, null },
                    { 158, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 25, 14, null },
                    { 175, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 25, 9, null },
                    { 66, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 12, null },
                    { 53, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 46, 32, null },
                    { 187, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 42, 26, null },
                    { 165, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 42, 1, null },
                    { 72, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 42, 1, null },
                    { 43, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 42, 12, null },
                    { 3, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 34, 22, null },
                    { 45, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 34, 30, null },
                    { 90, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 34, 10, null },
                    { 93, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 34, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Protagonista_Juego",
                columns: new[] { "ProtagonistaJuegoId", "CreatedAt", "CreatedBy", "JuegoId", "ProtagonistaId", "UpdatedAt" },
                values: new object[,]
                {
                    { 162, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 31, 13, null },
                    { 9, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 31, 27, null },
                    { 135, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 38, 21, null },
                    { 123, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 38, 21, null },
                    { 104, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 38, 18, null },
                    { 8, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 44, 17, null },
                    { 106, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 44, 11, null },
                    { 127, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 44, 20, null },
                    { 186, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 44, 21, null },
                    { 192, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 44, 19, null },
                    { 78, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 29, 27, null },
                    { 181, new DateTime(2021, 9, 25, 11, 17, 41, 866, DateTimeKind.Local).AddTicks(355), "Juan Leon", 47, 30, null }
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
