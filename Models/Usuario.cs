using System.ComponentModel.DataAnnotations;

namespace MVCBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }
        [Display(Name ="Número do documento")]
        public string NumeroDocumento { get; set; }
    }
}
