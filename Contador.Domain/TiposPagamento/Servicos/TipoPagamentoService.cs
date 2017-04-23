using System.Collections.Generic;
using Base.Core.Data;
using Contador.Contracts;
using Contador.Domain.Implementations.Services;
using Contador.Domain.TiposPagamento.Adaptadores;
using System.Linq;

namespace Contador.Domain.TiposPagamento.Servicos
{
    public class TipoPagamentoService : ServiceVerbatized<TipoPagamento, TipoPagamentoDto>, ITipoPagamentoService
    {
        public TipoPagamentoService(IRepository repository,ITipoPagamentoAdapter adapter) 
            : base(repository, adapter)
        {
        }

        public IList<TipoPagamentoDto> GetAll()
        {
            return Repository
                .Query<TipoPagamento>()
                .OrderBy(x => x.Descricao)
                .ToList()
                .Select(x => Adapter.ToDto(x))
                .ToList();
        }
    }
}
