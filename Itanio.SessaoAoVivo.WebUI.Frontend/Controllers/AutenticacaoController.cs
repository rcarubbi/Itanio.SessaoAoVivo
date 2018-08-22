using System.Web.Mvc;
using System.Web.Security;
using Carubbi.ServiceLocator;
using Itanio.SessaoAoVivo.Dominio;
using Itanio.SessaoAoVivo.ServicosAplicacao;
using Itanio.SessaoAoVivo.WebUI.Frontend.Models;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Controllers
{
    [AllowAnonymous]
    public class AutenticacaoController : BaseController
    {
        public AutenticacaoController(IContexto contexto)
            : base(contexto)
        {
        }

        // GET: Autenticacao
        public ActionResult Login()
        {
            string[] ufs =
            {
                "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI",
                "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"
            };
            ViewBag.Ufs = new SelectList(ufs);
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var autenticacao = ImplementationResolver.Resolve<IServicoAutenticacao>();

                var usuario = LoginViewModel.ToEntity(viewModel);

                /* if (autenticacao.Autenticar(usuario))
                 {*/
                var usuRepo = new UsuarioRepository(_contexto);

                var usuarioCorrente = usuRepo.ObterPorEmail(usuario.Email);
                var sessaoRepo = new SessaoRepository(_contexto, new GravadorArquivo());
                var sessao = sessaoRepo.ObterUltimaAtiva();
                usuario.Sessao = sessao;

                if (usuario.Sessao == null)
                {
                    ModelState.AddModelError("", "Nenhuma sessão está ativa");
                    return Json(
                        new
                        {
                            ValidationSummary = RenderRazorViewToString("_errosValidacao", viewModel),
                            Autenticado = false
                        }, JsonRequestBehavior.AllowGet);
                }

                FormsAuthentication.SetAuthCookie(viewModel.Email, viewModel.LembrarMe);
                var url = FormsAuthentication.GetRedirectUrl(viewModel.Email, viewModel.LembrarMe);

                if (usuarioCorrente == null)
                    usuRepo.Add(usuario);
                else
                    usuRepo.Atualizar(usuarioCorrente, usuario);
                _contexto.Salvar();
                return Json(new {Url = url, Autenticado = true}, JsonRequestBehavior.AllowGet);
                /* }
                 else
                 {
                     ModelState.AddModelError("UsuarioOuSenhaInvalidos", "Usuário ou Senha inválidos");
                 }*/
            }

            return Json(
                new {ValidationSummary = RenderRazorViewToString("_errosValidacao", viewModel), Autenticado = false},
                JsonRequestBehavior.AllowGet);
        }


        [Authorize]
        public ActionResult Sair()
        {
            QuitIrc();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}