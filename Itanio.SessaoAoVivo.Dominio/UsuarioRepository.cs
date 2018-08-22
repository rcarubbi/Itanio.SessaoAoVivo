using System.Linq;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class UsuarioRepository
    {
        private readonly IContexto _contexto;

        public UsuarioRepository(IContexto contexto)
        {
            _contexto = contexto;
        }

        public Usuario ObterPorEmail(string email)
        {
            return _contexto.ObterLista<Usuario>().FirstOrDefault(x => x.Email == email);
        }


        public Usuario ObterPorNick(string nick)
        {
            return _contexto.ObterLista<Usuario>().FirstOrDefault(x => x.Nick == nick);
        }

        public void Add(Usuario usuario)
        {
            _contexto.ObterLista<Usuario>().Add(usuario);
        }

        public void Atualizar(Usuario usuarioCorrente, Usuario usuario)
        {
            usuario.DataCriacao = usuarioCorrente.DataCriacao;
            usuario.Id = usuarioCorrente.Id;
            _contexto.Atualizar(usuarioCorrente, usuario);
        }
    }
}