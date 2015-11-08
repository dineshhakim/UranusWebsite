using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Domain;
using Uranus.Service.Abstract;
using Uranus.Service.Implementation;

namespace Uranus.Service
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterType<IContactUsService, ContactUsService>();
            registrar.RegisterType<ITeamMemberService, TeamMemberService>();
            registrar.RegisterType<ICustomerService, CustomerService>();
            registrar.RegisterType<ICompanyService, CompanyService>();
            registrar.RegisterType<IProductService, ProductService>();
            registrar.RegisterType<IOrderDemoService, OrderDemoService>();
            registrar.RegisterType<IUserService, UserService>();
            registrar.RegisterType<IFeaturesService, FeatureService>();
        }
    }
}
