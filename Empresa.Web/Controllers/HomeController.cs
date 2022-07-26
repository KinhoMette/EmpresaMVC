using Empresa.Aplicacao.Servicos;
using Empresa.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmpresaServico _empresaServico;

        public HomeController(EmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        public IActionResult Index()
        {
            var listaEmpresa = _empresaServico.ListarEmpresas();
            return View(listaEmpresa);
        }

        public IActionResult Alterar()
        {
            //var alterado = _empresaServico.Alterar();
            return View();
        }

        public IActionResult Criar(string nomeFantasia, string cnpj, bool situacao)
        {
            _empresaServico.Inserir(nomeFantasia, cnpj, situacao);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}