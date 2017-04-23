using Base.Core.Bootstrap;
using Base.Core.Injector;
using Base.Core.Logger;

namespace Base.Core.Log4Net
{
    public class LogBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<ILog, LogProvider>();
        }
    }
}
