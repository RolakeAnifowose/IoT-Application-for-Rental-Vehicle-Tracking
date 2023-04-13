using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// using Azure.Storage.Blobs;
using System.Net;
using System;

namespace SDWebApp.Pages;

public class ArchitectureModel : PageModel
{
    public IActionResult OnGet()
    {
        //Get the image from the Azure storage account
        var imageFilePath = "https://speeddatastorage.blob.core.windows.net/images/Diagram.png"; 
        
        // Read the image file as a byte array
        var wc = new System.Net.WebClient();
        var imageData = wc.DownloadData(imageFilePath);

        // Determine the MIME type of the image
        var mimeType = "image/png"; 
        
        // Return the image as a FileResult
        return new FileContentResult(imageData, mimeType);
    }
}

