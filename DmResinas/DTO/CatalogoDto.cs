using DmResinas.Models;

namespace DmResinas.DTO;

public class CatalogoDto
{
    public List<Categoria> Categorias { get; set; }
    public List<Produto> Produtos { get; set; }
}
