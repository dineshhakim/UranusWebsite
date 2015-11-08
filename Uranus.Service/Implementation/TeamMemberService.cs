using System.Collections.Generic;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly ITeamMemberRepository teamMemberRepository;
        private readonly IUnitOfWork unitOfWork;

        public TeamMemberService(ITeamMemberRepository teamMemberRepository, IUnitOfWork unitOfWork)
        {
            this.teamMemberRepository = teamMemberRepository;
            this.unitOfWork = unitOfWork;
        }
        public TeamMember Add(TeamMember entity)
        {
            entity = teamMemberRepository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }

        public TeamMember Update(TeamMember entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TeamMember entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TeamMember> GetAll()
        {
            return teamMemberRepository.GetAll();
        }

        public TeamMember GetById(int id)
        {
            return teamMemberRepository.GetById(id);
        }
    }
}