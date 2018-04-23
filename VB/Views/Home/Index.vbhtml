<script type="text/javascript">
    function OnClick(s, e) {
        uc.Upload();
    }
    function OnFileUploadComplete(s, e) {
        if (e.callbackData !== "") {
            alert(e.callbackData);
        }
        else {
            alert("The selected file was not uploaded.");
        }
    }
</script>
@Using (Html.BeginForm("UploadControlCallbackAction", "Home", FormMethod.Post))
    Html.RenderPartial("UploadControlPartial")
    @Html.DevExpress().Button( _
    Sub(button)
        button.Name = "btnUploadFile"
        button.Text = "Upload File"
        button.ClientSideEvents.Click = "OnClick"
    End Sub).GetHtml()
End Using