using Empresa.Dominio.Entidades;
using Empresa.Dominio.Filtros;
using Empresa.Dominio.Models;

namespace Empresa.Dominio.Interfaces
{
    public interface IEmpresaRepositorio : IRepositorioGenerico<EmpresaModelo>
    {
        EmpresaModelo ObterPorNomeFantasia(string nomeFantasia);

        PaginatedList<EmpresaModelo> ObterEmpresasPorFiltro(EmpresaFiltro filtro);
    }
}