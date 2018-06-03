using System.Web;
using System.Web.Optimization;

namespace booktest
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/evenue").Include(
                        "~/Scripts/evenue/jquery.js",
                        "~/Scripts/evenue/bootstrap.min.js",
                        "~/Scripts/evenue/owl.carousel.min.js",
                        "~/Scripts/evenue/mousescroll.js",
                        "~/Scripts/evenue/smoothscroll.js",
                        "~/Scripts/evenue/jquery.prettyPhoto.js",
                        "~/Scripts/evenue/jquery.inview.min.js",
                        "~/Scripts/evenue/wow.min.js"));


            bundles.Add(new StyleBundle("~/Content/evenuecss").Include(
                        "~/Content/evenuecss/bootstrap.min.css",
                        "~/Content/evenuecss/font-awesome.min.css",
                        "~/Content/evenuecss/animate.min.css",
                        "~/Content/evenuecss/owl.carousel.css",
                        "~/Content/evenuecss/owl.transitions.css",
                        "~/Content/evenuecss/prettyPhoto.css",
                        "~/Content/evenuecss/magnific-popup.css",
                        "~/Content/evenuecss/gallery-1.css",
                        "~/Content/evenuecss/styles.css"
                       ));

        }
    }
}
