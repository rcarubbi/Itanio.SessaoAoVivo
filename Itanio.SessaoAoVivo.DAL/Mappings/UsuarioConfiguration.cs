using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.DAL.Mappings
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}