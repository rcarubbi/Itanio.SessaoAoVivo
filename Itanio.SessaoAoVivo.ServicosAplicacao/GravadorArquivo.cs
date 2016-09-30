using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.ServicosAplicacao
{
    public class GravadorArquivo : IGravadorArquivo
    {

        GravadorArquivoServices.IGravadorArquivoService _servico;
        public GravadorArquivo()
        {
            _servico = new GravadorArquivoServices.GravadorArquivoServiceClient();
        }

        public byte[] Obter(string nome)
        {
            return _servico.Obter(nome);
        }

        public void Salvar(Arquivo arquivo)
        {
            _servico.Salvar(new GravadorArquivoServices.ArquivoDTO
            {
                Conteudo = arquivo.Conteudo,
                Nome = arquivo.Nome
            });
        }
    }
}
