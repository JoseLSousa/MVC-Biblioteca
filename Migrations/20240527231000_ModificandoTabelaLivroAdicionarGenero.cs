using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class ModificandoTabelaLivroAdicionarGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Livro");
        }
    }
}
