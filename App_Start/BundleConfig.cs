using System.Web;
using System.Web.Optimization;

namespace Webtest
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"
                     // "~/Content/site.css"
                     ));


            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                      //"~/Content/themes/bootstrap.css",
                      "~/Content/AdminLTE_files/fullcalendar.css",
                      // "~/Content/AdminLTE_files/fullcalendar.print.css",
                      "~/Content/AdminLTE_files/AdminLTE.css",
                     // "~/Content/AdminLTE_files/_all-skins.css",
                      "~/Content/AdminLTE_files/font-awesome.css"
                      //"~/Content/AdminLTE_files/jquery-ui.css"
                      //"~/Content/AdminLTE_files/jquery-jvectormap-1.2.2.css",
                      //"~/Content/AdminLTE_files/jquery-ui.structure.css",
                      //"~/Content/AdminLTE_files/jquery-ui.theme.css"
                      ));


            bundles.Add(new ScriptBundle("~/bundles/librariesJS").Include(
                                //"~/Scripts/jquery-2.1.4.js",
                                //"~/Scripts/Calendar/loadcalendar.js",
                                //"~/Scripts/Calendar/selectjob.js",
                                //"~/Scripts/Calendar/SelectJobDate.js",
                                //"~/Scripts/AdminLTE_files/bootstrap.js",
                                "~/Scripts/jquery-ui.js",
                                //"~/Scripts/jquery.slimscroll.js",
                                //"~/Scripts/AdminLTE_files/fastclick.js",
                                //"~/Scripts/AdminLTE_files/app.js",
                                //"~/Scripts/AdminLTE_files/demo.js",
                                "~/Scripts/moment.js",
                                //"~/Scripts/Calendar/events_draggable.js",
                                "~/Scripts/AdminLTE_files/fullcalendar.js",
                                "~/Scripts/knockout-{version}.js"
                                ));
            bundles.Add(new ScriptBundle("~/bundles/Calendar").Include(
                                "~/Scripts/Calendar/loadcalendar.js",
                                "~/Scripts/Calendar/selectjob.js",
                                "~/Scripts/Calendar/SelectJobDate.js",
                                "~/Scripts/Calendar/events_draggable.js",
                                "~/Scripts/Calendar/addevent.js",
                                "~/Scripts/Calendar/addeventdate.js"
                ));
        }
    }
}
