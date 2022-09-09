using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FirstMVC.Data;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class BookingController : Controller
    {
        private readonly FirstMVCContext _context;

        public BookingController(FirstMVCContext context)
        {
            _context = context;
        }

        // GET: Booking
        public async Task<IActionResult> Index()
        {
              return _context.BookingModel != null ? 
                          View(await _context.BookingModel.ToListAsync()) :
                          Problem("Entity set 'FirstMVCContext.BookingModel'  is null.");
        }

        // GET: Booking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BookingModel == null)
            {
                return NotFound();
            }

            var bookingModel = await _context.BookingModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingModel == null)
            {
                return NotFound();
            }

            return View(bookingModel);
        }

        // GET: Booking/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Qty,EventDate")] BookingModel bookingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingModel);
        }

        // GET: Booking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BookingModel == null)
            {
                return NotFound();
            }

            var bookingModel = await _context.BookingModel.FindAsync(id);
            if (bookingModel == null)
            {
                return NotFound();
            }
            return View(bookingModel);
        }

        // POST: Booking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Qty,EventDate")] BookingModel bookingModel)
        {
            if (id != bookingModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingModelExists(bookingModel.Id))
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
            return View(bookingModel);
        }

        // GET: Booking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BookingModel == null)
            {
                return NotFound();
            }

            var bookingModel = await _context.BookingModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookingModel == null)
            {
                return NotFound();
            }

            return View(bookingModel);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BookingModel == null)
            {
                return Problem("Entity set 'FirstMVCContext.BookingModel'  is null.");
            }
            var bookingModel = await _context.BookingModel.FindAsync(id);
            if (bookingModel != null)
            {
                _context.BookingModel.Remove(bookingModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingModelExists(int id)
        {
          return (_context.BookingModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
