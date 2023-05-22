using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{
    [Table("ProductColors")]
    public class ProductColors
    {

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

        [Key, Column(Order = 2)]
        public string ColorId { get; set; }
        [ForeignKey("ColorId")]
        public Colors Colors { get; set; }

    }
}