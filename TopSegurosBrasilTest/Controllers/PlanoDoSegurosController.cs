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
    public class PlanoDoSegurosController : Controller
    {
        private readonly TopSegurosBrasilContext _context;

        public PlanoDoSegurosController(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        // GET: PlanoDoSeguros
        public async Task<IActionResult> Index()
        {
              return View(await _context.PlanoDoSeguro.ToListAsync());
        }

        // GET: PlanoDoSeguros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PlanoDoSeguro == null)
            {
                return NotFound();
            }

            var planoDoSeguro = await _context.PlanoDoSeguro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoDoSeguro == null)
            {
                return NotFound();
            }

            return View(planoDoSeguro);
        }

        // GET: PlanoDoSeguros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlanoDoSeguros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeDoPlano,Preco,AnexoPdf")] PlanoDoSeguro planoDoSeguro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planoDoSeguro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planoDoSeguro);
        }

        // GET: PlanoDoSeguros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PlanoDoSeguro == null)
            {
                return NotFound();
            }

            var planoDoSeguro = await _context.PlanoDoSeguro.FindAsync(id);
            if (planoDoSeguro == null)
            {
                return NotFound();
            }
            return View(planoDoSeguro);
        }

        // POST: PlanoDoSeguros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeDoPlano,Preco,AnexoPdf")] PlanoDoSeguro planoDoSeguro)
        {
            if (id != planoDoSeguro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planoDoSeguro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanoDoSeguroExists(planoDoSeguro.Id))
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
            return View(planoDoSeguro);
        }

        // GET: PlanoDoSeguros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PlanoDoSeguro == null)
            {
                return NotFound();
            }

            var planoDoSeguro = await _context.PlanoDoSeguro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planoDoSeguro == null)
            {
                return NotFound();
            }

            return View(planoDoSeguro);
        }

        // POST: PlanoDoSeguros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PlanoDoSeguro == null)
            {
                return Problem("Entity set 'TopSegurosBrasilContext.PlanoDoSeguro'  is null.");
            }
            var planoDoSeguro = await _context.PlanoDoSeguro.FindAsync(id);
            if (planoDoSeguro != null)
            {
                _context.PlanoDoSeguro.Remove(planoDoSeguro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanoDoSeguroExists(int id)
        {
          return _context.PlanoDoSeguro.Any(e => e.Id == id);
        }
    }
}
