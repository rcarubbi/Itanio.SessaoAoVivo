using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var contexto = new Contexto())
            {
                RepositorioParametro parametroRepo = new RepositorioParametro(contexto);
                Parametro.PROJETO = parametroRepo.ObterValorPorChave(Parametro.CHAVE_PROJETO);
                Parametro.SENHA_SALAS = parametroRepo.ObterValorPorChave(Parametro.CHAVE_SENHA_SALAS);
                Parametro.SERVIDOR_IRC = parametroRepo.ObterValorPorChave(Parametro.CHAVE_SERVIDOR_IRC);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
