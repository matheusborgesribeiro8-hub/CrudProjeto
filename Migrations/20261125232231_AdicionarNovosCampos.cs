using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudProjeto.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarNovosCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "ClassificadoresProjeto");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "ClassificadoresProjeto",
                newName: "Titulo");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "ClassificadoresProjeto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "ClassificadoresProjeto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "ClassificadoresProjeto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "ClassificadoresProjeto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pontuacao",
                table: "ClassificadoresProjeto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "ClassificadoresProjeto");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "ClassificadoresProjeto");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "ClassificadoresProjeto");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "ClassificadoresProjeto");

            migrationBuilder.DropColumn(
                name: "Pontuacao",
                table: "ClassificadoresProjeto");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "ClassificadoresProjeto",
                newName: "Nome");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "ClassificadoresProjeto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
