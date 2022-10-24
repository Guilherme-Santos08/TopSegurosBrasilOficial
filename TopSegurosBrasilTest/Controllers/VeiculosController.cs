using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopSegurosBrasil.Services;
using TopSegurosBrasil.Models;
using TopSegurosBrasil.Models.ViewModels;
using TopSegurosBrasil.Services.Exceptions;

namespace TopSegurosBrasil.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly VeiculoService _veiculoService;
        private readonly FabricanteService _fabricanteService;
        private readonly AnoDosModeloService _anoDosModeloService;

        public VeiculosController(VeiculoService veiculosService, FabricanteService fabricantesService, AnoDosModeloService anoDosModeloService)
        {
            _veiculoService = veiculosService;
            _fabricanteService = fabricantesService;
            _anoDosModeloService = anoDosModeloService;
        }

        public IActionResult Index()
        {
            var list = _veiculoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var fabricantesService = _fabricanteService.FindAll();
            var anoDosModeloService = _anoDosModeloService.FindAll();
            var viewModel = new VeiculoFormViewModel { Fabricantes = fabricantesService, AnoDosModelos = anoDosModeloService };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Veiculo seller)
        {
            _veiculoService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _veiculoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _veiculoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _veiculoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _veiculoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            

            List<Fabricante> fabricantes = _fabricanteService.FindAll();
            List<AnoDosModelo> anoDosModelos = _anoDosModeloService.FindAll();
            VeiculoFormViewModel viewModel = new VeiculoFormViewModel { Veiculo = obj, Fabricantes = fabricantes, AnoDosModelos = anoDosModelos };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Veiculo veiculo)
        {
            if (id != veiculo.Id)
            {
                return BadRequest();
            }
            try
            {
                _veiculoService.Update(veiculo);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}