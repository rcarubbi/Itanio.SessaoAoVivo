using Itanio.SessaoAoVivo.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Itanio.SessaoAoVivo.ServicoAutenticacaoFBG
{
    public class ServicoAutenticacaoFBG : IServicoAutenticacao
    {
        public bool Autenticar(Usuario usuario)
        {
            WebClient client = new WebClient();
            string response = client.DownloadString($"http://fbg.org.br/api/Login/Autenticar/{usuario.Email}/{usuario.Senha}");
            var result = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response);
            return result["resultadoAutenticacao"] == 2;
        }
    }
}
