using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.DAL.Mappings
{
    public class SorteioConfiguration : EntityTypeConfiguration<Sorteio>
    {
        public SorteioConfiguration()
        {
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            HasOptional(x => x.UsuarioSorteado);
        }
    }
}