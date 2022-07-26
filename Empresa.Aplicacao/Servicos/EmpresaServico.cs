using Empresa.Dominio.Entidades;
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

        public List<EmpresaModelo> ListarEmpresas()
        {
            return _empresaRepositorio.GetAll();
        }

        public void Inserir(string nomeFanstasia, string cnpj, bool situacao)
        {
            EmpresaModelo entidade = new EmpresaModelo()
            {
                CPNJ = cnpj,
                NomeFantasia = nomeFanstasia,
                Situacao = situacao
            };
            _empresaRepositorio.Add(entidade);
            _empresaRepositorio.SaveChanges();
        }
    }
}