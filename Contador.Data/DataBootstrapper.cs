using Base.Core.Bootstrap;
using Base.Core.Injector;
using Base.Core.Data;

namespace Contador.Data
{
    public class DataBootstrapper : IBootstrapper

    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IDataContext, Contexto>();
        }
    }
}
