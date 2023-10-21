using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DmResinas.Data;
using DmResinas.Models;

namespace DmResinas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutosController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }
            var Produto = await _context.Produtos
                .Where(p => p.Id == id)
                .Include(p => p.Categorias).ThenInclude(c => c.Categoria)
                .SingleOrDefaultAsync();
            if (Produto == null)
            {
                return NotFound();
            }
            return View(Produto);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,OriginalTitle,Synopsis,ProductYear,Duration,AgeRating,Image")] Produto Produtos, IFormFile formFile, List<string> Categorias)
        {
            if (ModelState.IsValid)
            {
                // Salva o Filme
                _context.Add(Produtos);
                await _context.SaveChangesAsync();

                // Se tiver arquivo de imagem, salva a imagem no servidor com o ID do filme e adiciona o nome e caminho da imagem no banco
             

                // Salva, se tiver, os Gêneros selecionados
                Produtos.Categorias = new List<ProdutoCategoria>();
                foreach (var Categoria in Categorias)
                {
                    Produtos.Categorias.Add(new ProdutoCategoria()
                    {
                        CategoriaId = byte.Parse(Categoria),
                        ProdutoId = Produtos.Id
                    });
                }
                if (Categorias.Count > 0) await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["Categoria"] = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name");
            return View(Produtos);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }
            var Produtos = await _context.Produtos
                .Where(p =>p.Id == id)
                .Include(p =>p .Categorias).ThenInclude(g => g.Categoria)
                .SingleOrDefaultAsync();
            if (Produtos == null)
            {
                return NotFound();
            }
            var x = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name", Produtos.Categorias.Select(g => g.Categoria.Id.ToString()));
            ViewData["Categories"] = x;
            return View(Produtos);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Image")] Produto Produto, IFormFile formFile, List<string> Categorias)
        {
            if (id != Produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Atualiza a Foto de Capa
                   
                    Produto.Categorias = _context.ProdutoCategorias.Where(pc => pc.ProdutoId == Produto.Id).OrderBy(ca => ca.CategoriaId).ToList();
                    _context.Update(Produto);
                    _context.RemoveRange(Produto.Categorias);
                    await _context.SaveChangesAsync();

                    // Adiciona os Gêneros do Filme
                    Categorias.ForEach(g => _context.ProdutoCategorias.Add(
                        new ProdutoCategoria()
                        {
                            ProdutoId = Produto.Id,
                            CategoriaId = byte.Parse(g)
                        }
                    ));
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(Produto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Categories"] = new SelectList(_context.Categorias.OrderBy(n => n.Nome), "Id", "Name");
            return View(Produto);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var Product = await _context.Produtos
                .Where(p => p.Id == id)
                .Include(p => p.Categorias).ThenInclude(c => c.Categoria)
                .SingleOrDefaultAsync();
            if (Product == null)
            {
                return NotFound();
            }

            return View(Product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var Produto = await _context.Produtos.FindAsync(id);
            if (Produto != null)
            {
                var ProdutoCategorias = await _context.ProdutoCategorias.Where(p => p.ProdutoId == id).ToListAsync();
                _context.ProdutoCategorias.RemoveRange(ProdutoCategorias);
                _context.Produtos.Remove(Produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
