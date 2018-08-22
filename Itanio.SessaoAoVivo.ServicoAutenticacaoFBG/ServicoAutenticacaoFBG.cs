using System.Collections.Generic;
using System.Net;
using Itanio.SessaoAoVivo.Dominio;
using Newtonsoft.Json;

namespace Itanio.SessaoAoVivo.ServicoAutenticacaoFBG
{
    public class ServicoAutenticacaoFBG : IServicoAutenticacao
    {
        public bool Autenticar(Usuario usuario)
        {
            var client = new WebClient();
            var response =
                client.DownloadString($"http://fbg.org.br/api/Login/Autenticar/{usuario.Email}/{usuario.Senha}");
            var result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            return result["resultadoAutenticacao"] == 2;
        }
    }
}