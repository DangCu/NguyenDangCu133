using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NDC0133.Data;
using NguyenDangCu133.Models;

namespace NguyenDangCu133.Controllers
{
    public class NDC0133Controller : Controller
    {
        private readonly NDC0133Context _context;

        public NDC0133Controller(NDC0133Context context)
        {
            _context = context;
        }

        // GET: NDC0133
        public async Task<IActionResult> Index()
        {
            return View(await _context.NDC0133.ToListAsync());
        }

        // GET: NDC0133/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nDC0133 = await _context.NDC0133
                .FirstOrDefaultAsync(m => m.NDCid == id);
            if (nDC0133 == null)
            {
                return NotFound();
            }

            return View(nDC0133);
        }

        // GET: NDC0133/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NDC0133/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NDCid,NDCname,NDCGender")] NDC0133 nDC0133)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nDC0133);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nDC0133);
        }

        // GET: NDC0133/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nDC0133 = await _context.NDC0133.FindAsync(id);
            if (nDC0133 == null)
            {
                return NotFound();
            }
            return View(nDC0133);
        }

        // POST: NDC0133/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NDCid,NDCname,NDCGender")] NDC0133 nDC0133)
        {
            if (id != nDC0133.NDCid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nDC0133);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NDC0133Exists(nDC0133.NDCid))
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
            return View(nDC0133);
        }

        // GET: NDC0133/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nDC0133 = await _context.NDC0133
                .FirstOrDefaultAsync(m => m.NDCid == id);
            if (nDC0133 == null)
            {
                return NotFound();
            }

            return View(nDC0133);
        }

        // POST: NDC0133/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nDC0133 = await _context.NDC0133.FindAsync(id);
            _context.NDC0133.Remove(nDC0133);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NDC0133Exists(int id)
        {
            return _context.NDC0133.Any(e => e.NDCid == id);
        }
    }
}
