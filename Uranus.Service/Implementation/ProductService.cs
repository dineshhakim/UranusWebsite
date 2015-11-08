using System.Collections.Generic;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IProductRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public Products Add(Products entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }

        public Products Update(Products entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(Products entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<Products> GetAll()
        {
            return repository.GetAll();
        }

        public Products GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}