using Empresa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Infra.Contexto
{
    //Contexto = database ou contexto da database
    public class MvcContexto : DbContext
    {
        public MvcContexto(DbContextOptions<MvcContexto> options) : base(options)
        {
        }

        public DbSet<EmpresaModelo> Empresas { get; set; }
    }
}