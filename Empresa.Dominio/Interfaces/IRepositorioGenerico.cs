using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Dominio.Interfaces
{
    public interface IRepositorioGenerico<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(int id);

        int SaveChanges();
    }
}