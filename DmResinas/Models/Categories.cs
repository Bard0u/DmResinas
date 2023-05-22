using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public byte CategoriesId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome da categoria é obrigatorio")]
        [StringLength(30, ErrorMessage = "O nome da categoria deve possuir no maximo 30 caracteres")]
        public string CategorieName { get; set; }

        public ICollection<ProductCategories> Products { get; set; }


    }
}