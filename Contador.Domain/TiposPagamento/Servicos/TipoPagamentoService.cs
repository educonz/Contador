using Base.Core.Data;
using Contador.Contracts;
using Contador.Domain.Implementations.Services;
using Contador.Domain.TiposPagamento.Adaptadores;

namespace Contador.Domain.TiposPagamento.Servicos
{
    public class TipoPagamentoService : ServiceVerbatized<TipoPagamento, TipoPagamentoDto>, ITipoPagamentoService
    {
        public TipoPagamentoService(IRepository repository,ITipoPagamentoAdapter adapter) 
            : base(repository, adapter)
        {
        }
    }
}
