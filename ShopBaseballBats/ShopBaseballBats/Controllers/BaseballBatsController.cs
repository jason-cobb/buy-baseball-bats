using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Data2;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.Controllers
{
    public class BaseballBatsController : Controller
    {
        private readonly BaseballBatContext _context;

        public BaseballBatsController(BaseballBatContext context)
        {
            _context = context;
        }

        // GET: BaseballBats
        public async Task<IActionResult> Index()
        {
              return _context.BaseballBats != null ? 
                          View(await _context.BaseballBats.ToListAsync()) :
                          Problem("Entity set 'BaseballBatContext.BaseballBats'  is null.");
        }

        // GET: BaseballBats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BaseballBats == null)
            {
                return NotFound();
            }

            var baseballBats = await _context.BaseballBats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseballBats == null)
            {
                return NotFound();
            }

            return View(baseballBats);
        }

        // GET: BaseballBats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BaseballBats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( BaseballBats baseballBats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(baseballBats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(baseballBats);
        }

        // GET: BaseballBats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BaseballBats == null)
            {
                return NotFound();
            }

            var baseballBats = await _context.BaseballBats.FindAsync(id);
            if (baseballBats == null)
            {
                return NotFound();
            }
            return View(baseballBats);
        }

        // POST: BaseballBats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  BaseballBats baseballBats)
        {
            if (id != baseballBats.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baseballBats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseballBatsExists(baseballBats.Id))
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
            return View(baseballBats);
        }

        // GET: BaseballBats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BaseballBats == null)
            {
                return NotFound();
            }

            var baseballBats = await _context.BaseballBats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (baseballBats == null)
            {
                return NotFound();
            }

            return View(baseballBats);
        }

        // POST: BaseballBats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BaseballBats == null)
            {
                return Problem("Entity set 'BaseballBatContext.BaseballBats'  is null.");
            }
            var baseballBats = await _context.BaseballBats.FindAsync(id);
            if (baseballBats != null)
            {
                _context.BaseballBats.Remove(baseballBats);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaseballBatsExists(int id)
        {
          return (_context.BaseballBats?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
