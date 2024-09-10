using System.Diagnostics;
using ContactApp.Web.Models;
using ContactApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactApp.Web.Pages;

public class EditContactModel : PageModel
{
    private readonly ILogger<EditContactModel> _logger;
    private readonly IContactService _service;

    [FromRoute]
    public int Id { get; set; }

    [BindProperty]
    public ContactEdit UpdateContact { get; set; }

    public EditContactModel(ILogger<EditContactModel> logger, IContactService service)
    {
        _logger = logger;
        _service = service;
    }

    public void OnGet()
    {
        var dao = _service.Get(Id);

        UpdateContact = new ContactEdit
        {
            Id = dao.Id,
            First = dao.First,
            Last = dao.Last,
            Email = dao.Email,
            Phone = dao.Phone
        };
    }

    public IActionResult OnPostEdit()
    {
        UpdateContact.Id = Id;

        if (!ModelState.IsValid)
        {
            return Page();
        }

        var contacts = _service.GetAll();

        var dupe = contacts.FirstOrDefault(c =>
            c.Email == UpdateContact.Email && c.Id != UpdateContact.Id
        );

        if (contacts.Any(c => c.Email == UpdateContact.Email && c.Id != UpdateContact.Id))
        {
            ModelState.AddModelError("Email", "Email is already in use by another contact");
            return Page();
        }

        if (_service.Update(UpdateContact))
        {
            return RedirectToPage("ViewAllContacts");
        }

        return Page();
    }

    public IActionResult OnPostDelete()
    {
        if (_service.Delete(Id))
        {
            return RedirectToPage("ViewAllContacts");
        }

        return Page();
    }
}
