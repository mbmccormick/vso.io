using System.Web;
using System.Web.Optimization;

namespace vso.io
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/ai").Include(
                      "~/Scripts/ai.{version}-build12287.js"));

            bundles.Add(new ScriptBundle("~/bundles/vss.sdk").Include(
                      "~/Scripts/VSS.SDK.js"));

            bundles.Add(new ScriptBundle("~/bundles/site").Include(
                      "~/Scripts/Site.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
