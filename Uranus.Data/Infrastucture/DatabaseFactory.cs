using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uranus.Data.Infrastucture
{
   public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private DatabaseContext dataContext;
        public DatabaseContext Get()
        {
            return dataContext ?? (dataContext = new DatabaseContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
    
}
