using System.Web;
using System.Web.Optimization;

namespace Consomi.net
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            #region Template Desing
            bundles.Add(new ScriptBundle("~/template/js").Include(
                       "~/fonts/easing/easing.min.js", "~/fonts/slick/slick.js", "~/fonts/slick/slick.min.js", "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                     "~/fonts/slick/slick.css",
                      "~/fonts/slick/slick-theme.css",
                       "~/Content/css/style.css"
                    ));

            #endregion
            //bundles.Add(new ScriptBundle("~/Scripts/js").Include(
            //          "~/FrontEnd/assets/libs/jquery/jquery.min.js",
            //          "~/FrontEnd/assets/libs/bootstrap/js/bootstrap.bundle.min.js",
            //          "~/FrontEnd/assets/libs/metismenu/metisMenu.min.js",
            //          "~/FrontEnd/assets/libs/simplebar/simplebar.min.js",
            //          "~/FrontEnd/assets/libs/node-waves/waves.min.js",
            //          "~/FrontEnd/assets/libs/waypoints/lib/jquery.waypoints.min.js",
            //          "~/FrontEnd/assets/libs/jquery.counterup/jquery.counterup.min.js",
            //          "~/FrontEnd/assets/libs/apexcharts/apexcharts.min.js",
            //          "~/FrontEnd/assets/js/pages/dashboard.init.js",
            //          "~/FrontEnd/assets/libs/datatables.net/js/jquery.dataTables.min.js",
            //          "~/FrontEnd/assets/libs/datatables.net-bs4/js/dataTables.bootstrap4.min.js",
            //          "~/FrontEnd/assets/libs/datatables.net-responsive/js/dataTables.responsive.min.js",
            //          "~/FrontEnd/assets/libs/datatables.net-responsive-bs4/js/responsive.bootstrap4.min.js",
            //          "~/FrontEnd/assets/js/pages/ecommerce-datatables.init.js",
            //          "~/FrontEnd/assets/js/app.js"));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //"~/FrontEnd/assets/css/bootstrap.min.css",
            //"~/FrontEnd/assets/css/app-dark.min.css",
            //"~/FrontEnd/assets/css/app-rtl.min.css",
            //"~/FrontEnd/assets/css/icons.min.css",
            //"~/FrontEnd/assets/css/app.min.css",
            //"~/FrontEnd/assets/css/line.css",
            //"~/FrontEnd/assets/libs/datatables.net-responsive-bs4/css/responsive.bootstrap4.min.css",
            //"~/FrontEnd/assets/libs/datatables.net-bs4/css/responsive.bootstrap4.min.css"
            //));
        }
    }
}
