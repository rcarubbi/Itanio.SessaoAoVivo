using Itanio.SessaoAoVivo.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Itanio.SessaoAoVivo.DAL.Mappings
{
    public class SorteioConfiguration : EntityTypeConfiguration<Sorteio>
    {
        public SorteioConfiguration()
        {
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
