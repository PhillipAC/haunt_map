using System.Web;
using System.Web.Optimization;

namespace haunt_map
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include("~/Scripts/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/googlemaps").Include("~/Scripts/googlemap-form.js"));
            bundles.Add(new ScriptBundle("~/bundles/googlemapicons").Include("~/Scripts/googlemap-icon.js"));
            bundles.Add(new StyleBundle("~/bundles/bootstrapcss").Include("~/Content/bootstrap.min.css", "~/Content/bootstrap-theme.min.css"));
            bundles.Add(new StyleBundle("~/bundles/Site").Include("~/Content/Site.css"));
        }
    }
}