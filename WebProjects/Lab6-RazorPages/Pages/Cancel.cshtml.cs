using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_6_albertspencer.Models;

namespace lab_6_albertspencer.Pages
{
public class CancelModel : PageModel
    {
    [BindProperty]
    public Cancel CancelObject { get; set; } = new Cancel();

     public void OnGet()
     {
    }
    public IActionResult OnPost()
        {
        if (!ModelState.IsValid)
            {
             return Page();
            }
            return RedirectToPage("Confirmation");
        }
    }
}
