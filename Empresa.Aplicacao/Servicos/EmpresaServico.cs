using Empresa.Dominio.Entidades;
using Empresa.Dominio.Filtros;
using Empresa.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Aplicacao.Servicos
{
    public class EmpresaServico
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaServico(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public List<EmpresaModelo> ListarEmpresas(EmpresaFiltro filtro)
        {
            return _empresaRepositorio.ObterEmpresasPorFiltro(filtro);
        }

        public void Inserir(string nomeFanstasia, string cnpj)
        {
            EmpresaModelo entidade = new()
            {
                CPNJ = cnpj,
                NomeFantasia = nomeFanstasia,
                Situacao = true
            };
            _empresaRepositorio.Add(entidade);
            _empresaRepositorio.SaveChanges();
        }

        public EmpresaModelo ObterEmpresaPorId(int id)
        {
            return _empresaRepositorio.GetById(id);
        }

        public void Alterar(string nomeFanstasia, string cnpj, int id)
        {
            var empresa = _empresaRepositorio.GetById(id);

            empresa.CPNJ = cnpj;
            empresa.NomeFantasia = nomeFanstasia;

            _empresaRepositorio.Update(empresa);
            _empresaRepositorio.SaveChanges();
        }

        public void Deletar(int id)
        {
            _empresaRepositorio.Remove(id);
            _empresaRepositorio.SaveChanges();
        }

        public void AlteraSituacao(int id, bool situacao)
        {
            var empresa = _empresaRepositorio.GetById(id);

            empresa.Situacao = !situacao;

            _empresaRepositorio.Update(empresa);
            _empresaRepositorio.SaveChanges();
        }
    }
}