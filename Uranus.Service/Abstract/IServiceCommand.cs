using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Uranus.Service.Abstract
{
    public interface IServiceCommand<T>
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();

        T GetById(int id);
    }
}