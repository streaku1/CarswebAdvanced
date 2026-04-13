using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carsweb.Data;
using Carsweb.Models;

namespace Carsweb.Controllers
{
    public class DealersController : Controller
    {
        private readonly AppDbContext _context;

        public DealersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Dealers.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealer = await _context.Dealers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealer == null)
            {
                return NotFound();
            }

            return View(dealer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Location")] Dealer dealer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dealer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dealer);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealer = await _context.Dealers.FindAsync(id);
            if (dealer == null)
            {
                return NotFound();
            }
            return View(dealer);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Location")] Dealer dealer)
        {
            if (id != dealer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dealer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DealerExists(dealer.Id))
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
            return View(dealer);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealer = await _context.Dealers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealer == null)
            {
                return NotFound();
            }

            return View(dealer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dealer = await _context.Dealers.FindAsync(id);
            if (dealer != null)
            {
                _context.Dealers.Remove(dealer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DealerExists(int id)
        {
            return _context.Dealers.Any(e => e.Id == id);
        }
    }
}
