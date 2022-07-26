using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopBaseballBats.Data3;
using ShopBaseballBats.Models;

namespace ShopBaseballBats.Controllers
{
    public class BatBrandController : Controller
    {
        private readonly BaseballBatContext _context;

        public BatBrandController(BaseballBatContext context)
        {
            _context = context;
        }

        // GET: BatBrand
        public async Task<IActionResult> Index()
        {
            
              return _context.BatBrands != null ? 
                          View(await _context.BatBrands.ToListAsync()) :
                          Problem("Entity set 'BaseballBatContext.BatBrands'  is null.");
        }

        // GET: BatBrand/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BatBrands == null)
            {
                return NotFound();
            }

            var batBrand = await _context.BatBrands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (batBrand == null)
            {
                return NotFound();
            }

            return View(batBrand);
        }

        // GET: BatBrand/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BatBrand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Length,Weight,Price,BrandName,ModelNames,DescriptionHtml,Cart")] BatBrand batBrand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(batBrand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(batBrand);
        }

        // GET: BatBrand/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BatBrands == null)
            {
                return NotFound();
            }

            var batBrand = await _context.BatBrands.FindAsync(id);
            if (batBrand == null)
            {
                return NotFound();
            }
            return View(batBrand);
        }

        // POST: BatBrand/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Length,Weight,Price,BrandName,ModelNames,DescriptionHtml,Cart")] BatBrand batBrand)
        {
            if (id != batBrand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(batBrand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BatBrandExists(batBrand.Id))
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
            return View(batBrand);
        }

        // GET: BatBrand/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BatBrands == null)
            {
                return NotFound();
            }

            var batBrand = await _context.BatBrands
                .FirstOrDefaultAsync(m => m.Id == id);
            if (batBrand == null)
            {
                return NotFound();
            }

            return View(batBrand);
        }

        // POST: BatBrand/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BatBrands == null)
            {
                return Problem("Entity set 'BaseballBatContext.BatBrands'  is null.");
            }
            var batBrand = await _context.BatBrands.FindAsync(id);
            if (batBrand != null)
            {
                _context.BatBrands.Remove(batBrand);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BatBrandExists(int id)
        {
          return (_context.BatBrands?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
