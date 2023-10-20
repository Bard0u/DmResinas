using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("ProdutoAvaliacao")]
public class ProdutoAvaliacao
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required(ErrorMessage ="informe o texto da avaliação")]
    [StringLength(300, ErrorMessage ="o texto deve possuir no maximo 300 caracteres")]
    public string AvaliacaoTexto { get; set; }

    [Display(Name ="Data da Avaliação")]

    public DateTime AvaliacaoData { get; set; } = DateTime.Now;

    [Display(Name ="Nota do Produto")]
    public byte? ProdutoNota { get; set; }
}
