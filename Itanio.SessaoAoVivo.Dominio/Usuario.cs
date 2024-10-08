﻿namespace Itanio.SessaoAoVivo.Dominio
{
    public class Usuario : Entidade
    {
        public string Nick { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
        public virtual Sessao Sessao { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }
    }
}