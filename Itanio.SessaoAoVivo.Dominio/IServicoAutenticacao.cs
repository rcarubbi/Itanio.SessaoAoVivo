namespace Itanio.SessaoAoVivo.Dominio
{
    public interface IServicoAutenticacao
    {
        bool Autenticar(Usuario usuario);
    }
}