using Base.Core.Data;
using Contador.Domain.TiposPagamento;
using System;

namespace Contador.Domain.Creditos
{
    public class Credito : IEntity<long>, IFieldUser
    {
        public long Id { get; set; }

        public DateTime DataEntrada { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }

        public long TpPagamentoId { get; set; }
        public virtual TipoPagamento TpPagamento { get; set; }

        public string Usuario { get; set; }
    }
}
