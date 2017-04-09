using Base.Core.Bootstrap;
using Base.Core.Data;
using Base.Core.Injector;

namespace Base.Core.EntityFramework
{
    public class IBoostrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddScoped<IRepository, Repository>();
        }
    }
}
