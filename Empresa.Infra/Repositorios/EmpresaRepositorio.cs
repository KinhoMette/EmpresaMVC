using Empresa.Dominio.Entidades;
using Empresa.Dominio.Interfaces;
using Empresa.Infra.Contexto;
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
    }
}