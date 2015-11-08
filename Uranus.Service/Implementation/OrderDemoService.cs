using System.Collections.Generic;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class OrderDemoService : IOrderDemoService
    {
        private readonly IOrderDemoRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public OrderDemoService(IOrderDemoRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }
        public OrderDemo Add(OrderDemo entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }

        public OrderDemo Update(OrderDemo entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(OrderDemo entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<OrderDemo> GetAll()
        {
            return repository.GetAll();
        }

        public OrderDemo GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}