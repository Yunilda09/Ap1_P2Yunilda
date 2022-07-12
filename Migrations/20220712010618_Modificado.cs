using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP2_Yunilda.Migrations
{
    public partial class Modificado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VitaminasId",
                table: "VerdurasDetalle",
                newName: "VitaminaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VitaminaId",
                table: "VerdurasDetalle",
                newName: "VitaminasId");
        }
    }
}
