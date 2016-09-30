namespace Itanio.SessaoAoVivo.Dominio
{
    public class SorteioRepository
    {

        private IContexto _contexto;
        public SorteioRepository(IContexto contexto)
        {
            _contexto = contexto;
        }

        public void Add(Sorteio sorteio)
        {
            _contexto.ObterLista<Sorteio>().Add(sorteio);
        }
    }
}
