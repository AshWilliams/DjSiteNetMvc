using System.Web;
using System.Web.Optimization;

namespace DjSite
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.11.3.js"));

            
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/styles-3.css"));
            
        }
    }
}