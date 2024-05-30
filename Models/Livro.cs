using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O título é obrigatório")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O autor é obrigatório")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatório")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O ano da publicação é obrigatório")]
        [Display(Name ="Ano da Publicação")]
        public string AnoPublicacao { get; set; }
        public string Editora { get; set; }
        [Display(Name ="ISBN")]
        public string Isbn { get; set; }
        [Required(ErrorMessage = "A capa é obrigatório")]
        [Display(Name ="Capa")]
        public string Capa { get; set; }
        [Required(ErrorMessage = "O genero é obrigatório")]
        [Display(Name ="Gênero")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "A quantidade é obrigatório")]
        [Display(Name ="Quantidade em estoque")]
        public int QuantidadeEstoque { get; set; }
    }
}
