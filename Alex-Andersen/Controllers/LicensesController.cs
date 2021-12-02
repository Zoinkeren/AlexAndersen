using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Alex_Andersen.Models;

namespace Alex_Andersen.Controllers
{
    public class LicensesController : Controller
    {
        private readonly EFContext _context;

        public LicensesController(EFContext context)
        {
            _context = context;
        }

        // GET: Licenses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Licenses.ToListAsync());
        }

        // GET: Licenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenses = await _context.Licenses
                .FirstOrDefaultAsync(m => m.LicenseID == id);
            if (licenses == null)
            {
                return NotFound();
            }

            return View(licenses);
        }

        // GET: Licenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Licenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LicenseID,LicenseName")] Licenses licenses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licenses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licenses);
        }

        // GET: Licenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenses = await _context.Licenses.FindAsync(id);
            if (licenses == null)
            {
                return NotFound();
            }
            return View(licenses);
        }

        // POST: Licenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LicenseID,LicenseName")] Licenses licenses)
        {
            if (id != licenses.LicenseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licenses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicensesExists(licenses.LicenseID))
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
            return View(licenses);
        }

        // GET: Licenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenses = await _context.Licenses
                .FirstOrDefaultAsync(m => m.LicenseID == id);
            if (licenses == null)
            {
                return NotFound();
            }

            return View(licenses);
        }

        // POST: Licenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var licenses = await _context.Licenses.FindAsync(id);
            _context.Licenses.Remove(licenses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicensesExists(int id)
        {
            return _context.Licenses.Any(e => e.LicenseID == id);
        }
    }
}
