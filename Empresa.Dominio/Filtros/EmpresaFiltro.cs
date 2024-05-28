namespace Empresa.Dominio.Filtros
{
    public class EmpresaFiltro
    {
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public bool? Situacao { get; set; }
        public int? PageNumber { get; set; }

        public int PageSize { get; set; } = 10;
    }
}