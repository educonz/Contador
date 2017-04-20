using Base.Core.Service;
using Contador.Contracts;

namespace Contador.Domain.TiposPagamento.Servicos
{
    public interface ITipoPagamentoService : IServiceVerbatized<TipoPagamento, TipoPagamentoDto>
    {
    }
}
