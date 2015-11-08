using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class CustomerRepository :RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}