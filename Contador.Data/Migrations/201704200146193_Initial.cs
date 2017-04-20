namespace Contador.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Credito",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DataEntrada = c.DateTime(nullable: false, precision: 0),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacao = c.String(unicode: false),
                        TipoPagamentoId = c.Long(nullable: false),
                        Usuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoPagamento", t => t.TipoPagamentoId, cascadeDelete: true)
                .Index(t => t.TipoPagamentoId);
            
            CreateTable(
                "dbo.TipoPagamento",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, unicode: false),
                        Usuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Debito",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DataSaida = c.DateTime(nullable: false, precision: 0),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Observacao = c.String(unicode: false),
                        TipoPagamentoId = c.Long(nullable: false),
                        TipoDespesaId = c.Long(nullable: false),
                        Usuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoDespesa", t => t.TipoDespesaId, cascadeDelete: true)
                .ForeignKey("dbo.TipoPagamento", t => t.TipoPagamentoId, cascadeDelete: true)
                .Index(t => t.TipoPagamentoId)
                .Index(t => t.TipoDespesaId);
            
            CreateTable(
                "dbo.TipoDespesa",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, unicode: false),
                        Usuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Debito", "TipoPagamentoId", "dbo.TipoPagamento");
            DropForeignKey("dbo.Debito", "TipoDespesaId", "dbo.TipoDespesa");
            DropForeignKey("dbo.Credito", "TipoPagamentoId", "dbo.TipoPagamento");
            DropIndex("dbo.Debito", new[] { "TipoDespesaId" });
            DropIndex("dbo.Debito", new[] { "TipoPagamentoId" });
            DropIndex("dbo.Credito", new[] { "TipoPagamentoId" });
            DropTable("dbo.TipoDespesa");
            DropTable("dbo.Debito");
            DropTable("dbo.TipoPagamento");
            DropTable("dbo.Credito");
        }
    }
}
