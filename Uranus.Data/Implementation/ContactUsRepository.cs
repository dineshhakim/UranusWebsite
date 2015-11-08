using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class ContactUsRepository : RepositoryBase<ContactUs> ,IContactUsRepository
    {
        public ContactUsRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}