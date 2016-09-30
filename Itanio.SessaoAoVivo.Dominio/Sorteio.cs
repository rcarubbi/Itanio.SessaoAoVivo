namespace Itanio.SessaoAoVivo.Dominio
{
    public class Sorteio : Entidade
    {
        public string Descricao { get; set; }

        public bool Feito { get; set; }

        public virtual Sessao Sessao { get; set; }

        public virtual Usuario UsuarioSorteado { get; set; }
    }
}
