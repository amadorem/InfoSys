using DepEd.InfoSys.Entities.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DepEd.InfoSys.Data.Interfaces
{
    public interface IRepository<T>
        where T: BaseEntity
    {
        T Get(int id);

        IQueryable<T> Get();

        void Add(T entity);

        void Update(T entity);
            
        void Delete(T entity);

        void Save();
    }
}
