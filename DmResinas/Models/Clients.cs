using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DmResinas.Models
{
    [Table("Client")]
    public class Clients : IdentityUser
    {


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(50, ErrorMessage = "o nome deve possuir no maximo 50 caracteres")]
        public string ClientName { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O Telefone é obrigatorio")]
        public Int16 ClientPhone { get; set; }

        [Display(Name = "Idade")]
        [Required(ErrorMessage = "A idade é obrigatorio")]
        public byte ClientAge { get; set; }


    }
}