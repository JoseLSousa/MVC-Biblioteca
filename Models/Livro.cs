using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        public string Autor { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [Display(Name ="Ano da Publicação")]
        public string AnoPublicacao { get; set; }
        public string Editora { get; set; }
        [Display(Name ="ISBN")]
        public string Isbn { get; set; }
        [Display(Name ="Capa")]
        public string Capa { get; set; }
        [Display(Name ="Gênero")]
        public string Genero { get; set; }
        [Display(Name ="Quantidade em estoque")]
        public int QuantidadeEstoque { get; set; }
    }
}
