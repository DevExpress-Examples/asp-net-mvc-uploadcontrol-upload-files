using System.Web;
using System.Web.UI;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.Web.ASPxUploadControl;

namespace UploadControl.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult UploadControlCallbackAction() {
            UploadControlExtension.GetUploadedFiles("uc", UploadControlDemosHelper.ValidationSettings, UploadControlDemosHelper.uc_FileUploadComplete);
            return null;
        }
    }

    public class UploadControlDemosHelper {
        public const string UploadDirectory = "~/Content/UploadControl/UploadFolder/";

        public static readonly ValidationSettings ValidationSettings = new ValidationSettings {
            AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".jpe", ".gif", ".bmp", },
            MaxFileSize = 20971520,
        };

        public static void uc_FileUploadComplete(object sender, FileUploadCompleteEventArgs e) {
            if(e.UploadedFile.IsValid) {
                string resultFilePath = HttpContext.Current.Request.MapPath(UploadDirectory + e.UploadedFile.FileName);
                //e.UploadedFile.SaveAs(resultFilePath, true);//Code Central Mode - Uncomment This Line
                IUrlResolutionService urlResolver = sender as IUrlResolutionService;
                if(urlResolver != null) {
                    e.CallbackData = urlResolver.ResolveClientUrl(resultFilePath);
                }
            }
        }
    }
}