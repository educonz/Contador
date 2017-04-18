using Base.Core.Bootstrap;
using Base.Core.Data;
using Base.Core.Injector;

namespace Base.Core.EntityFramework
{
    public class EFBoostrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddScoped<IRepository, Repository>();
        }
    }
}
