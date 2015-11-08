using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class ProductRepository : RepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}