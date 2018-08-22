using System.Data.Entity;
using Carubbi.GenericRepository;

namespace Itanio.SessaoAoVivo.Dominio
{
    public interface IContexto : IDbContext
    {
        void Salvar();


        void Atualizar<TEntidade>(TEntidade objetoAntigo, TEntidade objetoNovo) where TEntidade : class;

        IDbSet<TEntidade> ObterLista<TEntidade>() where TEntidade : class;
        void ConfigurarParaApi();

        T UnProxy<T>(T proxyObject) where T : class;
        void Recarregar<T>(T entidade) where T : class;
    }
}