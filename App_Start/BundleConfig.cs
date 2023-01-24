using System.Web;
using System.Web.Optimization;

namespace CDNTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));


            /*
             React js
             */
            bundles.Add(new Bundle("~/bundles/react").Include(
                      "~/Scripts/react_Script/react.production.min.js",
                      "~/Scripts/react_Script/react-dom.production.min.js",
                      "~/Scripts/react_Script/babel.min.js"));

            bundles.Add(new Bundle("~/bundles/react_components").Include(
                      "~/Scripts/about_component_React/about_test_React.js",
                      "~/Scripts/about_component_React/about_React.js"));

         
           

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
