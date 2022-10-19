using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopSegurosBrasil.Models;
using TopSegurosBrasil.Models.ViewModels;
using TopSegurosBrasil.Services;
using TopSegurosBrasil.Services.Exceptions;

namespace TopSegurosBrasil.Controllers
{
    public class VeiculosController : Controller
    {

        private readonly VeiculoService _veiculoService;
        private readonly ClientService _clientService;

        public VeiculosController(VeiculoService VeiculoService, ClientService clientService)
        {
            _veiculoService = VeiculoService;
            _clientService = clientService;
        }

        public IActionResult Index()
        {
            var list = _veiculoService.FindAll();
            return View(list);
        }


        public IActionResult Create()
        {
            var client = _clientService.FindById(5);
            var viewModel = new ClientFormViewModel { Client = client };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Veiculo veiculo)
        {
            _veiculoService.Insert(veiculo);
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

            ClientFormViewModel viewModel = new ClientFormViewModel { Veiculo = obj };
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

