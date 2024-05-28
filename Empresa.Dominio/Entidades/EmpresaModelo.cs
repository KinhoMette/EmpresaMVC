using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Empresa.Dominio.Entidades
{
    [Table("Empresa")]
    public class EmpresaModelo
    {
        [Key]
        public int Id { get; set; }

        [Column("NomeFantasia")]
        public string NomeFantasia { get; set; }

        [Column("CNPJ")]
        public string CNPJ { get; set; }

        [Column("Situacao")]
        public bool Situacao { get; set; }
    }
}