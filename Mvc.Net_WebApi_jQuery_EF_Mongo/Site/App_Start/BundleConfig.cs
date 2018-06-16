using System.Web;
using System.Web.Optimization;

namespace Site
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                        "~/Scripts/jquery-3.3.1.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/bootstrap.min.js", 
                        "~/Scripts/site.js"

                        ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Styles/bootstrap.min.css",
                      "~/Styles/site.css"));

          //  BundleTable.EnableOptimizations = true;
        }
    }
}
