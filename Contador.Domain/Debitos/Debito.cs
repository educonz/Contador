using Base.Core.Data;
using Contador.Domain.TiposDespesa;
using Contador.Domain.TiposPagamento;
using System;

namespace Contador.Domain.Debitos
{
    public class Debito : IEntity<long>, IFieldUser
    {
        public long Id { get; set; }
        public DateTime DataSaida { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
        public long TipoPagamentoId { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }
        public long TipoDespesaId { get; set; }
        public virtual TipoDespesa TipoDespesa { get; set; }
        public string Usuario { get; set; }
    }
}
