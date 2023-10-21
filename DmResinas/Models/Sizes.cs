using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{
    [Table("Size")]
    public class Sizes
    {
        [Key]
        public byte SizeId { get; set; }

        [Display(Name = "Altura do Produto")]
        [Required(ErrorMessage = "A altura do produto é obrigatoria")]
        public double height { get; set; }

        [Display(Name = "Largura do Produto")]
        [Required(ErrorMessage = "A largura do produto é obrigatoria")]
        public double width { get; set; }
    }
}