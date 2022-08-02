using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    //Classe responsavel por modelar o Contato
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o E-mail do contato")]
        [EmailAddress(ErrorMessage = "O E-mail informado é invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o Numeor do Contato")]
        [Phone(ErrorMessage = "O Numero informado é invalido")]
        public string Numero { get; set; }
    }
}
