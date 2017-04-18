using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contador.Domain.Debitos
{
    public class DebitoMap : EntityTypeConfiguration<Debito>
    {
        public DebitoMap()
        {
            ToTable(nameof(Debito));
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DataSaida).IsRequired();
            Property(x => x.Valor).IsRequired();
            Property(x => x.Usuario).IsRequired();

            Property(x => x.Observacao).IsOptional();

            HasRequired(x => x.TipoPagamento)
                .WithMany()
                .HasForeignKey(x => x.TipoPagamentoId);

            HasRequired(x => x.TipoDespesa)
                .WithMany()
                .HasForeignKey(x => x.TipoDespesaId);
        }
    }
}
