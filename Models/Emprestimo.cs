using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; }
        [Display(Name = "Titulo")]
        public int LivroId { get; set; }
        public Usuario Usuario { get; set; }
        [Display(Name ="Usuário")]
        public int UsuarioId { get; set; }
        [Display(Name ="Data do Emprestimo")]
        public DateTime DataEmprestimo { get; set; }
        [Display(Name ="Data da Devolução")]
        public DateTime DataDevolucao { get; set; }
    }
}
