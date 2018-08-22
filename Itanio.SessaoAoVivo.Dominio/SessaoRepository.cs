using System;
using System.Linq;
using System.Transactions;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class SessaoRepository
    {
        private readonly IContexto _contexto;
        private readonly IGravadorArquivo _gravadorArquivo;

        public SessaoRepository(IContexto contexto, IGravadorArquivo gravador)
        {
            _contexto = contexto;
            _gravadorArquivo = gravador;
        }

        public void Add(Sessao sessao)
        {
            using (var tx = new TransactionScope())
            {
                if (!string.IsNullOrWhiteSpace(sessao.Logotipo.Nome))
                    _gravadorArquivo.Salvar(sessao.Logotipo);
                _contexto.ObterLista<Sessao>().Add(sessao);
                tx.Complete();
            }
        }

        public void Atualizar(Sessao sessao)
        {
            var sessaoAtual = _contexto.ObterLista<Sessao>().Find(sessao.Id);
            _contexto.Atualizar(sessaoAtual, sessao);
        }

        public Sessao ObterUltimaAtiva()
        {
            var sessao = _contexto.ObterLista<Sessao>().Where(x => x.Ativo).OrderByDescending(x => x.DataCriacao)
                .FirstOrDefault();
            if (sessao != null)
                if (sessao.DataHoraInicio > DateTime.Now)
                    sessao = null;

            if (sessao != null && !string.IsNullOrWhiteSpace(sessao.Logotipo.Nome))
                sessao.Logotipo.Conteudo = _gravadorArquivo.Obter(sessao.Logotipo.Nome);
            return sessao;
        }
    }
}