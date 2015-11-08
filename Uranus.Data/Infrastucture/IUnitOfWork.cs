using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uranus.Data.Infrastucture
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
