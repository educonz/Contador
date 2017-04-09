using Base.Core.Injector;

namespace Base.Core.Bootstrap
{
    public interface IBootstrapper
    {
        void Load(IInjector injector);
    }
}
