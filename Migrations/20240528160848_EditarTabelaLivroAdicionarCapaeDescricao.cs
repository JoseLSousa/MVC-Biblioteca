using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class EditarTabelaLivroAdicionarCapaeDescricao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Capa",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Livro",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_LivroId",
                table: "Emprestimo",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Emprestimo_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livro_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_Emprestimo_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropIndex(
                name: "IX_Emprestimo_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.DropColumn(
                name: "Capa",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Livro");
        }
    }
}
