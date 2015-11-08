using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;

namespace Uranus.Data.Implementation
{
    public class OrderDemoRepository : RepositoryBase<OrderDemo>, IOrderDemoRepository
    {
        public OrderDemoRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
