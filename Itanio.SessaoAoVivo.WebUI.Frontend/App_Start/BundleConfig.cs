using System.Web.Optimization;

namespace Itanio.SessaoAoVivo.WebUI.Frontend
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/slimscroll/jquery.slimscroll.min.js",
                "~/Scripts/jquery.dropdown/jquery.dropdown.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Scripts/material-kit/material.min.js",
                "~/Scripts/material-kit/nouislider.min.js",
                "~/Scripts/material-kit/material-kit.js",
                "~/Scripts/toastr/toastr.min.js",
                "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/font-awesome.css",
                "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/csscustom").Include(
                "~/Content/material-kit/material-kit.css",
                "~/Content/toastr/toastr.min.css",
                "~/Content/jquery.dropdown/jquery.dropdown.css",
                "~/Content/Site.css"));
        }
    }
}