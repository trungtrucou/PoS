using System.Web;
using System.Web.Optimization;

namespace Pos.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bunldes/template/js").Include(
                "~/Scripts/bootstrap.js",
                "~/Content/template/js/jquery.metisMenu.js",
                "~/Content/template/js/custom.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/application").Include(
                "~/app/init.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/template/css/custom.css",
                "~/Content/template/css/font-awesome.css"
                ));
        }
    }
}