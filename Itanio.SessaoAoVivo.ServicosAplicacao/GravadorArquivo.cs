using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.ServicosAplicacao.GravadorArquivoServices;

namespace Itanio.SessaoAoVivo.ServicosAplicacao
{
    public class GravadorArquivo : IGravadorArquivo
    {
        private readonly IGravadorArquivoService _servico;

        public GravadorArquivo()
        {
            _servico = new GravadorArquivoServiceClient();
        }

        public byte[] Obter(string nome)
        {
            return _servico.Obter(nome);
        }

        public void Salvar(Arquivo arquivo)
        {
            _servico.Salvar(new ArquivoDTO
            {
                Conteudo = arquivo.Conteudo,
                Nome = arquivo.Nome
            });
        }
    }
}