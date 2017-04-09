using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contador.Domain.TiposDespesa
{
    public class TipoDespesaMap : EntityTypeConfiguration<TipoDespesa>
    {
        public TipoDespesaMap()
        {
            ToTable(nameof(TipoDespesa));
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Descricao).IsRequired();
            Property(x => x.Usuario).IsRequired();
        }
    }
}
