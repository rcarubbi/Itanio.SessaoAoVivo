using System.Web.Mvc;

namespace Itanio.SessaoAoVivo.WebUI.Frontend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}