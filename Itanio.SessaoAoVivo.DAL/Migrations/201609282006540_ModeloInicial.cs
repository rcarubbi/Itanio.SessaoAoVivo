using System.Data.Entity.Migrations;

namespace Itanio.SessaoAoVivo.DAL.Migrations
{
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Parametro",
                    c => new
                    {
                        Id = c.Guid(false),
                        Chave = c.String(),
                        Valor = c.String(),
                        Ativo = c.Boolean(false),
                        DataCriacao = c.DateTime(false)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Sessao",
                    c => new
                    {
                        Id = c.Guid(false),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Logotipo_Nome = c.String(),
                        Cor = c.String(),
                        DataHoraInicio = c.DateTime(false),
                        CodigoYouTube = c.String(),
                        Rodape = c.String(),
                        NomeCanal = c.String(),
                        Ativo = c.Boolean(false),
                        DataCriacao = c.DateTime(false)
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Sorteio",
                    c => new
                    {
                        Id = c.Guid(false),
                        Descricao = c.String(),
                        Feito = c.Boolean(false),
                        Ativo = c.Boolean(false),
                        DataCriacao = c.DateTime(false),
                        Sessao_Id = c.Guid(false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessao", t => t.Sessao_Id, true)
                .Index(t => t.Sessao_Id);

            CreateTable(
                    "dbo.Usuario",
                    c => new
                    {
                        Id = c.Guid(false),
                        Nick = c.String(),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                        Ativo = c.Boolean(false),
                        DataCriacao = c.DateTime(false),
                        Sessao_Id = c.Guid(false)
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sessao", t => t.Sessao_Id, true)
                .Index(t => t.Sessao_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Sessao_Id", "dbo.Sessao");
            DropForeignKey("dbo.Sorteio", "Sessao_Id", "dbo.Sessao");
            DropIndex("dbo.Usuario", new[] {"Sessao_Id"});
            DropIndex("dbo.Sorteio", new[] {"Sessao_Id"});
            DropTable("dbo.Usuario");
            DropTable("dbo.Sorteio");
            DropTable("dbo.Sessao");
            DropTable("dbo.Parametro");
        }
    }
}