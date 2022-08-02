using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Dominio.Filtros
{
    public class EmpresaFiltro
    {
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public bool? Situacao { get; set; }
    }
}