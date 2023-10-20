using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DmResinas.Data;
using DmResinas.Models;

namespace DmResinas.Controllers
{
    public class ProdutossController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutossController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Produtoss
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: Produtoss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }
            var Produtos = await _context.Produtos
                .Where(p => p.Id == id)
                .Include(c => c.Categorias).ThenInclude(c => c.Categoria)
                .SingleOrDefaultAsync();
            if (Produtos == null)
            {
                return NotFound();
            }
            return View(Produtos);
        }

        // GET: Produtoss/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name");
            return View();
        }

        // POST: Produtoss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descrição,Image")] Produto Produtos, IFormFile formFile, List<string> Categorias)
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
            ViewData["Categories"] = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name");
            return View(Produtos);
        }

        // GET: Produtoss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }
            var Produtos = await _context.Produtos
                .Where(m => m.Id == id)
                .Include(m => m.Categorias).ThenInclude(g => g.Categoria)
                .SingleOrDefaultAsync();
            if (Produtos == null)
            {
                return NotFound();
            }
            var x = new MultiSelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name", Produtos.Categorias.Select(g => g.Categoria.Id.ToString()));
            ViewData["Categorias"] = x;
            return View(Produtos);
        }

        // POST: Produtoss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Descriçao,Image")] Produto Produtos, IFormFile formFile, List<string> Categories)
        {
            if (id != Produtos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Atualiza a Foto de Capa
                   
                    Produtos.Categorias = _context.ProdutoCategorias.Where(pr => pr.ProdutoId == Produtos.Id).OrderBy(pr => pr.CategoriaId).ToList();
                    _context.Update(Produtos);
                    _context.RemoveRange(Produtos.Categorias);
                    await _context.SaveChangesAsync();

                    // Adiciona os Gêneros do Filme
                    Categories.ForEach(g => _context.ProdutoCategorias.Add(
                        new ProdutoCategoria()
                        {
                            ProdutoId = Produtos.Id,
                            CategoriaId = byte.Parse(g)
                        }
                    ));
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutosExists(Produtos.Id))
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
            ViewData["Categories"] = new SelectList(_context.Categorias.OrderBy(t => t.Nome), "Id", "Name");
            return View(Produtos);
        }

        // GET: Produtoss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var Produtos = await _context.Produtos
                .Where(p => p.Id == id)
                .Include(p => p.Categorias).ThenInclude(c => c.Categoria)
                .SingleOrDefaultAsync();
            if (Produtos == null)
            {
                return NotFound();
            }

            return View(Produtos);
        }

        // POST: Produtoss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'AppDbContext.Produtoss'  is null.");
            }
            var Produtos = await _context.Produtos.FindAsync(id);
            if (Produtos != null)
            {
                var ProdutoCategoria = await _context.ProdutoCategorias.Where(pr => pr.ProdutoId == id).ToListAsync();
                _context.ProdutoCategorias.RemoveRange(ProdutoCategoria);
                _context.Produtos.Remove(Produtos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutosExists(int id)
        {
            return _context.Produtos.Any(p => p.Id == id);
        }
    }
}
