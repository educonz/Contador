using Base.Core.Adaptes;
using Contador.Contracts;

namespace Contador.Domain.TiposPagamento.Adaptadores
{
    public interface ITipoPagamentoAdapter : IModelAdapter<TipoPagamento, TipoPagamentoDto>
    {
    }
}
