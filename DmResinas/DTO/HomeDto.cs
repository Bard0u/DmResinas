using DmResinas.Models;

namespace DmResinas.DTO
{
    public class HomeDto
    {
        public List<Categoria> Banners { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Cor> Cores { get; set; }
        public List<ProdutoDto> Produtos { get; set; }
    }
}