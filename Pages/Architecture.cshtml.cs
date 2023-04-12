using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDWebApp.Pages;

public class ArchitectureModel : PageModel
{
    public IActionResult OnGet()
    {
        // Replace "image.jpg" with the filename of your image
        var imageFilePath = "Images/Diagram.png"; 
        
        // Read the image file as a byte array
        var imageData = System.IO.File.ReadAllBytes(imageFilePath);

        // Determine the MIME type of the image
        var mimeType = "image/png"; // Replace with the appropriate MIME type for your image

        // Return the image as a FileResult
        return new FileContentResult(imageData, mimeType);
    }
}

