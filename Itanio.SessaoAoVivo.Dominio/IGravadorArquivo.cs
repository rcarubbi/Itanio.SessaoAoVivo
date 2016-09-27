namespace Itanio.SessaoAoVivo.Dominio
{
    public interface IGravadorArquivo
    {
        void Salvar(Arquivo arquivo);
        byte[] Obter(string nome);
    }
}