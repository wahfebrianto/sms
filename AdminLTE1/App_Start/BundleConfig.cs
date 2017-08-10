using System.Web.Optimization;

namespace AdminLTE1.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/css/bootstrap.css")
                .Include("~/Content/css/select2.css")
                .Include("~/Content/css/AdminLTE.css")
                .Include("~/Content/css/skins/skin-blue.css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Scripts/plugins/jquery-ui/jquery-ui.min.css")
                .Include("~/Content/animate.css")
                .Include("~/Content/style.css")
                .Include("~/Content/css/bootstrap-select.css")
                .Include("~/fonts/font-awesome/css/font-awesome.min.css")
                .Include("~/Content/plugins/dataTables/datatables.min.css")
                .Include("~/Content/plugins/sweetalert/sweetalert.css")
                .Include("~/Content/css/datepicker3.css")
                .Include("~/Content/css/bootstrap-datetimepicker.css")
                .Include("~/Content/css/custom.css")
                .Include("~/Content/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css")
                .Include("~/Content/plugins/bootstrap-tagsinput/bootstrap-tagsinput.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/jquery/jquery-2.2.4.js")
                //.Include("~/Content/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/js/plugins/select2/select2.full.js")
                .Include("~/Content/js/plugins/moment/moment.js")
                .Include("~/Content/js/plugins/icheck/icheck.js")
                .Include("~/Content/js/plugins/validator.js")
                .Include("~/Content/js/plugins/inputmask/jquery.inputmask.bundle.js")
                .Include("~/Content/js/app.js")
                .Include("~/Content/js/init.js")
                .Include("~/Content/js/plugins/jqueryNumber/jquery.number.min.js")
                .Include("~/Scripts/plugins/jquery-ui/jquery-ui.min.js")
                .Include("~/Scripts/bootstrap.min.js")
                .Include("~/Scripts/bootstrap-select.js")
                .Include("~/Scripts/plugins/dataTables/datatables.min.js")
                .Include("~/Scripts/plugins/metisMenu/metisMenu.min.js","~/Scripts/plugins/pace/pace.min.js","~/Scripts/app/inspinia.js")
                .Include("~/Scripts/plugins/sweetalert/sweetalert.min.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datetimepicker.min.js")
                .Include("~/Content/js/main.js")
                .Include("~/Scripts/plugins/dualListbox/jquery.bootstrap-duallistbox.js")
                .Include("~/Scripts/plugins/bootstrap-tagsinput/bootstrap-tagsinput.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
            bundles.IgnoreList.Clear();
        }
    }
}