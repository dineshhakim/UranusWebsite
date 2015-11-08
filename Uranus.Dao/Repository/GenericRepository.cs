using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Linq.Expressions;

namespace Uranus.Dao.Repository
{
    public class GenericRepository<T, C> :
    IGenericRepository<T>
        where T : class
        where C : DbContext, new()
    {

        private C _entities = new C();
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }



        public virtual T Save(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity = _entities.Set<T>().Add(entity);
            _entities.SaveChangesAsync();
            return entity;
        }

        public virtual IEnumerable<T> FindAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }
        public virtual T Update(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual bool Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
            return true;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

    }
}