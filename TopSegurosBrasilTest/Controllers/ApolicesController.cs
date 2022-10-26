using Microsoft.AspNetCore.Mvc;
using TopSegurosBrasil.Models;
using TopSegurosBrasil.Models.ViewModels;
using TopSegurosBrasil.Services;
using TopSegurosBrasil.Services.Exceptions;

namespace TopSegurosBrasil.Controllers
{
    public class ApolicesController : Controller
    {
        private readonly ApoliceService _apoliceService;
        private readonly PlanoDoSeguroService _planoDoSeguroService;

        public ApolicesController(ApoliceService apoliceService, PlanoDoSeguroService planoDoSegurotService)
        {
            _apoliceService = apoliceService;
            _planoDoSeguroService = planoDoSegurotService;
        }

        public IActionResult Index()
        {
            var list = _apoliceService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var planoDoSeguros = _planoDoSeguroService.FindAll();
            var viewModel = new ApoliceFormViewModel { PlanoDoSeguros = planoDoSeguros };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Apolice apolice)
        {
            _apoliceService.Insert(apolice);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _apoliceService.FindById(id.Value);
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
            _apoliceService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _apoliceService.FindById(id.Value);
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

            var obj = _apoliceService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<PlanoDoSeguro> planoDoSeguros = _planoDoSeguroService.FindAll();
            ApoliceFormViewModel viewModel = new ApoliceFormViewModel { Apolice = obj, PlanoDoSeguros = planoDoSeguros };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Apolice apolice)
        {
            if (id != apolice.Id)
            {
                return BadRequest();
            }
            try
            {
                _apoliceService.Update(apolice);
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
