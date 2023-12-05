using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DmResinas.Data;
using DmResinas.Models;
using Microsoft.AspNetCore.Authorization;

namespace DmResinas.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class CoresController : Controller
    {
        private readonly AppDbContext _context;

        public CoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cores
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cores.ToListAsync());
        }

        // GET: Cores/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null || _context.Cores == null)
            {
                return NotFound();
            }

            var Cores = await _context.Cores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Cores == null)
            {
                return NotFound();
            }

            return View(Cores);
        }

        // GET: Cores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,CodigoHexa")] Cor Cores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Cores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Cores);
        }

        // GET: Cores/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Cores == null)
            {
                return NotFound();
            }

            var Cor = await _context.Cores.FindAsync(id);
            if (Cor == null)
            {
                return NotFound();
            }
            return View(Cor);
        }

        // POST: Cores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("Id,Nome,CodigoHexa")] Cor Cores)
        {
            if (id != Cores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Cores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoresExists(Cores.Id))
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
            return View(Cores);
        }

        // GET: Cores/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Cores == null)
            {
                return NotFound();
            }

            var Cores = await _context.Cores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Cores == null)
            {
                return NotFound();
            }

            return View(Cores);
        }

        // POST: Cores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Cores == null)
            {
                return Problem("Entity set 'AppDbContext.Categorie'  is null.");
            }
            var Cores = await _context.Cores.FindAsync(id);
            if (Cores != null)
            {
                _context.Cores.Remove(Cores);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoresExists(byte id)
        {
          return _context.Cores.Any(e => e.Id == id);
        }
    }
}
