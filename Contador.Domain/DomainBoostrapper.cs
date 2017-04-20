using Base.Core.Bootstrap;
using Base.Core.Injector;
using Contador.Domain.TiposPagamento;

namespace Contador.Domain
{
    public class DomainBoostrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            new TipoPagamentoBootstrapper().Load(injector);
        }
    }
}
