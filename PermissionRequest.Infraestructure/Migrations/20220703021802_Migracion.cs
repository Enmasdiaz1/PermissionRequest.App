using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PermissionRequest.Infraestructure.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoPermiso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPermiso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPermiso = table.Column<int>(type: "int", nullable: false),
                    FechaPermiso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permiso_TipoPermiso_TipoPermiso",
                        column: x => x.TipoPermiso,
                        principalTable: "TipoPermiso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_TipoPermiso",
                table: "Permiso",
                column: "TipoPermiso",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "TipoPermiso");
        }
    }
}
