using DepEd.InfoSys.Data.Interfaces;
using DepEd.InfoSys.Entities.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DepEd.InfoSys.Data.Repositories
{
    public class Repository<T> : IRepository<T>
        where T: BaseEntity
    {
        private readonly InfoSysDbContext context;

        public Repository(InfoSysDbContext context)
        {
            this.context = context;
        }

        public void Add(T entity) 
        {
            context.Add<T>(entity);
        }

        public void Update(T entity)
        {
            context.Update<T>(entity);
        }

        public void Delete(T entity)
        {
            context.Remove<T>(entity);
        }

        public T Get(int id)
        {
            return context.Find<T>(id);
        }

        public IQueryable<T> Get()
        {
            return context.Set<T>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
