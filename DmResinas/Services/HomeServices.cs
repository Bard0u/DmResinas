using DmResinas.Data;
using DmResinas.DTO;
using Microsoft.EntityFrameworkCore;

namespace DmResinas.Services;

    public class HomeService : IHomeService{
    private readonly AppDbContext _contexto;
    private readonly IProdutoService _produtoService;

    public HomeService(AppDbContext contexto, IProdutoService produtoService)
    {
        _contexto = contexto;
        _produtoService = produtoService;
    }

    public async Task<HomeDto> GetIndexData()
    {
        HomeDto home = new() {
            Banners = await _contexto.Categorias.Where(c => c.Banner).ToListAsync(),
            Categorias = await _contexto.Categorias.Where(c => c.Filtrar).ToListAsync(),
            Cores = await _contexto.Cores.OrderBy(c => c.Id).ToListAsync(),
            Produtos = await _produtoService.GetProdutos()
        };
        return home;
    }
}