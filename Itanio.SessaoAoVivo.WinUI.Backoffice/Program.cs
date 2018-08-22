using System;
using System.Windows.Forms;
using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var contexto = new Contexto())
            {
                var parametroRepo = new RepositorioParametro(contexto);
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