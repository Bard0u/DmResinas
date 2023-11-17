using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DmResinas.Models;
using DmResinas.Data;
using Microsoft.EntityFrameworkCore;

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

    public IActionResult Index()
    {
        var products = _context.ProdutoCategorias.Include(pc => pc.Produto).ThenInclude(c => c.Categorias).ToList();
        _context.ProdutoCores.Include(po => po.Produto).ThenInclude(c => c.Cores).ToList();
        return View(products);
    }
    public IActionResult Catalogo()
    {
        return View();
    }
    public IActionResult Contato()
    {
        return View();
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


