using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiAuto.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    IdAuto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Motor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puertas = table.Column<int>(type: "int", nullable: false),
                    AñoFabricación = table.Column<int>(type: "int", nullable: false),
                    kilometrage = table.Column<int>(type: "int", nullable: false),
                    chaces = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacidadPasajeros = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.IdAuto);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    UsserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    IdCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoFact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Concepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdAuto = table.Column<int>(type: "int", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.IdCompra);
                    table.ForeignKey(
                        name: "FK_Compras_Autos_IdAuto",
                        column: x => x.IdAuto,
                        principalTable: "Autos",
                        principalColumn: "IdAuto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Personas_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Personas",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "IdAuto", "AñoFabricación", "Marca", "Motor", "Precio", "capacidadPasajeros", "chaces", "kilometrage", "puertas" },
                values: new object[,]
                {
                    { 1, 2000, "Ford", "V8", 45000m, 4, "---", 450, 4 },
                    { 2, 2000, "Chevy, Camaro", "V6", 8900m, 4, "---", 56443, 2 },
                    { 3, 2015, "Ford Raptor", "V6, twin turbo", 50000m, 4, "---", 450, 4 },
                    { 4, 2009, "Porsche 911 turbo s", "Boxer 6 cilindros", 150000m, 4, "---", 450, 2 },
                    { 5, 2005, "Ford, fiesta", "V8", 25000m, 4, "---", 450, 4 },
                    { 6, 2010, "Toyota, corolla", "Motor en linea 6 cilindros", 4000m, 4, "---", 450, 4 },
                    { 7, 2020, "Hyundai, i10", "1.2 litros", 6000m, 4, "---", 450, 4 },
                    { 8, 2020, "Hyundai, i20", "1.0 litros", 11000m, 4, "---", 450, 4 }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "IdPersona", "Apellidos", "Cedula", "Correo", "Nombre", "Password", "Telefono", "Tipo", "UsserName" },
                values: new object[] { 1, "Muñoz", "001-160305-1059V", "davismunoz165@gmail.com", "Davis", "12345", "89689588", "Admin", "TheAdmin" });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "IdCompra", "Concepto", "Date", "IdAuto", "IdPersona", "Total", "codigoFact" },
                values: new object[] { 1, "Compra de un Ford", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 89000m, "120-93782-11" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdAuto",
                table: "Compras",
                column: "IdAuto");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdPersona",
                table: "Compras",
                column: "IdPersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
