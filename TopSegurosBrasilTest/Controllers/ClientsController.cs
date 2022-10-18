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
    public class ClientsController : Controller
    {

        private readonly ClientService _clientService;
        private readonly TiposDeSeguroService _tiposDeSeguroService;

        public ClientsController(ClientService clientService, TiposDeSeguroService tiposDeSeguroService)
        {
            _clientService = clientService;
            _tiposDeSeguroService = tiposDeSeguroService;
        }

        public IActionResult Index()
        {
            var list = _clientService.FindAll();
            return View(list);
        }


        public IActionResult Create()
        {
            var tiposDeSeguros = _tiposDeSeguroService.FindAll();
            var viewModel = new ClientFormViewModel { TiposDeSeguros = tiposDeSeguros };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Client client)
        {
            _clientService.Insert(client);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _clientService.FindById(id.Value);
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
            _clientService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _clientService.FindById(id.Value);
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

            var obj = _clientService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<TiposDeSeguro> tiposDeSeguros = _tiposDeSeguroService.FindAll();
            ClientFormViewModel viewModel = new ClientFormViewModel { Client = obj, TiposDeSeguros = tiposDeSeguros };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Client client)
        {
            if (id != client.Id)
            {
                return BadRequest();
            }
            try
            {
                _clientService.Update(client);
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

