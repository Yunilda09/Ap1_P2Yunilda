﻿using System;
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
                    UnidadMedida = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false)
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
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 1, "Vitamina A ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 2, "Vitamina B1 ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 3, "Vitamina B2 ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 4, "Vitamina B6 ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 5, "Vitamina B12 ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 6, "Vitamina C", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 7, "Vitamina D ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 8, "Vitamina E ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 9, "Vitamina K ", 0.0, "mg" });

            migrationBuilder.InsertData(
                table: "Vitaminas",
                columns: new[] { "VitaminaId", "Descripcion", "Existencia", "UnidadMedida" },
                values: new object[] { 10, "Vitamina B3 ", 0.0, "mg" });

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
