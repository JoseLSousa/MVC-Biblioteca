using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class ModificandoTabelaLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantidadeEstoque",
                table: "Livro",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeEstoque",
                table: "Livro");
        }
    }
}
