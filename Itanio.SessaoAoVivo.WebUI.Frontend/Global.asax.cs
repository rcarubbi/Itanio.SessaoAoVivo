using Itanio.SessaoAoVivo.DAL;
using Itanio.SessaoAoVivo.Dominio;
using Meebey.SmartIrc4net;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Itanio.SessaoAoVivo.WebUI.Frontend
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var contexto = new Contexto())
            {
                RepositorioParametro parametroRepo = new RepositorioParametro(contexto);
                Parametro.PROJETO = parametroRepo.ObterValorPorChave(Parametro.CHAVE_PROJETO);
                Parametro.SENHA_SALAS = parametroRepo.ObterValorPorChave(Parametro.CHAVE_SENHA_SALAS);
                Parametro.SERVIDOR_IRC = parametroRepo.ObterValorPorChave(Parametro.CHAVE_SERVIDOR_IRC);
            }
        }



        protected void Session_End()
        {
            var ircClient = Session["IrcClient"] as IrcClient;
            if (ircClient != null && ircClient.IsConnected)
            {
                ircClient.RfcQuit(Priority.Critical);
                ircClient.Disconnect();
            }
        }
    }
}
