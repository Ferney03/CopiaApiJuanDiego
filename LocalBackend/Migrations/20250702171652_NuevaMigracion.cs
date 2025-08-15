using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBackend.Migrations
{
    /// <inheritdoc />
    public partial class NuevaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UpaIdUpa",
                table: "AsignacionSistema",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionSistema_UpaIdUpa",
                table: "AsignacionSistema",
                column: "UpaIdUpa");

            migrationBuilder.AddForeignKey(
                name: "FK_AsignacionSistema_Upa_UpaIdUpa",
                table: "AsignacionSistema",
                column: "UpaIdUpa",
                principalTable: "Upa",
                principalColumn: "IdUpa",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AsignacionSistema_Upa_UpaIdUpa",
                table: "AsignacionSistema");

            migrationBuilder.DropIndex(
                name: "IX_AsignacionSistema_UpaIdUpa",
                table: "AsignacionSistema");

            migrationBuilder.DropColumn(
                name: "UpaIdUpa",
                table: "AsignacionSistema");
        }
    }
}
