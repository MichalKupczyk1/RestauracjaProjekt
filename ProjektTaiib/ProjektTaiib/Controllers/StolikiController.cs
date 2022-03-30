using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektTaiib.Models;
using ProjektTaiib.MS;

namespace ProjektTaiib.Controllers
{
    public class StolikiController : Controller
    {
        private readonly Restauracja _context;

        public StolikiController(Restauracja context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexMs(int id) {
            ViewBag.Zaznacz = id;
            Baza baza = new Baza();
            
            baza.StolikMS = _context.stolik.ToList();
            
            baza.ZaznaczonyId = id;
            return View(baza);
        }
        // GET: Stoliki
        public async Task<IActionResult> Index()
        {
            return View(await _context.stolik.ToListAsync());
        }

        // GET: Stoliki/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stolik = await _context.stolik
                .FirstOrDefaultAsync(m => m.id == id);
            if (stolik == null)
            {
                return NotFound();
            }

            return View(stolik);
        }

        // GET: Stoliki/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stoliki/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ileMiejsc,czyZajety,czyObsluzony")] Stolik stolik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stolik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stolik);
        }

        // GET: Stoliki/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stolik = await _context.stolik.FindAsync(id);
            if (stolik == null)
            {
                return NotFound();
            }
            return View(stolik);
        }

        // POST: Stoliki/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ileMiejsc,czyZajety,czyObsluzony")] Stolik stolik)
        {
            if (id != stolik.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stolik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StolikExists(stolik.id))
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
            return View(stolik);
        }

        // GET: Stoliki/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stolik = await _context.stolik
                .FirstOrDefaultAsync(m => m.id == id);
            if (stolik == null)
            {
                return NotFound();
            }

            return View(stolik);
        }

        // POST: Stoliki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stolik = await _context.stolik.FindAsync(id);
            _context.stolik.Remove(stolik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StolikExists(int id)
        {
            return _context.stolik.Any(e => e.id == id);
        }
    }
}
