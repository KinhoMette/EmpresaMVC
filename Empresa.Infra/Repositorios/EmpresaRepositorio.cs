using Empresa.Dominio.Entidades;
using Empresa.Dominio.Filtros;
using Empresa.Dominio.Interfaces;
using Empresa.Dominio.Models;
using Empresa.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Infra.Repositorios
{
    public class EmpresaRepositorio : RepositorioGenerico<EmpresaModelo>, IEmpresaRepositorio
    {
        public EmpresaRepositorio(MvcContexto contexto) : base(contexto)
        {
        }

        public EmpresaModelo ObterPorNomeFantasia(string nomeFantasia)
        {
            return DbSet.Where(x => x.NomeFantasia == nomeFantasia).FirstOrDefault();
        }

        public bool VerificaEmpresaExiste(string cnpj)
        {
            return DbSet.Where(x => x.CNPJ == cnpj).Any();
        }

        public PaginatedList<EmpresaModelo> ObterEmpresasPorFiltro(EmpresaFiltro filtro)
        {
            var query = DbSet.AsQueryable();

            if (!string.IsNullOrEmpty(filtro.NomeFantasia))
                query = query.Where(x => x.NomeFantasia.StartsWith(filtro.NomeFantasia));

            if (!string.IsNullOrEmpty(filtro.CNPJ))
                query = query.Where(x => x.CNPJ == filtro.CNPJ);

            if (filtro.Situacao != null)
                query = query.Where(x => x.Situacao == filtro.Situacao);

            

            return PaginatedList<EmpresaModelo>.Create(query.AsNoTracking(), filtro.PageNumber ?? 1, filtro.PageSize);
        }
    }
}