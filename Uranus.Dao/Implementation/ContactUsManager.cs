using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Uranus.Dao.Abstract;
using Uranus.Dao.Repository;
using Uranus.Domain.Entities;

namespace Uranus.Dao.Implementation
{
    public class ContactUsManager : GenericRepository<ContactUs, DatabaseContext>, IContactUsManager
    {
        public void Save(object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetById(Type objType, object objId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ToList<TEntity>()
        {
            throw new NotImplementedException();
        }
    }
}
