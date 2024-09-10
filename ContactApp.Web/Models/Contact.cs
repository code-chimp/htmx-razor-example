using System.ComponentModel.DataAnnotations;

namespace ContactApp.Web.Models;

public class Contact
{
    public int Id { get; set; }

    public string First { get; set; }

    public string Last { get; set; }

    [Phone]
    public string Phone { get; set; }

    [EmailAddress]
    public string Email { get; set; }
}
