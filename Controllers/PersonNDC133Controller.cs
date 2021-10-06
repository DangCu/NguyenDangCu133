using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenDangCu133.Data;
using NguyenDangCu133.Models;

namespace NguyenDangCu133.Controllers
{
    public class PersonNDC133Controller : Controller
    {
        private readonly NguyenDangCu133Context _context;

        public PersonNDC133Controller(NguyenDangCu133Context context)
        {
            _context = context;
        }

        // GET: PersonNDC133
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNDC133.ToListAsync());
        }

        // GET: PersonNDC133/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNDC133 = await _context.PersonNDC133
                .FirstOrDefaultAsync(m => m.PerSonID == id);
            if (personNDC133 == null)
            {
                return NotFound();
            }

            return View(personNDC133);
        }

        // GET: PersonNDC133/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNDC133/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PerSonID,PerSonName")] PersonNDC133 personNDC133)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNDC133);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNDC133);
        }

        // GET: PersonNDC133/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNDC133 = await _context.PersonNDC133.FindAsync(id);
            if (personNDC133 == null)
            {
                return NotFound();
            }
            return View(personNDC133);
        }

        // POST: PersonNDC133/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PerSonID,PerSonName")] PersonNDC133 personNDC133)
        {
            if (id != personNDC133.PerSonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNDC133);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNDC133Exists(personNDC133.PerSonID))
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
            return View(personNDC133);
        }

        // GET: PersonNDC133/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNDC133 = await _context.PersonNDC133
                .FirstOrDefaultAsync(m => m.PerSonID == id);
            if (personNDC133 == null)
            {
                return NotFound();
            }

            return View(personNDC133);
        }

        // POST: PersonNDC133/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personNDC133 = await _context.PersonNDC133.FindAsync(id);
            _context.PersonNDC133.Remove(personNDC133);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNDC133Exists(int id)
        {
            return _context.PersonNDC133.Any(e => e.PerSonID == id);
        }
    }
}
