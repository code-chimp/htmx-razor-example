using System.ComponentModel.DataAnnotations;

namespace ContactApp.Web.Models;

public class ContactEdit
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "First name is required")]
    public string First { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    public string Last { get; set; }

    [Phone(ErrorMessage = "Phone number you entered is not valid")]
    [Required(ErrorMessage = "A valid phone number is required")]
    public string Phone { get; set; }

    [EmailAddress(ErrorMessage = "The email address you entered is not valid")]
    [Required(ErrorMessage = "A valid email address is required")]
    public string Email { get; set; }
}