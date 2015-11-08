using Uranus.Domain.Entities;

namespace Uranus.Service.Abstract
{
    public interface IUserService : IServiceCommand<User>
    {
        bool CheckLogin(User user);
    }
}