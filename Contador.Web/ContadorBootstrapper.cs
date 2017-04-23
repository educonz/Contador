using Base.Core.Bootstrap;
using Base.Core.Injector;
using Contador.Data;
using Base.Core.EntityFramework;
using Contador.Domain;
using Base.Core.Log4Net;

namespace Contador.Web
{
    public class ContadorBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            //injector.AddTransient<IDateTimeBase, DataTimeService>();
            new DataBootstrapper().Load(injector);
            new EFBoostrapper().Load(injector);
            new DomainBoostrapper().Load(injector);
            new LogBootstrapper().Load(injector);
        }
    }
}