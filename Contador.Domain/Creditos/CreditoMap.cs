using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Contador.Domain.Creditos
{
    public class CreditoMap : EntityTypeConfiguration<Credito>
    {
        public CreditoMap()
        {
            ToTable(nameof(Credito));
            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.DataEntrada).IsRequired();
            Property(x => x.Valor).IsRequired();
            Property(x => x.Usuario).IsRequired();

            Property(x => x.Observacao).IsOptional();

            HasRequired(x => x.TpPagamento)
                .WithMany()
                .HasForeignKey(x => x.TpPagamentoId);
        }
    }
}
