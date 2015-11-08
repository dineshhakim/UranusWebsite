using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class TeamMemberRepository : RepositoryBase<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}