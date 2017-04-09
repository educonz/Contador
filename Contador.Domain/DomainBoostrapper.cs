using Base.Core.Bootstrap;
using Base.Core.Injector;
using Base.Core.Data;

namespace Contador.Domain
{
    public class DomainBoostrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IDataContext, Contexto>();
        }
    }
}
