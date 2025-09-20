using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatosMVC.Models
{
    public class ContatoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o celular")]
        public string Celular { get; set; }
    }
}
