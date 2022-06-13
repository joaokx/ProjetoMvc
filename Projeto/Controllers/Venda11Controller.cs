using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class Venda11Controller : Controller
    {
        private readonly Contexto _context;

        public Venda11Controller(Contexto context)
        {
            _context = context;
        }

        // GET: Venda11
        public async Task<IActionResult> Index()
        {
              return _context.Venda1 != null ? 
                          View(await _context.Venda1.ToListAsync()) :
                          Problem("Entity set 'Contexto.Venda1'  is null.");
        }

        // GET: Venda11/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Venda1 == null)
            {
                return NotFound();
            }

            var venda1 = await _context.Venda1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda1 == null)
            {
                return NotFound();
            }

            return View(venda1);
        }

        // GET: Venda11/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Venda11/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Clientes,Produto,Quantidade,Unitario,Data,ValorTotal")] Venda1 venda1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venda1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venda1);
        }

        // GET: Venda11/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Venda1 == null)
            {
                return NotFound();
            }

            var venda1 = await _context.Venda1.FindAsync(id);
            if (venda1 == null)
            {
                return NotFound();
            }
            return View(venda1);
        }

        // POST: Venda11/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Clientes,Produto,Quantidade,Unitario,Data,ValorTotal")] Venda1 venda1)
        {
            if (id != venda1.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venda1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Venda1Exists(venda1.Id))
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
            return View(venda1);
        }

        // GET: Venda11/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Venda1 == null)
            {
                return NotFound();
            }

            var venda1 = await _context.Venda1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venda1 == null)
            {
                return NotFound();
            }

            return View(venda1);
        }

        // POST: Venda11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Venda1 == null)
            {
                return Problem("Entity set 'Contexto.Venda1'  is null.");
            }
            var venda1 = await _context.Venda1.FindAsync(id);
            if (venda1 != null)
            {
                _context.Venda1.Remove(venda1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Venda1Exists(int id)
        {
          return (_context.Venda1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
