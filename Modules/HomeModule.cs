using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allContacts = Contact.GetAll();
        return View["homepage.cshtml", allContacts];
      };
      Get["/allcontacts/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["/contacts.cshtml", contact];
      };

      Post["/contact"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["allcontacts.cshtml", allContacts];
      };

      Get["/contact"] = _ => {
        return View["add_new_contact.cshtml"];
      };
      Post["/contact/new"] = _ => {
        string inputName = Request.Form["new-name"];
        int inputPhone = int.Parse(Request.Form["new-phone"]);
        string inputAddress = Request.Form["new-address"];

        Contact inputContact = new Contact(inputName, inputPhone, inputAddress);

        return View["contact_added.cshtml", inputContact];
      };
      Get["/allcontacts"] = _ => {
        return View["allcontacts.cshtml", Contact.ViewAllContacts()];
      };
      Post["/clear"] = _ => {
        Contact.ClearAllContacts();
        return View["clear"];
      };
    }
  }
}
