using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SDWebApp.Pages;

public class ArchitectureModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public ArchitectureModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
