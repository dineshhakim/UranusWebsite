using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }


        
    }
}