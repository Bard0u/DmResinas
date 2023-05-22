using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DmResinas.Models
{
    [Table("Client")]
    public class Clients : IdentityUser
    {
        [Key]
        public int IdClient { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(50, ErrorMessage = "o nome deve possuir no maximo 50 caracteres")]
        public string ClientName { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O E-mail é obrigatorio")]
        [StringLength(70, ErrorMessage = "o E-mail deve possuir no maximo 70 caracteres")]
        public string ClientEmail { get; set; }

        //public string ClientEnder { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O Telefone é obrigatorio")]
        public Int16 ClientPhone { get; set; }

        [Display(Name = "Idade")]
        [Required(ErrorMessage = "A idade é obrigatorio")]
        public byte ClientAge { get; set; }

        [Key]
        public int ProdId { get; set; }
        [ForeignKey("ProdId")]
        public Products Products { get; set; }

    }
}