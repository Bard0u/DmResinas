using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("Cor")]
public class Cor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no maximo 30 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe o Código Da Cor")]
    [StringLength(7, ErrorMessage = "O Código deve possuir no maximo 7 caracteres")]
    public string CodigoHexa { get; set; }
    public ICollection<ProdutoCor> Produtos { get; set; }
}
