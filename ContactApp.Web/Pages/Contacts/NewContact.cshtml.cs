using ContactApp.Web.Models;
using ContactApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactApp.Web.Pages;

public class NewContactModel : PageModel
{
    private readonly ILogger<NewContactModel> _logger;
    private readonly IContactService _service;

    [BindProperty]
    public ContactEdit NewContact { get; set; }

    public NewContactModel(ILogger<NewContactModel> logger, IContactService service)
    {
        _logger = logger;
        _service = service;
    }

    public void OnGet()
    {
        NewContact = new ContactEdit();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var contacts = _service.GetAll();

        if (contacts.Any(contact => contact.Email == NewContact.Email))
        {
            ModelState.AddModelError("Email", "Email already exists");
            return Page();
        }

        if (_service.Create(NewContact))
        {
            return RedirectToPage("ViewAllContacts");
        }

        return Page();
    }
}
