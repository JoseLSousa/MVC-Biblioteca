using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O endereço é obrigatório")]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O número do documento é obrigatório")]
        [Display(Name ="Número do documento")]
        public string NumeroDocumento { get; set; }
    }
}
