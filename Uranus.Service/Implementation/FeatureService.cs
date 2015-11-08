using System.Collections.Generic;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class FeatureService : IServiceCommand<Feature>, IFeaturesService
    {
        private readonly IFeaturesRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public FeatureService(IFeaturesRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public Feature Add(Feature entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }

        public Feature Update(Feature entity)
        {
            return repository.Update(entity);
        }

        public void Delete(Feature entity)
        {
            repository.Delete(entity);
        }

        public IEnumerable<Feature> GetAll()
        {
            return repository.GetAll();
        }

        public Feature GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}