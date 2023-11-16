using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("ProdutoCor")]
public class ProdutoCor
{

    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public byte CorId { get; set; }
    [ForeignKey("CorId")]
    public Cor Cor { get; set; }
}
