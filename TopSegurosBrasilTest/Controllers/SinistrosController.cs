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
    public class SinistrosController : Controller
    {
        private readonly TopSegurosBrasilContext _context;

        public SinistrosController(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        // GET: Sinistros
        public async Task<IActionResult> Index()
        {
              return View(await _context.Sinistro.ToListAsync());
        }

        // GET: Sinistros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sinistro == null)
            {
                return NotFound();
            }

            var sinistro = await _context.Sinistro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sinistro == null)
            {
                return NotFound();
            }

            return View(sinistro);
        }

        // GET: Sinistros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sinistros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataSinistro,DescSinistro,VeiculoId")] Sinistro sinistro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinistro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sinistro);
        }

        // GET: Sinistros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sinistro == null)
            {
                return NotFound();
            }

            var sinistro = await _context.Sinistro.FindAsync(id);
            if (sinistro == null)
            {
                return NotFound();
            }
            return View(sinistro);
        }

        // POST: Sinistros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataSinistro,DescSinistro,VeiculoId")] Sinistro sinistro)
        {
            if (id != sinistro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinistro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinistroExists(sinistro.Id))
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
            return View(sinistro);
        }

        // GET: Sinistros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sinistro == null)
            {
                return NotFound();
            }

            var sinistro = await _context.Sinistro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sinistro == null)
            {
                return NotFound();
            }

            return View(sinistro);
        }

        // POST: Sinistros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sinistro == null)
            {
                return Problem("Entity set 'TopSegurosBrasilContext.Sinistro'  is null.");
            }
            var sinistro = await _context.Sinistro.FindAsync(id);
            if (sinistro != null)
            {
                _context.Sinistro.Remove(sinistro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinistroExists(int id)
        {
          return _context.Sinistro.Any(e => e.Id == id);
        }
    }
}
