using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class Sorteio : Entidade
    {
        public string Descricao { get; set; }

        public bool Feito { get; set; }

        public virtual Sessao Sessao { get; set; }


    }
}
