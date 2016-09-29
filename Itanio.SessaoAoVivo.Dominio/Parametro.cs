namespace Itanio.SessaoAoVivo.Dominio
{
    public class Parametro : Entidade
    {

        public string Chave { get;  set; }
        public  string Valor { get; set; }


        public const string CHAVE_PROJETO = "Projeto";
        public const string CHAVE_SERVIDOR_IRC = "ServidorIRC";
        public const string CHAVE_SENHA_SALAS = "SenhaSalas";

        public static string PROJETO { get; set; }

        public static string SERVIDOR_IRC { get; set; }

        public static string SENHA_SALAS { get; set; }



    }
}
