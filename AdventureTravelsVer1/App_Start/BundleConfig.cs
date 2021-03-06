﻿using System.Web;
using System.Web.Optimization;

namespace AdventureTravelsVer1
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/css/bootstrap.css",
                     "~/Content/css/font-awesome.css",
                     "~/Content/css/site.css"
                   ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundle/base").Include(
               "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/bootstrap.js"
               ));

            bundles.Add(new ScriptBundle("~/bundles/Script-custom-editor").Include(
           "~/Scripts/script-custom-editor.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
          "~/Scripts/jquery-ui-{version}.js"));
            //css   
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include(
                   "~/Content/jquery-ui.css"));
        }
    }
}
