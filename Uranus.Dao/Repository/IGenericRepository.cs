using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Uranus.Dao.Repository
{
    public interface IGenericRepository<T>
    {
        T Save(T entity);
        IEnumerable<T> FindAll();
        T Update(T entity);
        bool Delete(T entity);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}