using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DmResinas.Models;
using DmResinas.Data;
using Microsoft.EntityFrameworkCore;
using DmResinas.DTO;

namespace DmResinas.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index(int? id)
    {
        var produtos = _context.Produtos.Include(pc => pc.Categorias).ThenInclude(c => c.Categoria).ToList();
        _context.Produtos.Include(po => po.Cores).ThenInclude(c => c.Cor).ToList();
        return View(produtos);
    }
    public IActionResult Produto(int? id)
    {
        var produto = _context.Produtos
                   .Where(p => p.Id == id)
                   .Include(p => p.Categorias)
                   .ThenInclude(c => c.Categoria)
                   .Include(p => p.Cores)
                   .SingleOrDefault();
        return View(produto);
    }
    public IActionResult Catalogo(int? id)
    {
        CatalogoDto catalogo = new() {
            Categorias = _context.Categorias.ToList(),
            Produtos = _context.Produtos.Include(t => t.Categorias).ToList()
        };
        return View(catalogo);
    }
    public IActionResult Dicas()
    {
        return View();
    }
    public IActionResult Sobre()
    {
        return View();
    }
    public IActionResult Perfil()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


