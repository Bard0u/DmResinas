using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("Colors")]
public class Colors
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //Coloca automático a chave primária
    public byte CorId { get; set; }
    [Display(Name = "Nome das cores")]
    //Display é o que aparece na tela para o usuário e não está ligado ao banco

    [Required(ErrorMessage = "Você precisa de pelo menos uma cor cadastrada")]
    //Required é usado quando algo é obrigado
    public string ColorName { get; set; }

        [Display(Name = "Código das cores(padrão hexa)")]
    //Display é o que aparece na tela para o usuário e não está ligado ao banco

    [Required(ErrorMessage = "Você precisa do codigo das cores")]
    public string ColorCode { get; set; }
}