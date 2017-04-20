using Base.Core.Bootstrap;
using Base.Core.Injector;
using Contador.Domain.TiposPagamento.Adaptadores;
using Contador.Domain.TiposPagamento.Servicos;

namespace Contador.Domain.TiposPagamento
{
    public class TipoPagamentoBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<ITipoPagamentoAdapter, TipoPagamentoAdapter>();
            injector.AddTransient<ITipoPagamentoService, TipoPagamentoService>();
        }
    }
}
