@Html.DevExpress().UploadControl( _
    Sub(settings)
            settings.Name = "uc"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "UploadControlCallbackAction"}
            settings.ClientSideEvents.FileUploadComplete = "OnFileUploadComplete"
            settings.ValidationSettings.Assign(UploadControl.Controllers.UploadControlDemosHelper.ValidationSettings)
    End Sub).GetHtml()