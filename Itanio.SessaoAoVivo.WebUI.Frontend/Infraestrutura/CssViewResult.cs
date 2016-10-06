using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Itanio.SessaoAoVivo.WebUI.Frontend.Infraestrutura
{
    public class CssViewResult : PartialViewResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.ContentType = "text/css";
            base.ExecuteResult(context);
        }


        public CssViewResult(object model)
        {
            ViewData = new ViewDataDictionary(model);
        }
    }
}