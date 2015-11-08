 

using System.ComponentModel.Composition;
using Microsoft.Practices.Unity;
using Uranus.Data.Abstract;
using Uranus.Data.Implementation;
using Uranus.Data.Infrastucture;
using Uranus.Domain;

namespace Uranus.Data
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterTypeWithContainerControlledLife<IDatabaseFactory, DatabaseFactory>();
            registrar.RegisterTypeWithContainerControlledLife<IUnitOfWork, UnitOfWork>();
            registrar.RegisterTypeWithContainerControlledLife<IContactUsRepository, ContactUsRepository>();
            registrar.RegisterTypeWithContainerControlledLife<ITeamMemberRepository, TeamMemberRepository>();
            registrar.RegisterTypeWithContainerControlledLife<ICustomerRepository, CustomerRepository>();
            registrar.RegisterTypeWithContainerControlledLife<ICompanyRepository, CompanyRepository>();
            registrar.RegisterTypeWithContainerControlledLife<IProductRepository, ProductRepository>();
            registrar.RegisterTypeWithContainerControlledLife<IOrderDemoRepository, OrderDemoRepository>();
            registrar.RegisterType<IUserRepository, UserRepository>();
            registrar.RegisterType<IFeaturesRepository, FeaturesRepository>();
        }
    }

}
