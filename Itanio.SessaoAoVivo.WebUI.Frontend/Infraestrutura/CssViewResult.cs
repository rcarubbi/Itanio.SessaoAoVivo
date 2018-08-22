using System.Web.Mvc;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Infraestrutura
{
    public class CssViewResult : PartialViewResult
    {
        public CssViewResult(object model)
        {
            ViewData = new ViewDataDictionary(model);
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.ContentType = "text/css";
            base.ExecuteResult(context);
        }
    }
}