using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models
{
    [Table("ProductImages")]
    public class ProductImages
    {

        [Key, Column(Order = 1)]
        public int ProdId { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

        [Key, Column(Order = 2)]
        public byte ImageId { get; set; }
        [ForeignKey("ColorId")]
        public Images Images { get; set; }

    }
}