using System;
using System.Drawing;
using System.Threading;
using System.Web.Mvc;
using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.ServicosAplicacao;
using Itanio.SessaoAoVivo.WebUI.Frontend.Infraestrutura;
using Itanio.SessaoAoVivo.WebUI.Frontend.Models;
using Meebey.SmartIrc4net;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IContexto contexto)
            : base(contexto)
        {
        }

        private Sessao Sessao { get; set; }

        public ActionResult Tema()
        {
            var repo = new SessaoRepository(_contexto, new GravadorArquivo());
            Sessao = repo.ObterUltimaAtiva();

            if (Sessao != null)
            {
                var cor = ColorTranslator.FromHtml(Sessao.Cor);
                return new CssViewResult(new TemaViewModel
                {
                    Cor = Sessao.Cor,
                    Red = cor.R,
                    RedLight = cor.R + 50,
                    RedDark = cor.R - 50,
                    Green = cor.G,
                    GreenLight = cor.G + 50,
                    GreenDark = cor.G - 50,
                    Blue = cor.B,
                    BlueLight = cor.B + 50,
                    BlueDark = cor.B - 50
                });
            }

            return new EmptyResult();
        }

        [Authorize]
        public ActionResult Index()
        {
            var repo = new SessaoRepository(_contexto, new GravadorArquivo());
            Sessao = repo.ObterUltimaAtiva();

            if (Sessao == null)
            {
                TempData["TipoMensagem"] = "error";
                TempData["Mensagem"] = "Nenhuma sessão está ativa";
                TempData["TituloMensagem"] = "Erro";
                return RedirectToAction("Login", "Autenticacao");
            }


            ConectarIrc();
            Sessao.Usuarios.Add(_usuarioLogado);
            _contexto.Salvar();

            return View(Sessao);
        }

        private void ConectarIrc()
        {
            QuitIrc();
            IrcClient = new IrcClient();
            IrcClient.OnConnected += IrcClient_OnConnected;
            ;
            IrcClient.Connect(Parametro.SERVIDOR_IRC, 6667);
        }

        private void IrcClient_OnConnected(object sender, EventArgs e)
        {
            var tempNick = string.Concat(_usuarioLogado.Nick, "-" + DateTime.Now.ToString("ssfff"));

            IrcClient.Login(tempNick, _usuarioLogado.Nome, 0);
            Thread.Sleep(1000);
            if (!IrcClient.IsJoined(Sessao.NomeCanal))
            {
                Thread.Sleep(1000);
                IrcClient.RfcJoin(Sessao.NomeCanal, Parametro.SENHA_SALAS, Priority.Critical);
                Thread.Sleep(1000);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EnviarMensagem(string mensagem)
        {
            var repo = new SessaoRepository(_contexto, new GravadorArquivo());
            Sessao = repo.ObterUltimaAtiva();

            IrcClient.SendMessage(SendType.Message, Sessao.NomeCanal, mensagem, Priority.Critical);

            return new HttpStatusCodeResult(200, "OK");
        }
    }
}