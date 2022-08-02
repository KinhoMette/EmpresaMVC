using Empresa.Dominio.Entidades;
using Empresa.Dominio.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Dominio.Interfaces
{
    public interface IEmpresaRepositorio : IRepositorioGenerico<EmpresaModelo>
    {
        EmpresaModelo ObterPorNomeFantasia(string nomeFantasia);

        List<EmpresaModelo> ObterEmpresasPorFiltro(EmpresaFiltro filtro);
    }
}