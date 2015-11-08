using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}