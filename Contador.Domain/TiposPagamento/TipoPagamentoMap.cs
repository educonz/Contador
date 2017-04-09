using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contador.Domain.TiposPagamento
{
    class TipoPagamentoMap : EntityTypeConfiguration<TipoPagamento>
    {
        public TipoPagamentoMap()
        {
            ToTable(nameof(TipoPagamento));
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Descricao).IsRequired();
            Property(x => x.Usuario).IsRequired();
        }
    }
}
