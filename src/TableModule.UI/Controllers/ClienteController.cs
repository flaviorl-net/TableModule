using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TableModule.Business;
using TableModule.UI.ViewModel;

namespace TableModule.UI.Controllers
{
    public class ClienteController : Controller
    {
        public IClienteBusiness _clienteBusiness { get; set; }

        public ClienteController(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            var model = _clienteBusiness.ObterClientes();
            var viewModel = new List<ClienteViewModel>();

            foreach (var item in model)
            {
                viewModel.Add(new ClienteViewModel() {
                    Nome = item.Nome,
                    SobreNome = item.SobreNome,
                    DataNascimento = item.DataNascimento
                });
            }

            return View(viewModel);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            try
            {
                _clienteBusiness.InserirCliente(clienteViewModel.Nome, clienteViewModel.SobreNome, clienteViewModel.DataNascimento);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
