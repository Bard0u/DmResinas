using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{

    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProdId { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatorio")]
        [StringLength(30, ErrorMessage = "o nome deve possuir no maximo 30 caracteres")]
        public String ProdName { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "O Preço do produto é obrigatorio")]
        public double ProdPrice { get; set; }

        [Display(Name = "Quantidade de Produto disponiveis")]
        [Required(ErrorMessage = "A quantidade de produto é obrigatoria")]
        public byte ProdQtd { get; set; }

        [Display(Name = "Descrição do Produto")]
        [Required(ErrorMessage = "A descrição do produto é obrigatoria")]
        public String ProdDescription { get; set; }

        [Display(Name = "Codigo do Produto")]
        [Required(ErrorMessage = "O Codigo do produto é obrigatorio")]
        public byte ProdCode { get; set; }

        public ICollection<Size> ProdSize { get; set; }
        public ICollection<Colors> ProdColors { get; set; }
        public ICollection<Categories> ProdCat { get; set; }
    }
}