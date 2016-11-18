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
        return View["homepage.cshtml"];
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
