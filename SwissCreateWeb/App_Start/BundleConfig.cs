using System.Web;
using System.Web.Optimization;

namespace SwissCreateWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(                        
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootbox").Include(
                        "~/Scripts/bootbox.min.js"));

            //bundles.Add(new StyleBundle("~/bundles/jsgridcss").Include(
            //            "~/Content/jsGrid/css/jsgrid.css",
            //            "~/Content/jsGrid/css/theme.css"));

            //bundles.Add(new ScriptBundle("~/bundles/jsgrid").Include(
            //            "~/Content/jsGrid/jsgrid.core.js",
            //            "~/Content/jsGrid/jsgrid.load-indicator.js",
            //            "~/Content/jsGrid/jsgrid.load-strategies.js",
            //            "~/Content/jsGrid/jsgrid.sort-strategies.js",
            //            "~/Content/jsGrid/jsgrid.field.js",
            //            "~/Content/jsGrid/jsgrid.field.text.js",
            //            "~/Content/jsGrid/jsgrid.field.number.js",
            //            "~/Content/jsGrid/jsgrid.field.select.js",
            //            "~/Content/jsGrid/jsgrid.field.checkbox.js",
            //            "~/Content/jsGrid/jsgrid.field.textarea.js",
            //            "~/Content/jsGrid/jsgrid.field.control.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                       "~/Scripts/angular.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
