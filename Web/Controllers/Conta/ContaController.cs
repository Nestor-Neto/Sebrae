using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Application.Services;
using Domain.Entities;

namespace SebraeWeb.Controllers.Conta
{
    public class ContaController : Controller
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        public ActionResult Index()
        {
            ContaDTO conta;
            List<ContaDTO> lstContaDTO = new List<ContaDTO>();

            var listaContas = _contaService.Get();

            foreach (var item in listaContas.Result)
            {
                conta = new ContaDTO
                {
                    ID = item.ID,
                    Nome = item.Nome,
                    Descricao = item.Descricao
                };

                lstContaDTO.Add(conta);
            }

            return View("~/Views/Conta/Index.cshtml", lstContaDTO);
        }

		public ActionResult Criar(ContaDTO conta)
		{
			if (ModelState.IsValid)
			{
				_contaService.Criar(conta);

				return RedirectToAction("Index");
			}
			return View(conta);
		}

        public ActionResult Excluir(ContaDTO conta)
        {

            _contaService.Excluir(conta);

            return RedirectToAction("Index");
        }
        public ActionResult EditarDados(ContaDTO conta)
        {
            return View("~/Views/Conta/Editar.cshtml", conta);
        }
        public ActionResult EditarSalvar(ContaDTO conta)
        {

            _contaService.Editar(conta);

            return RedirectToAction("Index");
        }
    }
}
