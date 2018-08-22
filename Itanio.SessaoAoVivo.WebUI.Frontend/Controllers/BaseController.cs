using System.IO;
using System.Web.Mvc;
using System.Web.Routing;
using Itanio.SessaoAoVivo.Dominio;
using Meebey.SmartIrc4net;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Controllers
{
    public class BaseController : Controller
    {
        protected IContexto _contexto;

        protected Usuario _usuarioLogado;

        public BaseController(IContexto contexto)
        {
            _contexto = contexto;
        }

        public IrcClient IrcClient
        {
            get => Session["IrcClient"] as IrcClient;
            set => Session["IrcClient"] = value;
        }

        protected void QuitIrc()
        {
            if (IrcClient != null && IrcClient.IsConnected)
            {
                IrcClient.RfcQuit(Priority.Critical);
                IrcClient.Disconnect();
            }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            /*    if (!Request.IsAjaxRequest())
                {
                    base.OnException(filterContext);
                    filterContext.ExceptionHandled = true;
                    Exception e = filterContext.Exception;
                    ViewData["Exception"] = e; // pass the exception to the view
                    filterContext.Result = View("Error");
                }*/
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                    viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                    ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            /* ViewBag.AreaConhecimento = Parametro.AREA_CONHECIMENTO;
             ViewBag.Assunto = Parametro.ASSUNTO;
             ViewBag.Curso = Parametro.CURSO;
             ViewBag.Aula = Parametro.AULA;
             ViewBag.AreaConhecimentoPlural = Parametro.AREA_CONHECIMENTO_PLURAL;
             ViewBag.AssuntoPlural = Parametro.ASSUNTO_PLURAL;
             ViewBag.CursoPlural = Parametro.CURSO_PLURAL;
             ViewBag.AulaPlural = Parametro.AULA_PLURAL;*/

            var usuarioRepo = new UsuarioRepository(_contexto);
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                _usuarioLogado = usuarioRepo.ObterPorEmail(HttpContext.User.Identity.Name);
                ViewBag.IdUsuarioLogado = _usuarioLogado != null ? _usuarioLogado.Id.ToString() : string.Empty;
            }
        }
    }
}