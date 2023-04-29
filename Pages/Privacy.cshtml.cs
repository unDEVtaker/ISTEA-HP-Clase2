using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    public Form Data { get; set; }

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var parametro = Request.Query["parametrox"];
        Data = new Form();
        Data.Mail = parametro;
        Data.Password = "12345";
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {//si es falso
            return Page();
        }
        return RedirectToPage("Index");
    }
}