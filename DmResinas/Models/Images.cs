using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DmResinas.Models
{
    [Table("Images")]
    public class Images
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Coloca automático a chave primária
        public byte ImageId { get; set; }
        [Display(Name = "Imagens do Produto")]
        //Display é o que aparece na tela para o usuário e não está ligado ao banco

        [Required(ErrorMessage = "Você precisa de pelo menos uma imagem")]
        //Required é usado quando algo é obrigado
        public string ImageCode { get; set; }

        [Key]
        public int ProdId { get; set; }
        [ForeignKey("ProdId")]
        public Products Products { get; set; }
    }
}