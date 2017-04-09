using Base.Core.Bootstrap;
using System;
using Base.Core.Injector;
using Base.Core.Utils;

namespace Contador.Web
{
    public class ContadorBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IDateTimeBase, DataTimeService>();
        }
    }
}