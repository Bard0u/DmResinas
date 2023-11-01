using DmResinas.Data;
using DmResinas.Models;
using DmResinas.DTO;
using Microsoft.EntityFrameworkCore;

namespace DmResinas.Services;

public class ProdutoService : IProdutoService
{
    private readonly AppDbContext _contexto;
    public ProdutoService(AppDbContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<List<ProdutoDto>> GetProdutos()
    {
        var produtos = await
            (from produto in _contexto.Produtos
            let categorias =
                (from prodCategoria in _contexto.ProdutoCategorias
                join categoria in _contexto.Categorias on prodCategoria.CategoriaId equals categoria.Id
                where prodCategoria.ProdutoId == produto.Id
                select categoria.Nome).ToList()
            let fotos =
                (from prodFoto in _contexto.ProdutoFotos
                where prodFoto.ProdutoId == produto.Id
                orderby prodFoto.Destaque
                select prodFoto.ArquivoFoto).ToList()
            select new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = "R$ " + produto.Preco.ToString("N2"),
                Categorias = categorias,
                Fotos = fotos
            }).ToListAsync();
        return produtos;
    }
}