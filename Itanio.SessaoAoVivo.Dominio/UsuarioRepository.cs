using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class UsuarioRepository
    {
        private IContexto _contexto;
        public UsuarioRepository(IContexto contexto)
        {
            _contexto = contexto;
        }

        public Usuario ObterPorEmail(string email)
        {
            return _contexto.ObterLista<Usuario>().FirstOrDefault(x => x.Email == email);
        }
    }
}
