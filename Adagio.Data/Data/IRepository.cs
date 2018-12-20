using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Data
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();

        T Get(int id);
        Task<T> GetAsync(int id);
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
