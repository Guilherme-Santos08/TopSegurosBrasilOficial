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
    public class AnoDosModelosController : Controller
    {
        private readonly TopSegurosBrasilContext _context;

        public AnoDosModelosController(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        // GET: AnoDosModelos
        public async Task<IActionResult> Index()
        {
              return View(await _context.AnoDoModelo.ToListAsync());
        }

        // GET: AnoDosModelos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AnoDoModelo == null)
            {
                return NotFound();
            }

            var anoDosModelo = await _context.AnoDoModelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (anoDosModelo == null)
            {
                return NotFound();
            }

            return View(anoDosModelo);
        }

        // GET: AnoDosModelos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnoDosModelos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AnoModelo")] AnoDosModelo anoDosModelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anoDosModelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anoDosModelo);
        }

        // GET: AnoDosModelos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AnoDoModelo == null)
            {
                return NotFound();
            }

            var anoDosModelo = await _context.AnoDoModelo.FindAsync(id);
            if (anoDosModelo == null)
            {
                return NotFound();
            }
            return View(anoDosModelo);
        }

        // POST: AnoDosModelos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AnoModelo")] AnoDosModelo anoDosModelo)
        {
            if (id != anoDosModelo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anoDosModelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnoDosModeloExists(anoDosModelo.Id))
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
            return View(anoDosModelo);
        }

        // GET: AnoDosModelos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AnoDoModelo == null)
            {
                return NotFound();
            }

            var anoDosModelo = await _context.AnoDoModelo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (anoDosModelo == null)
            {
                return NotFound();
            }

            return View(anoDosModelo);
        }

        // POST: AnoDosModelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AnoDoModelo == null)
            {
                return Problem("Entity set 'TopSegurosBrasilContext.AnoDoModelo'  is null.");
            }
            var anoDosModelo = await _context.AnoDoModelo.FindAsync(id);
            if (anoDosModelo != null)
            {
                _context.AnoDoModelo.Remove(anoDosModelo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnoDosModeloExists(int id)
        {
          return _context.AnoDoModelo.Any(e => e.Id == id);
        }
    }
}
