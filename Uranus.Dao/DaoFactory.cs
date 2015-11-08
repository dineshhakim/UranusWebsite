using Uranus.Dao.Abstract;
using Uranus.Dao.Implementation;

namespace Uranus.Dao
{
    public class DaoFactory
    {
        public static IContactUsManager GetContactUsManager()
        {
            return new ContactUsManager();
        }
    }
}