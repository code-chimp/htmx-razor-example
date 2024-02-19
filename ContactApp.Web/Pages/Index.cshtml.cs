using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactApp.Web.Pages;

public class Index : PageModel
{
    public void OnGet()
    {
        Response.Redirect("/contacts/");
    }
}