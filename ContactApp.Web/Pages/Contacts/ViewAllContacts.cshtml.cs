using System.Diagnostics;
using ContactApp.Web.Models;
using ContactApp.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactApp.Web.Pages.Contacts;

public class ViewAllContactsModel : PageModel
{
    private readonly ILogger<ViewAllContactsModel> _logger;
    private readonly IContactService _service;

    public IEnumerable<Contact> Contacts { get; private set; } = [];

    public ViewAllContactsModel(ILogger<ViewAllContactsModel> logger, IContactService service)
    {
        _logger = logger;
        _service = service;
    }

    public void OnGet()
    {
        // check for query string "q" and filter contacts
        if (Request.Query.ContainsKey("q"))
        {
            var query = Request.Query["q"].ToString();
            Contacts = string.IsNullOrEmpty(query) ? _service.GetAll() : _service.Search(query);
            return;
        }

        Contacts = _service.GetAll();
    }
}
