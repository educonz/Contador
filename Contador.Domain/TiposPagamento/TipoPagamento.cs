using Base.Core.Data;

namespace Contador.Domain.TiposPagamento
{
    public class TipoPagamento : IEntity<long>, IFieldUser
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
    }
}
