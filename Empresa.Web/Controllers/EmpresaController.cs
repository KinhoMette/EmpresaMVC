using Empresa.Aplicacao.Servicos;
using Empresa.Dominio.Filtros;
using Microsoft.AspNetCore.Mvc;

namespace Empresa.Web.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly EmpresaServico _empresaServico;

        public EmpresaController(EmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        public IActionResult Index(EmpresaFiltro filtro)
        {
            var empresas = _empresaServico.ListarEmpresas(filtro);
            return View(empresas);
        }

        public IActionResult Criar(string nomeFantasia, string cnpj)
        {
            _empresaServico.Inserir(nomeFantasia, cnpj);

            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id)
        {
            var empresa = _empresaServico.ObterEmpresaPorId(id);
            ViewBag.Situacao = empresa.Situacao ? "Ativo" : "Inativo";
            return View(empresa);
        }

        [HttpPost]
        public IActionResult Alterar(string nomeFantasia, string cnpj, int id)
        {
            try
            {
                _empresaServico.Alterar(nomeFantasia, cnpj, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult AlteraSituacao(int id, bool situacao)
        {
            _empresaServico.AlteraSituacao(id, situacao);
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {
            _empresaServico.Deletar(id);
            return RedirectToAction("Index");
        }

        public JsonResult VerificaCNPJexiste(string cnpj)
        {
            var empresaExiste = _empresaServico.EmpresaExiste(cnpj);

           return Json(new { empresaExiste });
        }
    }
}