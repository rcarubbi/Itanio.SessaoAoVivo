using System.Linq;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class RepositorioParametro
    {
        private readonly IContexto _contexto;

        public RepositorioParametro(IContexto contexto)
        {
            _contexto = contexto;
        }

        public string ObterValorPorChave(string chave)
        {
            return _contexto.ObterLista<Parametro>().Single(c => c.Chave == chave).Valor;
        }
    }
}