using Ninject.Modules;
using Obilet.Business.Abstract;
using Obilet.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obilet.Business.DependencyResolver
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IBusLocationService>().To<BusLocationManager>().InSingletonScope();
            Bind<ICookieService>().To<CookieManager>().InSingletonScope();
            Bind<IRestApiService>().To<RestApiManager>().InSingletonScope();
            Bind<ISessionService>().To<SessionManager>().InSingletonScope();
            Bind<IBusJourneyService>().To<BusJourneyManager>().InSingletonScope();
        }
    }
}
