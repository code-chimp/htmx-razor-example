using ContactApp.Web.Models;

namespace ContactApp.Web.Services;

public interface IContactService
{
    Contact Get(int id);
    
    IEnumerable<Contact> GetAll();
    
    IEnumerable<Contact> Search(string query);
    
    bool Create(ContactEdit contact);
    
    bool Update(ContactEdit contact);
    
    bool Delete(int id);
}