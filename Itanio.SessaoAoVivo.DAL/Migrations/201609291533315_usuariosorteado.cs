using System.Data.Entity.Migrations;

namespace Itanio.SessaoAoVivo.DAL.Migrations
{
    public partial class usuariosorteado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sorteio", "UsuarioSorteado_Id", c => c.Guid());
            CreateIndex("dbo.Sorteio", "UsuarioSorteado_Id");
            AddForeignKey("dbo.Sorteio", "UsuarioSorteado_Id", "dbo.Usuario", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Sorteio", "UsuarioSorteado_Id", "dbo.Usuario");
            DropIndex("dbo.Sorteio", new[] {"UsuarioSorteado_Id"});
            DropColumn("dbo.Sorteio", "UsuarioSorteado_Id");
        }
    }
}