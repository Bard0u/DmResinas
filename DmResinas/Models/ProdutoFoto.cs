using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DmResinas.Models;

public class ProdutoFoto
{
    [Key, Column(Order = 1)]
    public int Id { get; set; }

    [Key, Column(Order = 2)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Required]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }

    [Display(Name ="Foto de destaque?")]

    public bool Destaque { get; set; } = false;
}
