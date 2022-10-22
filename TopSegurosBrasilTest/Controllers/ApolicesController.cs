using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TopSegurosBrasil.Data;
using TopSegurosBrasil.Models;

namespace TopSegurosBrasil.Controllers
{
    public class ApolicesController : Controller
    {
        private readonly TopSegurosBrasilContext _context;

        public ApolicesController(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        // GET: Apolices
        public async Task<IActionResult> Index()
        {
            var topSegurosBrasilContext = _context.Apolice.Include(a => a.PlanoDoSeguro);
            return View(await topSegurosBrasilContext.ToListAsync());
        }

        // GET: Apolices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Apolice == null)
            {
                return NotFound();
            }

            var apolice = await _context.Apolice
                .Include(a => a.PlanoDoSeguro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apolice == null)
            {
                return NotFound();
            }

            return View(apolice);
        }

        // GET: Apolices/Create
        public IActionResult Create()
        {
            ViewData["PlanoDoSeguroId"] = new SelectList(_context.Set<PlanoDoSeguro>(), "Id", "Id");
            return View();
        }

        // POST: Apolices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataInicioContrato,DataVencimento,VeiculoId,PlanoDoSeguroId")] Apolice apolice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(apolice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlanoDoSeguroId"] = new SelectList(_context.Set<PlanoDoSeguro>(), "Id", "Id", apolice.PlanoDoSeguroId);
            return View(apolice);
        }

        // GET: Apolices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Apolice == null)
            {
                return NotFound();
            }

            var apolice = await _context.Apolice.FindAsync(id);
            if (apolice == null)
            {
                return NotFound();
            }
            ViewData["PlanoDoSeguroId"] = new SelectList(_context.Set<PlanoDoSeguro>(), "Id", "Id", apolice.PlanoDoSeguroId);
            return View(apolice);
        }

        // POST: Apolices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataInicioContrato,DataVencimento,VeiculoId,PlanoDoSeguroId")] Apolice apolice)
        {
            if (id != apolice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(apolice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApoliceExists(apolice.Id))
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
            ViewData["PlanoDoSeguroId"] = new SelectList(_context.Set<PlanoDoSeguro>(), "Id", "Id", apolice.PlanoDoSeguroId);
            return View(apolice);
        }

        // GET: Apolices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Apolice == null)
            {
                return NotFound();
            }

            var apolice = await _context.Apolice
                .Include(a => a.PlanoDoSeguro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (apolice == null)
            {
                return NotFound();
            }

            return View(apolice);
        }

        // POST: Apolices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Apolice == null)
            {
                return Problem("Entity set 'TopSegurosBrasilContext.Apolice'  is null.");
            }
            var apolice = await _context.Apolice.FindAsync(id);
            if (apolice != null)
            {
                _context.Apolice.Remove(apolice);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApoliceExists(int id)
        {
          return _context.Apolice.Any(e => e.Id == id);
        }
    }
}
