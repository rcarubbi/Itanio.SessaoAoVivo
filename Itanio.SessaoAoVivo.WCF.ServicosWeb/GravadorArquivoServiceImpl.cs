using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Itanio.SessaoAoVivo.WCF.ServicosWeb
{
    public class GravadorArquivoServiceImpl : IGravadorArquivoService
    {
        public byte[] Obter(string nome)
        {
            var caminho = HttpContext.Current.Server.MapPath("~/content/logotipos");
            return File.ReadAllBytes(Path.Combine(caminho, nome));
        }

        public void Salvar(ArquivoDTO arquivo)
        {
            var caminho = HttpContext.Current.Server.MapPath("~/content/logotipos");
            File.WriteAllBytes(Path.Combine(caminho, Path.GetFileName(arquivo.Nome)), arquivo.Conteudo);
        }
    }
}
