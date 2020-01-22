using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Permisos.Infrastructure.Persistence.Migrations
{
    public partial class TipoPermiso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TipoPermisos_ListId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_ListId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Done",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Reminder",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Permisos");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "TipoPermisos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApellidosEmpleado",
                table: "Permisos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPermiso",
                table: "Permisos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NombreEmpleado",
                table: "Permisos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPermisoId",
                table: "Permisos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TipoPermisoId",
                table: "Permisos",
                column: "TipoPermisoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermisoId",
                table: "Permisos",
                column: "TipoPermisoId",
                principalTable: "TipoPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permisos_TipoPermisos_TipoPermisoId",
                table: "Permisos");

            migrationBuilder.DropIndex(
                name: "IX_Permisos_TipoPermisoId",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "TipoPermisos");

            migrationBuilder.DropColumn(
                name: "ApellidosEmpleado",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "FechaPermiso",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "NombreEmpleado",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "TipoPermisoId",
                table: "Permisos");

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "TipoPermisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TipoPermisos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TipoPermisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TipoPermisos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "TipoPermisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TipoPermisos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Permisos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Permisos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Permisos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Reminder",
                table: "Permisos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Permisos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_ListId",
                table: "Permisos",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permisos_TipoPermisos_ListId",
                table: "Permisos",
                column: "ListId",
                principalTable: "TipoPermisos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
