using Base.Core.Service;
using Contador.Contracts;
using System.Collections.Generic;

namespace Contador.Domain.TiposPagamento.Servicos
{
    public interface ITipoPagamentoService : IServiceVerbatized<TipoPagamento, TipoPagamentoDto>
    {
        IList<TipoPagamentoDto> GetAll();
    }
}
