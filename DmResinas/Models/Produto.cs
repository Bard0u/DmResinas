using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DmResinas.Models;

[Table("Produto")]

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição resumida")]
    [StringLength(300, ErrorMessage = "A Descrição resumida deve possuir no maximo 300 caracteres")]
    public string Descricaoresumida { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(8000, ErrorMessage = "A Descrição  deve possuir no maximo 8000 caracteres")]
    public string Descricao { get; set; }

    [StringLength(10, ErrorMessage = "o SKU deve possuir no maximo 10 caracteres")]
    public string SKU { get; set; }

    [Display(Name = "preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage ="Informe o preço de venda")]
    public decimal Preco { get; set; }

    [Display(Name = "Produto em Destaque?")]
    public bool Destaque { get; set;}= false;

    [Column(TypeName ="decimal(6,3)")]
    public decimal Peso { get; set;} = 0;

    [StringLength(30, ErrorMessage ="O material deve possuir mo naximo 30 caracteres")]
    public string Material { get; set; }

    [Display(Name = "Dimensões")]
    [StringLength(20, ErrorMessage = "A Dimensão deve possuir no maximo 20 caracteres")]
    public string Dimensao { get; set; }



    public ICollection<ProdutoAvaliacao> Avaliacoes { get; set; }
    public ICollection<ProdutoCategoria> Categorias { get; set; }
}