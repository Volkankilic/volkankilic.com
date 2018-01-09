using System.Web;
using System.Web.Optimization;

namespace CodeRepository.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                       "~/Scripts/material.min.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/angular.min.js",
                       "~/Scripts/volkankilicJS.js",
                       "~/Scripts/jquery-1.10.2.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.min.css",
                     "~/Content/font-awesome.min.css",
                     "~/Content/styles.css",
                     "~/Content/Site.css"
                       ));


            BundleTable.EnableOptimizations = true;
        }
    }
}