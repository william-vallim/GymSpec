namespace GymSpec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Identidade = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Situacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pagamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vencimento = c.DateTime(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Tipo = c.Int(nullable: false),
                        AlunoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunoes", t => t.AlunoId, cascadeDelete: true)
                .Index(t => t.AlunoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pagamentoes", "AlunoId", "dbo.Alunoes");
            DropIndex("dbo.Pagamentoes", new[] { "AlunoId" });
            DropTable("dbo.Pagamentoes");
            DropTable("dbo.Alunoes");
        }
    }
}
