using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektTaiib.Models;

namespace ProjektTaiib.Controllers
{
    public class ZamowieniaController : Controller
    {
        private readonly Restauracja _context;

        public ZamowieniaController(Restauracja context)
        {
            _context = context;
        }

        // GET: Zamowienia
        public async Task<IActionResult> Index()
        {
            var restauracja = _context.zamowienie.Include(z => z.Stolik).Include(z => z.kartaDan).Include(z => z.kelner);
            return View(await restauracja.ToListAsync());
        }

        // GET: Zamowienia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.zamowienie
                .Include(z => z.Stolik)
                .Include(z => z.kartaDan)
                .Include(z => z.kelner)
                .FirstOrDefaultAsync(m => m.id == id);
            if (zamowienie == null)
            {
                return NotFound();
            }

            return View(zamowienie);
        }

        // GET: Zamowienia/Create
        public IActionResult Create()
        {
            ViewData["id_stolik"] = new SelectList(_context.stolik, "id", "id");
            ViewData["id_kartaDan"] = new SelectList(_context.kartaDan, "id", "id");
            ViewData["id_kelner"] = new SelectList(_context.kelner, "id", "id");
            return View();
        }

        // POST: Zamowienia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,id_stolik,id_kartaDan,id_kelner,data_zam")] Zamowienie zamowienie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zamowienie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["id_stolik"] = new SelectList(_context.stolik, "id", "id", zamowienie.id_stolik);
            ViewData["id_kartaDan"] = new SelectList(_context.kartaDan, "id", "id", zamowienie.id_kartaDan);
            ViewData["id_kelner"] = new SelectList(_context.kelner, "id", "id", zamowienie.id_kelner);
            return View(zamowienie);
        }

        // GET: Zamowienia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.zamowienie.FindAsync(id);
            if (zamowienie == null)
            {
                return NotFound();
            }
            ViewData["id_stolik"] = new SelectList(_context.stolik, "id", "id", zamowienie.id_stolik);
            ViewData["id_kartaDan"] = new SelectList(_context.kartaDan, "id", "id", zamowienie.id_kartaDan);
            ViewData["id_kelner"] = new SelectList(_context.kelner, "id", "id", zamowienie.id_kelner);
            return View(zamowienie);
        }

        // POST: Zamowienia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,id_stolik,id_kartaDan,id_kelner,data_zam")] Zamowienie zamowienie)
        {
            if (id != zamowienie.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zamowienie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZamowienieExists(zamowienie.id))
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
            ViewData["id_stolik"] = new SelectList(_context.stolik, "id", "id", zamowienie.id_stolik);
            ViewData["id_kartaDan"] = new SelectList(_context.kartaDan, "id", "id", zamowienie.id_kartaDan);
            ViewData["id_kelner"] = new SelectList(_context.kelner, "id", "id", zamowienie.id_kelner);
            return View(zamowienie);
        }

        // GET: Zamowienia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.zamowienie
                .Include(z => z.Stolik)
                .Include(z => z.kartaDan)
                .Include(z => z.kelner)
                .FirstOrDefaultAsync(m => m.id == id);
            if (zamowienie == null)
            {
                return NotFound();
            }

            return View(zamowienie);
        }

        // POST: Zamowienia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zamowienie = await _context.zamowienie.FindAsync(id);
            _context.zamowienie.Remove(zamowienie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZamowienieExists(int id)
        {
            return _context.zamowienie.Any(e => e.id == id);
        }
    }
}
