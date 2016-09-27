namespace Itanio.SessaoAoVivo.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CidadeEUf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Cidade", c => c.String());
            AddColumn("dbo.Usuario", "UF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuario", "UF");
            DropColumn("dbo.Usuario", "Cidade");
        }
    }
}
