using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("Tamanho")]

public class Tamanho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe a Sigla")]
    [StringLength(5, ErrorMessage = "A Sigla deve possuir no maximo 5 caracteres")]
    public string Sigla { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O nome deve possuir no maximo 30 caracteres")]
    public string Nome { get; set; }
}
