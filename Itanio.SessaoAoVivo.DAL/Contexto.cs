using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Carubbi.GenericRepository;
using Itanio.SessaoAoVivo.DAL.Mappings;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.DAL
{
    public class Contexto : DbContext, IContexto
    {
        public Contexto()
            : base("name=StringConexao")
        {
        }

        public IDbSet<TEntidade> ObterLista<TEntidade>() where TEntidade : class
        {
            return base.Set<TEntidade>();
        }

        public void Atualizar<TEntidade>(TEntidade objetoAntigo, TEntidade objetoNovo) where TEntidade : class
        {
            Entry(objetoAntigo).CurrentValues.SetValues(objetoNovo);
            Entry(objetoAntigo).State = EntityState.Modified;
        }

        public void Salvar()
        {
            SaveChanges();
        }

        IDbSet<T> IDbContext.Set<T>()
        {
            return ObterLista<T>();
        }

        public void ConfigurarParaApi()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        public T UnProxy<T>(T proxyObject) where T : class
        {
            var proxyCreationEnabled = Configuration.ProxyCreationEnabled;
            try
            {
                Configuration.ProxyCreationEnabled = false;
                var poco = Entry(proxyObject).CurrentValues.ToObject() as T;
                return poco;
            }
            finally
            {
                Configuration.ProxyCreationEnabled = proxyCreationEnabled;
            }
        }

        public void Recarregar<T>(T entidade) where T : class
        {
            Entry(entidade).Reload();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.ComplexType<Arquivo>().Ignore(x => x.Conteudo);

            modelBuilder.Entity<Parametro>().Property(o => o.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Configurations.Add(new SessaoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new SorteioConfiguration());
        }
    }
}