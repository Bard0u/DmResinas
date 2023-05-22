using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{
    [Table("ProductCategories")]
    public class ProductCategories
    {
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

        [Key, Column(Order = 2)]
        public string CategorieId { get; set; }
        [ForeignKey("CategorieId")]
        public Categories Categorie { get; set; }
    }
}