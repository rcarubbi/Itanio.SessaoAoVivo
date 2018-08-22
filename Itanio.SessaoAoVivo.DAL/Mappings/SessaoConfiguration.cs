using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.DAL.Mappings
{
    public class SessaoConfiguration : EntityTypeConfiguration<Sessao>
    {
        public SessaoConfiguration()
        {
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            HasMany(x => x.Usuarios).WithRequired(x => x.Sessao);
            HasMany(x => x.Sorteios).WithRequired(x => x.Sessao);
        }
    }
}