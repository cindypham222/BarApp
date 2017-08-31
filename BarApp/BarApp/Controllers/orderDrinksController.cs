using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarApp.Models;

namespace BarApp.Controllers
{
    public class orderDrinksController : Controller
    {
        private readonly BarAppContext _context;

        public orderDrinksController(BarAppContext context)
        {
            _context = context;    
        }

        // GET: orderDrinks
        public async Task<IActionResult> Index()
        {
            return View(await _context.orderDrinks.ToListAsync());
        }

        // GET: orderDrinks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDrinks = await _context.orderDrinks
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderDrinks == null)
            {
                return NotFound();
            }

            return View(orderDrinks);
        }

        // GET: orderDrinks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: orderDrinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustomerName,DrinkName,PaidStatus,DrinkStatus")] orderDrinks orderDrinks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDrinks);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(orderDrinks);
        }

        // GET: orderDrinks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDrinks = await _context.orderDrinks.SingleOrDefaultAsync(m => m.ID == id);
            if (orderDrinks == null)
            {
                return NotFound();
            }
            return View(orderDrinks);
        }

        // POST: orderDrinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustomerName,DrinkName,PaidStatus,DrinkStatus")] orderDrinks orderDrinks)
        {
            if (id != orderDrinks.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDrinks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!orderDrinksExists(orderDrinks.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(orderDrinks);
        }

        // GET: orderDrinks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDrinks = await _context.orderDrinks
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderDrinks == null)
            {
                return NotFound();
            }

            return View(orderDrinks);
        }

        // POST: orderDrinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDrinks = await _context.orderDrinks.SingleOrDefaultAsync(m => m.ID == id);
            _context.orderDrinks.Remove(orderDrinks);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool orderDrinksExists(int id)
        {
            return _context.orderDrinks.Any(e => e.ID == id);
        }
    }
}
