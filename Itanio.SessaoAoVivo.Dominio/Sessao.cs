﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Itanio.SessaoAoVivo.Dominio
{
    public class Sessao : Entidade
    {
        
        public string Nome {  set; get; }
        public string Descricao { set; get; }
        public Arquivo Logotipo { set; get; }
        public string Cor {  set; get; }
        public DateTime DataHoraInicio { set; get; }

        public string CodigoYouTube { set; get; }
        public string Rodape { set; get; }

        public string NomeCanal { get; set; }
  

        public virtual ICollection<Usuario> Usuarios { get; set; }

        public virtual ICollection<Sorteio> Sorteios { get; set; }

    }
}