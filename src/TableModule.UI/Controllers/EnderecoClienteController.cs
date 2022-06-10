using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TableModule.Business;
using TableModule.UI.ViewModel;
using System.Linq;

namespace TableModule.UI.Controllers
{
    public class EnderecoClienteController : Controller
    {
        public IEnderecoClienteBusiness _enderecoClienteBusiness { get; set; }
        public IClienteBusiness _clienteBusiness { get; set; }

        public EnderecoClienteController(IEnderecoClienteBusiness enderecoClienteBusiness,
            IClienteBusiness clienteBusiness)
        {
            _enderecoClienteBusiness = enderecoClienteBusiness;
            _clienteBusiness = clienteBusiness;
        }

        // GET: EnderecoClienteController
        public ActionResult Index()
        {
            var model = _enderecoClienteBusiness.ObterEnderecoCliente();
            var clienteModel = _clienteBusiness.ObterClientes();
            var viewModel = new List<EnderecoClienteViewModel>();

            foreach (var item in model)
            {
                string cliente = clienteModel.FirstOrDefault(x => x.Id == item.ClienteId).Nome;

                viewModel.Add(new EnderecoClienteViewModel()
                {
                    Complemento = item.Complemento,
                    Endereco = item.Endereco,
                    Logradouro = item.Logradouro,
                    Numero = item.Numero,
                    NomeCliente = cliente,
                });
            }

            return View(viewModel);
        }

        // GET: EnderecoClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnderecoClienteController/Create
        public ActionResult Create()
        {
            ViewBag.Clientes = new SelectList(_clienteBusiness.ObterClientes(), "Id", "Nome");
            return View();
        }

        // POST: EnderecoClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnderecoClienteViewModel viewModel)
        {
            try
            {
                _enderecoClienteBusiness.InserirEnderecoCliente(viewModel.Logradouro, viewModel.Endereco, 
                    viewModel.Numero, viewModel.Complemento, viewModel.ClienteId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EnderecoClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EnderecoClienteController/Edit/5
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

        // GET: EnderecoClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EnderecoClienteController/Delete/5
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
