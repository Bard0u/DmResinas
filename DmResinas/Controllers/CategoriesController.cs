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
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
              return View(await _context.Categorias.ToListAsync());
        }

        // GET: Categories/Details/5
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

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] Categoria Categorias)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Categorias);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Categorias);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(byte? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var Categoria = await _context.Categorias.FindAsync(id);
            if (Categoria == null)
            {
                return NotFound();
            }
            return View(Categoria);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(byte id, [Bind("CategoriesId,CategorieName")] Categoria Categorias)
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
                    if (!CategoriesExists(Categorias.Id))
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

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(byte? id)
        {
            if (id == null || _context.Categorias == null)
            {
                return NotFound();
            }

            var categorias = await _context.Categorias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorias == null)
            {
                return NotFound();
            }

            return View(categorias);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(byte id)
        {
            if (_context.Categorias == null)
            {
                return Problem("Entity set 'AppDbContext.Categorie'  is null.");
            }
            var categorias = await _context.Categorias.FindAsync(id);
            if (categorias != null)
            {
                _context.Categorias.Remove(categorias);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriesExists(byte id)
        {
          return _context.Categorias.Any(e => e.Id == id);
        }
    }
}
