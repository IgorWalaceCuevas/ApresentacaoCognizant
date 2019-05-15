using SimpleInjector;
using Cognizant.Domain.Interface.Repository;
using Cognizant.Repository;
using Cognizant.Domain.Interface.Service;
using Cognizant.Application.Interface;
using Cognizant.Application;
using Cognizant.Domain.Service;

namespace Cognizant.CrossCutting
{
    public class BootStrapper
    {
        public static void Register(ref Container container)
        {
            //Application
            container.Register(typeof(IAppBase<>), typeof(AppBase<>));
            container.Register<ILoginApp, LoginApp>(Lifestyle.Scoped);
            container.Register<IBankAccountApp, BankAccountApp>(Lifestyle.Scoped);
            container.Register<ISimulationApp, SimulationApp>(Lifestyle.Scoped);

            //Service
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<ILoginService, LoginService>(Lifestyle.Scoped);
            container.Register<IBankAccountService, BankAccountService>(Lifestyle.Scoped);
            container.Register<ISimulationService, SimulationService>(Lifestyle.Scoped);

            //Repository
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            container.Register<ILoginRepository, LoginRepository>(Lifestyle.Scoped);
            container.Register<IBankAccountRepository, BankAccountRepository>(Lifestyle.Scoped);
            container.Register<ISimulationRepository, SimulationRepository>(Lifestyle.Scoped);
        }
    }
}
