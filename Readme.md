<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [UploadControlPartial.cshtml](./CS/Views/Home/UploadControlPartial.cshtml)
<!-- default file list end -->
# UploadControl - How to upload a file via AJAX
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4381/)**
<!-- run online end -->


<p>This example is a standalone illustration of the <a href="http://demos.devexpress.com/MVC/UploadControl/Callbacks"><u>File Upload - AJAX Uploading</u></a> demo. It illustrates how to upload a file via the MVC UploadControl Extension.</p><p>- Specify the UploadControl settings: define the Name property and the CallbackRouteValues.Action method that should handle the file uploading;<br />
- Wrap the UploadControl definition/PartialView within a form in order to post the selected file into the server memory;<br />
- Introduce any custom trigger that should upload a file on demand, for example, the MVC Button Extension;<br />
- Handle the client-side Button Click event. Call the client-side Upload method to post the selected file into the server memory;<br />
- Handle the CallbackRouteValues.Action method. Retrieve the posted file via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcUploadControlExtension_GetUploadedFilestopic"><u>UploadControlExtension.GetUploadedFiles</u></a> method. Specify the uploading ValidationSettings and the "UploadComplete" handler as parameters;<br />
- Handle the "UploadComplete" handler and save the posted file.</p><p>If it is necessary to pass any information to the client:<br />
- Use the "UploadComplete" event handler's e.CallbackData property (take special note of the character case);<br />
- Retrieve the passed information in the client-side FileUploadComplete event handler via the e.callbackData property (take special note of the character case).</p>

<br/>


