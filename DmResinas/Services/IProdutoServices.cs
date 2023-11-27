using DmResinas.DTO;

namespace DmResinas.Services;

public interface IProdutoService
{
    Task<List<ProdutoDto>> GetProdutos();
}