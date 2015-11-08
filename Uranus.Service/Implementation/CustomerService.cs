using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public CustomerService(ICustomerRepository contactUsRepository, IUnitOfWork unitOfWork)
        {
            this.repository = contactUsRepository;
            this.unitOfWork = unitOfWork;
        }
        public Customer Add(Customer objContactUs)
        {
            try
            {
                objContactUs = repository.Add(objContactUs);
                unitOfWork.Commit();
                return objContactUs;
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        public Customer Update(Customer entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(Customer entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<Customer> GetAll()
        {
            return repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}