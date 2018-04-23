Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.UI
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.Web

Namespace UploadControl.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function UploadControlCallbackAction() As ActionResult
            UploadControlExtension.GetUploadedFiles("uc", UploadControlDemosHelper.ValidationSettings, AddressOf UploadControlDemosHelper.uc_FileUploadComplete)
			Return Nothing
		End Function
	End Class

	Public Class UploadControlDemosHelper
		Public Const UploadDirectory As String = "~/Content/UploadControl/UploadFolder/"

		Public Shared ReadOnly ValidationSettings As New UploadControlValidationSettings() With {.AllowedFileExtensions = New String() {".jpg", ".jpeg", ".jpe", ".gif", ".bmp"}, .MaxFileSize = 20971520}

		Public Shared Sub uc_FileUploadComplete(ByVal sender As Object, ByVal e As FileUploadCompleteEventArgs)
			If e.UploadedFile.IsValid Then
				Dim resultFilePath As String = HttpContext.Current.Request.MapPath(UploadDirectory & e.UploadedFile.FileName)
				'e.UploadedFile.SaveAs(resultFilePath, True)'Code Central Mode - Uncomment This Line
				Dim urlResolver As IUrlResolutionService = TryCast(sender, IUrlResolutionService)
				If urlResolver IsNot Nothing Then
					e.CallbackData = urlResolver.ResolveClientUrl(resultFilePath)
				End If
			End If
		End Sub
	End Class
End Namespace