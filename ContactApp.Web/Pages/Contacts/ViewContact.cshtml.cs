using ContactApp.Web.Models;
using ContactApp.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactApp.Web.Pages;

public class ViewContactModel : PageModel
{
    private readonly ILogger<ViewContactModel> _logger;
    private readonly IContactService _service;

    public Contact Contact { get; private set; }

    public ViewContactModel(ILogger<ViewContactModel> logger, IContactService service)
    {
        _logger = logger;
        _service = service;
    }

    public void OnGet(int id)
    {
        Contact = _service.Get(id);
    }
}
