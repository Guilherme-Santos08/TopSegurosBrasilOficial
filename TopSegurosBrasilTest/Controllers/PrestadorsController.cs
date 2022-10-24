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
    public class PrestadorsController : Controller  
    {
        private readonly TopSegurosBrasilContext _context;

        public PrestadorsController(TopSegurosBrasilContext context)
        {
            _context = context;
        }

        // GET: Prestadors
        public async Task<IActionResult> Index()
        {
              return View(await _context.Prestador.ToListAsync());
        }

        // GET: Prestadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prestador == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // GET: Prestadors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Prestadors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeEmpresa,Cnpj,TipoPrestador,Email,Telefone,Bairro,Cidade,Estado,Cep,Num_Imovel")] Prestador prestador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prestador);
        }

        // GET: Prestadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prestador == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador.FindAsync(id);
            if (prestador == null)
            {
                return NotFound();
            }
            return View(prestador);
        }

        // POST: Prestadors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeEmpresa,Cnpj,TipoPrestador,Email,Telefone,Bairro,Cidade,Estado,Cep,Num_Imovel")] Prestador prestador)
        {
            if (id != prestador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestadorExists(prestador.Id))
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
            return View(prestador);
        }

        // GET: Prestadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prestador == null)
            {
                return NotFound();
            }

            var prestador = await _context.Prestador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestador == null)
            {
                return NotFound();
            }

            return View(prestador);
        }

        // POST: Prestadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prestador == null)
            {
                return Problem("Entity set 'TopSegurosBrasilContext.Prestador'  is null.");
            }
            var prestador = await _context.Prestador.FindAsync(id);
            if (prestador != null)
            {
                _context.Prestador.Remove(prestador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestadorExists(int id)
        {
          return _context.Prestador.Any(e => e.Id == id);
        }
    }
}
