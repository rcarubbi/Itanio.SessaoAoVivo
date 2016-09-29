using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.ServicosAplicacao;
using Meebey.SmartIrc4net;
using System;
using System.Threading;
using System.Web.Mvc;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Controllers
{
    public class HomeController : BaseController
    {
        public IrcClient IrcClient
        {
            get
            {
                return Session["IrcClient"] as IrcClient;
            }
            set
            {
                Session["IrcClient"] = value;
            }
        }


        private Sessao Sessao { get; set; }



        public HomeController(IContexto contexto)
            : base(contexto)
        {

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
            IrcClient.OnConnected += IrcClient_OnConnected; ;
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

        private void QuitIrc()
        {
            if (IrcClient != null && IrcClient.IsConnected)
            {
                IrcClient.RfcQuit(Priority.Critical);
                IrcClient.Disconnect();
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