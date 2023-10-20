using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DmResinas.Data;
using DmResinas.Models;

namespace DmResinas.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
              return View(await _context.Categorias.ToListAsync());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(byte? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var Categorias = await _context.Categorias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Categorias == null)
            {
                return NotFound();
            }

            return View(Categorias);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriasId,CategoriaName")] Categoria Categorias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Categorias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Categorias);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var Categorias = await _context.Categorias.FindAsync(id);
            if (Categorias == null)
            {
                return NotFound();
            }
            return View(Categorias);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("CategoriasId,CategoriaName")] Categoria Categorias)
        {
            if (id != Categorias.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Categorias);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriasExists(Categorias.Id))
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
            return View(Categorias);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var Categorias = await _context.Categorias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Categorias == null)
            {
                return NotFound();
            }

            return View(Categorias);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Categorias == null)
            {
                return Problem("Entity set 'AppDbContext.Categoria'  is null.");
            }
            var Categorias = await _context.Categorias.FindAsync(id);
            if (Categorias != null)
            {
                _context.Categorias.Remove(Categorias);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriasExists(byte id)
        {
          return _context.Categorias.Any(e => e.Id == id);
        }
    }
}
