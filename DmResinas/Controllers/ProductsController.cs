using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DmResinas.Data;
using DmResinas.Models;

namespace DmResinas.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductsController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }
            var Product = await _context.Product
                .Where(m => m.ProdId == id)
                .Include(m => m.Categories).ThenInclude(g => g.Categories)
                .SingleOrDefaultAsync();
            if (Product == null)
            {
                return NotFound();
            }
            return View(Product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["Categories"] = new MultiSelectList(_context.Categorie.OrderBy(t => t.CategorieName), "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,OriginalTitle,Synopsis,ProductYear,Duration,AgeRating,Image")] Products Product, IFormFile formFile, List<string> Categories)
        {
            if (ModelState.IsValid)
            {
                // Salva o Filme
                _context.Add(Product);
                await _context.SaveChangesAsync();

                // Se tiver arquivo de imagem, salva a imagem no servidor com o ID do filme e adiciona o nome e caminho da imagem no banco
                if (formFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Images.ImageId.ToString("00") + Path.GetExtension(formFile.FileName);
                    string uploads = Path.Combine(wwwRootPath, @"img\movies");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                    movie.Image = @"\img\movies\" + fileName;
                    await _context.SaveChangesAsync();
                }

                // Salva, se tiver, os Gêneros selecionados
                Product.Categories = new List<ProductCategories>();
                foreach (var Categorie in Categories)
                {
                    Product.Categories.Add(new ProductCategories()
                    {
                        CategorieId = byte.Parse(Categorie),
                        ProdId = Product.ProdId
                    });
                }
                if (Categories.Count > 0) await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["Categories"] = new MultiSelectList(_context.Categorie.OrderBy(t => t.CategorieName), "Id", "Name");
            return View(Product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }
            var Product = await _context.Product
                .Where(m => m.ProdId == id)
                .Include(m => m.Categories).ThenInclude(g => g.Categories)
                .SingleOrDefaultAsync();
            if (Product == null)
            {
                return NotFound();
            }
            var x = new MultiSelectList(_context.Categorie.OrderBy(t => t.CategorieName), "Id", "Name", Product.Categories.Select(g => g.Categories.CategoriesId.ToString()));
            ViewData["Categories"] = x;
            return View(Product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,OriginalTitle,Synopsis,ProductYear,Duration,AgeRating,Image")] Products Product, IFormFile formFile, List<string> Categories)
        {
            if (id != Product.ProdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Atualiza a Foto de Capa
                    if (formFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        if (Product.Images != null)
                        {
                            string oldFile = Path.Combine(wwwRootPath, Product.Images.TrimStart('\\'));
                            if (System.IO.File.Exists(oldFile))
                            {
                                System.IO.File.Delete(oldFile);
                            }
                        }

                        string fileName = Product.ProdId.ToString("00") + Path.GetExtension(formFile.FileName);
                        string uploads = Path.Combine(wwwRootPath, @"img\pokemons");
                        string newFile = Path.Combine(uploads, fileName);
                        using (var stream = new FileStream(newFile, FileMode.Create))
                        {
                            formFile.CopyTo(stream);
                        }
                        Product.Images = @"\img\Products\" + fileName;
                    }
                    Product.Categories = _context.ProductCategorie.Where(mg => mg.ProdId == Product.ProdId).OrderBy(mg => mg.CategorieId).ToList();
                    _context.Update(Product);
                    _context.RemoveRange(Product.Categories);
                    await _context.SaveChangesAsync();

                    // Adiciona os Gêneros do Filme
                    Categories.ForEach(g => _context.ProductCategorie.Add(
                        new ProductCategories()
                        {
                            ProdId = Product.ProdId,
                            CategorieId = byte.Parse(g)
                        }
                    ));
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(Product.ProdId))
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
            ViewData["Categories"] = new SelectList(_context.Categorie.OrderBy(t => t.CategorieName), "Id", "Name");
            return View(Product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var Product = await _context.Product
                .Where(m => m.ProdId == id)
                .Include(m => m.Categories).ThenInclude(g => g.Categories)
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
            if (_context.Product == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var Product = await _context.Product.FindAsync(id);
            if (Product != null)
            {
                var ProductCategories = await _context.ProductCategorie.Where(mg => mg.ProdId == id).ToListAsync();
                _context.ProductCategorie.RemoveRange(ProductCategories);
                _context.Product.Remove(Product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProdId == id);
        }
    }
}
