using System.Data.Entity;
using Base.Core.EntityFramework;
using Contador.Domain.Creditos;
using Contador.Domain.TiposDespesa;
using Contador.Domain.TiposPagamento;
using Contador.Domain.Debitos;

namespace Contador.Data
{
    public class Contexto : ContextoBase
    {
        public DbSet<Credito> Credito { get; set; }
        public DbSet<Debito> Debito { get; set; }
        public DbSet<TipoDespesa> TipoDespesa { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }

        public Contexto() : base("ContadorProd")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CreditoMap());
            modelBuilder.Configurations.Add(new DebitoMap());
            modelBuilder.Configurations.Add(new TipoDespesaMap());
            modelBuilder.Configurations.Add(new TipoPagamentoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
