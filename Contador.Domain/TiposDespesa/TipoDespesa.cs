using System;
using Base.Core.Data;

namespace Contador.Domain.TiposDespesa
{
    public class TipoDespesa : IEntity<long>, IFieldUser
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Usuario { get; set; }
    }
}
