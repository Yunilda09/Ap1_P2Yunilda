using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP2_Yunilda.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verduras",
                columns: table => new
                {
                    VerduraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verduras", x => x.VerduraId);
                });

            migrationBuilder.CreateTable(
                name: "Vitaminas",
                columns: table => new
                {
                    VitaminaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadDeMedidas = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitaminas", x => x.VitaminaId);
                });

            migrationBuilder.CreateTable(
                name: "VerdurasDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VerduraId = table.Column<int>(type: "INTEGER", nullable: false),
                    VitaminasId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerdurasDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VerdurasDetalle_Verduras_VerduraId",
                        column: x => x.VerduraId,
                        principalTable: "Verduras",
                        principalColumn: "VerduraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 1, "Vitamina A (mg)", 1.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 2, "Vitamina B1 (mg)", 1.5 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 3, "Vitamina B2 (mg)", 1.7 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 4, "Vitamina B6 (mg)", 2.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 5, "Vitamina B12 (mcg)", 2.3999999999999999 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 6, "Vitamina C (mg)", 500.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 7, "Vitamina D (mg)", 5.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 8, "Vitamina E (mg)", 670.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 9, "Vitamina K (mcg)", -30.0 });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "UnidadDeMedidas" },
                values: new object[] { 10, "Vitamina B3 (mg)", -2.0 });

            migrationBuilder.CreateIndex(
                name: "IX_VerdurasDetalle_VerduraId",
                table: "VerdurasDetalle",
                column: "VerduraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VerdurasDetalle");

            migrationBuilder.DropTable(
                name: "Vitaminas");

            migrationBuilder.DropTable(
                name: "Verduras");
        }
    }
}
