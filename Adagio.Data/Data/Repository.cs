using Adagio.Data.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        public AdagioContext Context;
        public Repository(AdagioContext context) => Context = context;
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().AsEnumerable();
        }

        public T Get(int id)
        {
            return Context.Set<T>().FirstOrDefault(o => o.id == id);
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            try
            {
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
